using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using Entities;
using System.Xml;

namespace Department.DAL
{
    public  class PersonsSqlDAO: IDataPerson
    {
        //private SqlConnection connection = InitConnectionPersonAward.InitConnection();

        public void AddPerson(Person person)
        {
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = "AddPerson";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@firstName", person.FirstName);
                    command.Parameters.AddWithValue("@lastName", person.LastName);
                    command.Parameters.AddWithValue("@birthdate", person.DateBirth);


                    command.ExecuteNonQuery();
                }
                connection.Close();

            }
        }
        public void ReplaceData(Person person)
        {
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = "UpdatePersonByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@id", person.ID);
                    command.Parameters.AddWithValue("@newFirstName", person.FirstName);
                    command.Parameters.AddWithValue("@newLastName", person.LastName);
                    command.Parameters.AddWithValue("@newDateDirth", person.DateBirth);


                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
            List<Award> list = GetAwardsForPerson(person).ToList();
            foreach(Award i in person.GetAwards())
            {
                if (!list.Contains(i)) AddAwardPerson(person, i);
            }
        }
        public void DeletePerson(Person person)
        {
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SqlCommand("DeletePerson", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@personId", person.ID);

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void AddAwardPerson(Person person, Award award)
        {
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SqlCommand("AddAwardForPerson", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_person", person.ID);
                    command.Parameters.AddWithValue("@id_award", award.ID);

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }


        }
        public ICollection<Award> GetAwardsForPerson(Person person)
        {
            //connection.Open();
            List<Award> awards = new List<Award>();
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "SELECT Award.* FROM PersonAndAwards INNER JOIN Award ON Award.ID = PersonAndAwards.ID_Award WHERE ID_Person = @id_person";
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id_person", person.ID);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        var award = new Award(reader.GetInt32(0), reader.GetString(1));
                        // if (!reader.GetBoolean(2) ) award.Description = reader.GetString(2);
                        awards.Add(award);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            
            return awards;
        }

        public ICollection<Person> GetPeople()
        {
           
            List<Person> persons = new List<Person>();
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Person", connection))
                {
                    //command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var person = new Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                        //person.GetAwards().AddRange(GetAwardsForPerson(person));
                        persons.Add(person);
                    }

                    reader.Close();
                }
                connection.Close();
            }

            foreach(Person i in persons)
            {

                i.GetAwards().AddRange(GetAwardsForPerson(i));
            }
            return persons;


        }
    }
}
