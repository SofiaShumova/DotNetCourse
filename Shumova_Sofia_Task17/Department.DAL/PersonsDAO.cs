using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace Department.DAL
{
    public class PersonsDAO : IDataPerson
    {
        private List<Person> collectionPersons = new List<Person>();

        public void AddPerson(Person person)
        {
                collectionPersons.Add(person);
            
        }

        public void AddAwardPerson(Person person, Award award)
        {
                collectionPersons.Find(item => item == person).AddNewAward(award);
            
        }
        public ICollection<Award> GetAwardsForPerson(Person person)
        {
            return person.GetAwards();
        }
        public void ReplaceData(Person person)
        {
            int index = collectionPersons.FindIndex(item => item.ID == person.ID);
            collectionPersons[index].FirstName = person.FirstName;
            collectionPersons[index].LastName = person.LastName;
            collectionPersons[index].DateBirth = person.DateBirth;
        }
        public void DeletePerson(Person person)
        {
            if (collectionPersons != null)
            {
                collectionPersons.Remove(person);
            }
            else
            {
                throw new Exception();
            }

        }

        public ICollection<Person> GetPeople()
        {
           return collectionPersons;
          
        }

        public Person this[int index]
        {
            get { return collectionPersons[index]; }
        }

    }
}
