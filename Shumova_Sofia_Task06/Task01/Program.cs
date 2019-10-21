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
                dateBirth = AssignValueDateBirthday(value);
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
            dateBirth = AssignValueDateBirthday(datebirthday);
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
                workExperience = AssignValueExperience(value);
            }
        }

        public Employee(string name, string surname, string patr, DateTime datebirthday,
            string positionEmployee, int experienceEmployee) : base(name, surname, patr, datebirthday)
        {
            workExperience = AssignValueExperience(experienceEmployee);
            WorkPost = positionEmployee;
            
        }

        public Employee( User user, string positionEmployee, int experienceEmployee) :
            base(user.FirstName, user.LastName, user.Patronymic, user.DateBirth)
        {
            workExperience = AssignValueExperience(experienceEmployee);
            WorkPost = positionEmployee;      
        }


        public Employee() : base(){}

        private bool ValidWorkExperience(int expirence)
        {
            return (expirence < Age);
        }

        private int AssignValueExperience(int inputValueExperience)
        {
            if (ValidWorkExperience(inputValueExperience))
            {
                return inputValueExperience;
            }
            
                throw new Exception("Некорректное значение!");
        }
       

        public string GetEmloyeesInfo()
        {

            return $"Должность: {WorkPost}\nСтаж работы: {workExperience} лет";
        }


        public string GetFullInfo()
        {
            
            return ToString()+ GetEmloyeesInfo();
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
                Employee firstEmployee = new Employee(firstUser, GetInfo("должность"), ParseNumberValid("опыт работы"));

                Console.WriteLine();
                Console.WriteLine("Пользователь:");
                Console.Write(firstUser);

                Console.WriteLine();
                Console.WriteLine("Сотрудник:");
                Console.Write(firstEmployee.GetEmloyeesInfo());
            }
            catch(Exception ex)
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
