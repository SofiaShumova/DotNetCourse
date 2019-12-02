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
        private IDataPerson people;
        public PersonsBL(IDataPerson data)
        {
            people = data;
            //InitList();
        }

        private void InitList()
        {
            people.AddPerson(new Person("Sofia", "Shumova", new DateTime(1999,11,24)));
            people.AddPerson(new Person("John", "Klon", new DateTime(2003, 7, 2)));
            people.AddPerson(new Person("Lucy", "Klukina", new DateTime(2008, 5, 3)));
            people.AddPerson(new Person("Will", "Baies", new DateTime(2001, 6, 9)));

            //return people.ListPersons;
        }

        public ICollection<Person>People
        {
            get
            {
                return people.GetPeople();
            }
        }

       
        public void AddPerson(Person person)
        {
            people.AddPerson(person);
        }

        public void AddAwardPerson(Award award, Person person)
        {
            people.AddAwardPerson(person,award);
        }

        public ICollection<Award> AwardsPerson(Person person)
        {
            return people.GetAwardsForPerson(person);
        }

       

        public void ReplaceData(Person person)
        {
            people.ReplaceData(person);
        }

        public void DeletePerson(Person person)
        {
            people.DeletePerson(person);
        }

        public Person GetPerson(int ID)
        {
            int index = people.GetPeople().ToList().FindIndex(item => item.ID == ID);
            return people.GetPeople().ToList()[index];
        }
    }
}
