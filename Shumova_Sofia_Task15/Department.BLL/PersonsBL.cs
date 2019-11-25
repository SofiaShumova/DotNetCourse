using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.DAL;
using Entities;


namespace Department.BLL
{
    public class PersonsBL
    {
        private PersonsDAO people;
        public PersonsBL()
        {
            people = new PersonsDAO();
            InitList();
        }

        private void InitList()
        {
            people.AddPerson("Sofia", "Shumova", new DateTime(1999,11,24));
            people.AddPerson("John", "Klon", new DateTime(2003,7,2));
            people.AddPerson("Lucy", "Klukina", new DateTime(2008,5,3));
            people.AddPerson("Will", "Baies", new DateTime(2001,6,9));

            //return people.ListPersons;
        }

        public List<Person>People
        {
            get
            {
                return people.ListPersons;
            }
        }

        public void AddPerson(string name, string surname, DateTime date)
        {
            people.AddPerson(new Person(name, surname, date));
        }
        public void AddPerson(string name, string surname, DateTime date, Award award)
        {
            Person person = new Person(name, surname, date);
            people.AddPerson(person);
            people.AddAwardPerson(award, person);
        }
        public void AddPerson(Person person)
        {
            people.AddPerson(person);
        }

        public void AddAwardPerson(Award award, Person person)
        {
            people.AddAwardPerson(award, person);
        }

        public List<Award> AwardsPerson(Person person)
        {
            return people[people.ListPersons.FindIndex(item => item == person)].GetAwards();
        }
        public List<Award> AwardsPerson(int IDPerson)
        {
            return people[people.ListPersons.FindIndex(item => item.ID == IDPerson)].GetAwards();
        }

        public void ReplaceData(int oldID, string newName, string newSurname, DateTime newDate)
        {
            int index = people.ListPersons.FindIndex(item => item.ID == oldID);
            people[index].FirstName = newName;
            people[index].LastName = newSurname;
            people[index].DateBirth = newDate;
        }

        public void ReplaceData(Person person)
        {
            int index = people.ListPersons.FindIndex(item => item.ID == person.ID);
            people[index].FirstName = person.FirstName;
            people[index].LastName = person.LastName;
            people[index].DateBirth = person.DateBirth;
        }

        public void DeletePerson(int IDPerson)
        {
            people.DeletePerson(IDPerson);
        }
        public void DeletePerson(Person person)
        {
            people.DeletePerson(person);
        }

        public Person GetPerson(int ID)
        {
            int index = people.ListPersons.FindIndex(item => item.ID == ID);
            return people.ListPersons[index];
        }
    }
}
