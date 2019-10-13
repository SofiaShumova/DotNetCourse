using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;




namespace Task01
{
    class User
    {
        private string lastName;
        private string firstName;
        private string patronymic;
        private int age;
        private DateTime dateBirth;

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateBirth
        {
            get
            {
                return dateBirth;
            }
            set
            {
                AssignValueDateBirthday(value, out dateBirth);
            }
        } // написать исключение на дату в сет
        public int Age
        {
            get
            {
                DateTime dateNow = DateTime.Now;
                int day = dateNow.Day - DateBirth.Day;
                int month = dateNow.Month - DateBirth.Month;
                int year = dateNow.Year - DateBirth.Year;
                if ((month > 0) || ((month == 0) && (day >= 0)))
                {

                    return year;
                }
                return year - 1;
            }
        }

        public User(string name, string surname, string patr, DateTime datebirthday)
        {
            LastName = name;
            FirstName = surname;
            Patronymic = patr;
            AssignValueDateBirthday(datebirthday, out dateBirth);         
        }

        public User() { }

        private void AssignValueDateBirthday(DateTime inputValueDate, out DateTime valueDate)
        {
            if (inputValueDate < DateTime.Now)
            {
                valueDate = inputValueDate;
            }
            else
            {
                throw new Exception("Некорректная дата!");
            }

        }
        
        public override string ToString()
        {
            return $"Фамилия: {LastName} \nИмя: {FirstName} \nОтчество: {Patronymic} " +
                $"\nВозраст: {Age} \nДата рождения: {DateBirth.ToShortDateString()}";
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь.");
            User firstUser = new User(GetInfo("фамилию"),GetInfo("имя"),GetInfo("отчество"),ParseDate("дату рождения"));
            firstUser.DateBirth = DateTime.Now.AddYears(200); //исключение в классе

            Console.WriteLine();
            Console.Write(firstUser.ToString()); 
        }

        public static string GetInfo(string nameInfo)
        {
            Console.Write("Введите " + nameInfo + ": ");
            return Console.ReadLine();
        }

        public static DateTime ParseDate(string nameInfo) //parse date
        {
            DateTime date;
            while(!(DateTime.TryParse(GetInfo(nameInfo), out date)))
            {
                Console.Write("Указано некорректное значение! ");
            }
            return date;
        }
    }

}
