using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
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
                if(value> DateTime.Now)
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
            dateBirth = datebirthday;
        }

        public User() { }

        private DateTime AssignValueDateBirthday(DateTime inputValueDate)
        {
            if (inputValueDate < DateTime.Now)
            {
                return inputValueDate;
            }

            throw new Exception("Некорректная дата!");


        }

        public override string ToString()
        {
            return $"Фамилия: {LastName} \nИмя: {FirstName} \nОтчество: {Patronymic} " +
                $"\nВозраст: {Age} \nДата рождения: {DateBirth.ToShortDateString()}";
        }



    }

    class Employee : User, IEquatable<Employee>
    {
        string workPost;
        int workExperience;
         
        public string WorkPost { get; set; }
        public int WorkExperience
        {
            get
            {
                return workExperience;
            }
            set
            {
                if(!(value>0 && value < Age))
                {
                    throw new Exception("Некорректное значение опыта работы!");
                }
                workExperience = value;

            }
        }
        public Employee(string name, string surname, string patr, DateTime datebirthday,
            string positionEmployee, int experienceEmployee) : base(name, surname, patr, datebirthday)
        {
            WorkExperience = experienceEmployee;
            WorkPost = positionEmployee;

        }
        public Employee(User user, string positionEmployee, int experienceEmployee) :
            base(user.FirstName, user.LastName, user.Patronymic, user.DateBirth)
        {
            WorkExperience =experienceEmployee;
            WorkPost = positionEmployee;
        }
        public Employee() : base() { }

        public string Info()
        {
            return base.ToString() + ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return Equals(obj as Employee);

        }

        public  bool Equals(Employee employee)
        {
            if ((object)employee == null)
            {
                return false;
            }
            return employee.WorkPost == WorkPost && employee.WorkExperience == WorkExperience;
        }


        public override string ToString()
        {
            return $"Должность: {WorkPost}\nСтаж работы: {workExperience} лет"; ;
        }
        public override int GetHashCode()
        {
            return WorkPost.GetHashCode ^ WorkExperience;
           // return base.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Пользователь.");
                User firstUser = new User(GetInfo("фамилию"), GetInfo("имя"), GetInfo("отчество"), ParseDate("дату рождения"));
                Console.WriteLine();
                Employee firstEmployee = new Employee(firstUser, GetInfo("должность"), GetNumber("опыт работы"));

                Console.WriteLine();
                Console.WriteLine("Пользователь:");
                Console.Write(firstUser);

                Console.WriteLine();
                Console.WriteLine("Сотрудник:");
                Console.Write(firstEmployee.Info());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static string GetInfo(string nameInfo)
        {
            Console.Write("Введите " + nameInfo + ": ");
            return Console.ReadLine();
        }

        public static DateTime ParseDate(string nameInfo) //parse date
        {
            DateTime date;
            while (!DateTime.TryParse(GetInfo(nameInfo), out date))
            {
                Console.Write("Указано некорректное значение! ");
            }
            return date;
        }

        public static int GetNumber(string nameInfo)
        {
            return int.Parse(GetInfo(nameInfo));
        
        }
    }
}
