using System;
using System.Collections.Generic;

namespace Entities

{
    public class Person
    {
         List<Award> listAward;
        private string lastName;
        private string firstName;
        //private int age;
        private DateTime dateBirth;

        public int ID
        {
            get; private set;
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new Exception("Длинная фамилия!");
                }
                lastName = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new Exception("Некорректное имя!");
                }
                firstName = value;
            }
        }
        public DateTime DateBirth
        {
            get
            {
                return dateBirth;
            }
            set
            {
                if (value > DateTime.Now || GetAge(value) > 150)
                {
                    throw new Exception("Некорректная дата!");
                }
                dateBirth = value;
            }
        }
        public int Age
        {
            get
            {
                return GetAge(DateBirth);
            }
        }
        private int GetAge(DateTime date)
        {
            DateTime dateNow = DateTime.Now;
            int day = dateNow.Day - date.Day;
            int month = dateNow.Month - date.Month;
            int year = dateNow.Year - date.Year;
            if ((month > 0) || ((month == 0) && (day >= 0)))
            {

                return year;
            }
            return year - 1;
        }
        public Person(string name, string surname, DateTime datebirthday)
        {
            FirstName = name;
            LastName = surname;
            dateBirth = datebirthday;
            listAward = new List<Award>();
            ID = base.GetHashCode();
        }

        public Person(int ID, string name, string surname, DateTime datebirthday)
        {
            FirstName = name;
            LastName = surname;
            dateBirth = datebirthday;
            listAward = new List<Award>();
            this.ID= ID;
        }


        public override string ToString()
        {
            return $"Фамилия: {LastName} \nИмя: {FirstName}  " +
                $"\nВозраст: {Age} \nДата рождения: {DateBirth.ToShortDateString()}";
        }

        public void AddNewAward(Award award)
        {
            if (!listAward.Contains(award))
            {
                listAward.Add(award);
            }
        }

        public void UpdateData(Person p)
        {

            LastName = p.LastName;
            FirstName = p.FirstName;
            dateBirth = p.DateBirth;
            listAward = p.GetAwards();
            ID = p.ID;
        }

        public void DeleteAward(Award award)
        {
            if (listAward.Contains(award))
            {
                listAward.Remove(award);
            }
            
        }

        public List<Award> GetAwards()
        {
            return listAward;
        }
    }

    public class Award
    {
        private string name;
        private string description;
        public int ID
        {
            get;
            
            private set;

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new Exception("Некорректное имя!");
                }
                name = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Length > 250 )
                {
                    throw new Exception("Некорректное описание!");
                }
                description = value;
            }
        }

        public Award(string name)
        {
            ID = base.GetHashCode();
            Name = name;
        }
        public Award(string nameAward, string descrip)
        {
            ID = base.GetHashCode();
            Name = nameAward;
            Description = descrip;
        }
        public Award(int ID, string nameAward, string descrip)
        {
            this.ID = ID;
            Name = nameAward;
            Description = descrip;
        }
        public Award(int ID, string nameAward)
        {
            this.ID = ID;
            Name = nameAward;
            //Description = descrip;
        }
        public void UpdateData(Award award)
        {
            Name = award.Name;
            Description = award.Description;
            ID = award.ID;
        }


    }


}
