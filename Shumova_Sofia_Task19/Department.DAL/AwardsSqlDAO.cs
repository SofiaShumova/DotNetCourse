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
    public class AwardsSqlDAO: IDataAward
    {
        private SqlConnection connection = InitConnectionPersonAward.InitConnection();

        public void Add(Award award)
        {
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("AddAward", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nameAward", award.Name);
                    //if (String.IsNullOrEmpty(award.Description)) award.Description = "";
                    command.Parameters.AddWithValue("@descAward", award.Description);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void Delete(Award award)
        {
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DeleteAward", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", award.ID);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void ReplaceData(Award award)
        {
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UpdateAwardByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", award.ID);
                    command.Parameters.AddWithValue("@newName", award.Name);
                    command.Parameters.AddWithValue("@newDesc", award.Description);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public ICollection<Award> GetAwards()
        {
            List<Award> awards = new List<Award>();
            using (var connection = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Award", connection))
                {
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var award = new Award(reader.GetInt32(0), reader.GetString(1), reader[2]?.ToString()); // null for description
                        awards.Add(award);
                    }

                    reader.Close();
                }
                connection.Close();
            }
       
            return awards;
        }
    }

}
