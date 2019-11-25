using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Department.DAL
{
    public class PersonsDAO
    {
        private List<Person> listPersons = new List<Person>();
        public void AddPerson(string name, string surname, DateTime date)
        {
            if (listPersons != null)
            {
                listPersons.Add(new Person(name, surname, date));
            }
            else
            {
                throw new Exception();
            }

        }

        public void AddPerson(Person person)
        {

            if (listPersons != null)
            {
                listPersons.Add(person);
            }
            else
            {
                throw new Exception();
            }

        }

        public void AddAwardPerson(Award award, Person person)
        {

            if (listPersons != null)
            {
                listPersons[listPersons.FindIndex(item => item == person)].AddNewAward(award);
            }
            else
            {
                throw new Exception();
            }
        }

        public void DeletePerson(int IDPerson)
        {
            if (listPersons != null)
            {
                listPersons.RemoveAt(listPersons.FindIndex(item => item.ID == IDPerson));
            }
            else
            {
                throw new Exception();
            }
            
        }
        public void DeletePerson(Person person)
        {
            if (listPersons != null)
            {
                listPersons.Remove(person);
            }
            else
            {
                throw new Exception();
            }

        }

        public List<Person> ListPersons
        {
            get
            {
                return listPersons;
            }
            
        }

        public Person this[int index]
        {
            get { return listPersons[index]; }
        }

    }
}
