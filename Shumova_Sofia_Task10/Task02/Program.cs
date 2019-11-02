using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{

    public class WorkEventArgs : EventArgs
    {
        public TimeSpan Time { get; }

        public WorkEventArgs(TimeSpan time)
        {
            Time = time;
        }
    }


    public delegate void WorkEventHandler(Person p, TimeSpan time);
    public delegate void ActionHandler(string message);
    public delegate void LeaveHandler(Person man);
    public class Person
    {
        //public delegate void WorkEventHandler(Person sender, WorkEventArgs args);
        // public delegate void WorkEventHandler(Person sender, TimeSpan time);

        public event WorkEventHandler onCome;
        public event LeaveHandler onLeave;
        //public event EventHandler onLeave;
        public event ActionHandler Notify;


        public string name { get; set; }
        bool stateAction;

        public Person(string namePerson)
        {
            name = namePerson;
        }

        public void Come(TimeSpan time)
        {
                onCome?.Invoke(this, time);
        }

        public void Leave()
        {
                onLeave?.Invoke(this);
            
        }

        public void Parting(string otherPerson)
        {
                Console.WriteLine($"Пока, {otherPerson}  -  сказал {name}");
            
        }

        public void Greet(string otherPerson, TimeSpan Time)
        {
            string message = "";
            int time = Convert.ToInt32(Time.Hours);

            if (time >= 6 && time <= 12)
            {
                message = $"Утренний привет, {otherPerson}  - сказал {name}";
            }
            else if (time > 12 && time <= 16)
            {
                message = $"Дневной привет, {otherPerson}  - сказал {name}";
            }
            else if (time > 16 && time <= 22)
            {
                message = $"Вечерний привет, {otherPerson}  - сказал {name}";
            }
            else
            {
                message = $"Иди домой, {otherPerson}  - сказал {name}";
            }
            Console.WriteLine(message);

        }


        public void Display(string message)
        {
            Console.WriteLine(message);
        }

    }
    public delegate void SayHello(string p, TimeSpan time);
    public delegate void SayBye(string otherName);

    class Office
    {
        // хранит ссылки на методы приветствий
        private SayHello greetAll;

        // хранит ссылки на методы прощания
        private SayBye byeAll;

        public Office(List<Person> persons)
        {
            foreach (var p in persons)
            {
                // подписываемся на события Person
                p.onCome += OnCameHandler;
                p.onLeave += OnLeaveHandler;
            }
        }

        private void OnCameHandler(Person p, TimeSpan time)
        {

            Console.WriteLine($"[{p.name} приходит на работу]");

            greetAll?.Invoke(p.name, time);

            greetAll += p.Greet;
            byeAll += p.Parting;
        }

        private void OnLeaveHandler(Person p)
        {
            Console.WriteLine($"[{p.name} уходит]");

            greetAll -= p.Greet;
            byeAll -= p.Parting;


            byeAll?.Invoke(p.name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Events. Office");


            Person hugo = new Person("Хуго");
            Person jane = new Person("Джейн");
            List<Person> list = new List<Person>();
            list.Add(hugo); list.Add(jane);

            Office office = new Office(list);
            TimeSpan time = new TimeSpan(18, 30, 0);
            TimeSpan time1 = new TimeSpan(19, 30, 0);

            hugo.Come(time);
            jane.Come(time1);
            hugo.Leave();
            jane.Leave();




            Console.ReadKey();
        }


    }
}
