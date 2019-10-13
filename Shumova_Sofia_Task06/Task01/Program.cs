using System;


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

    class Employee : User
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
                AssignValueExperience(value, out workExperience);
            }
        }

        public Employee(string name, string surname, string patr, DateTime datebirthday,
            string positionEmployee, int experienceEmployee) : base(name, surname, patr, datebirthday)
        {
            AssignValueExperience(experienceEmployee, out workExperience);
            WorkPost = positionEmployee;
            
        }

        public Employee( User user, string positionEmployee, int experienceEmployee) :
            base(user.FirstName, user.LastName, user.Patronymic, user.DateBirth)
        {
            AssignValueExperience(experienceEmployee, out workExperience);
            WorkPost = positionEmployee;      
        }


        public Employee() : base()
        {
            WorkPost = "";
            WorkExperience = 0;
        }

        private bool ConditionValidWorkExperience(int expirence)
        {
            if (expirence > Age)
            {
                return false;
            }
            return true;
        }

        private void AssignValueExperience(int inputValueExperience, out int valueExperience)
        {
            if (ConditionValidWorkExperience(inputValueExperience))
            {
                valueExperience = inputValueExperience;
            }
            else
            {
                throw new Exception("Некорректное значение!");
            }

        }
       

        public string GetEmloyeesInfo()
        {

            return $"\nДолжность: {WorkPost}\nСтаж работы: {workExperience} лет";
        }


        public string GetFullInfo()
        {
            
            return ToString()+ $"\nДолжность: {WorkPost}\nСтаж работы: {workExperience} лет";
        }        
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь.");
            User firstUser = new User(GetInfo("фамилию"), GetInfo("имя"), GetInfo("отчество"), ParseDate("дату рождения"));
            Console.WriteLine();
            Employee firstEmployee = new Employee(firstUser, GetInfo("должность"), ParseNumberValid("опыт работы"));

            Console.WriteLine();
            Console.WriteLine("Пользователь:");
            Console.Write(firstUser.ToString());

            Console.WriteLine();
            Console.WriteLine("Сотрудник:");
            Console.Write(firstEmployee.GetEmloyeesInfo());
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

        public static int ParseNumberValid(string nameInfo)
        {
            int x;
            while (!(((int.TryParse(GetInfo(nameInfo), out x))) && (x > 0)))
            {
                Console.Write("Указано некорректное значение! ");
            }

            return x;
        }
    }





}
