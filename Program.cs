using System;

namespace MyNamespace
{
    class Person
    {
        public Person()
        {
            this.name = "";
            this.age = 0;
        }
        public Person(string nameP, int ageP)
        {
            this.name = nameP;
            this.age = ageP;
        }
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }

        public void ShowData()
        {
            Console.WriteLine($"Name: {name} \n Age: {Age}");
        }
        public void OlderAge()
        {
            Console.WriteLine($"{name} is the oldest person, {Age} years old!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name of first person: ");
            string name = Console.ReadLine();
            Console.Write("Age of first person: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name, age);

            Console.Write("Name of second person: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Age of second person: ");
            age = Convert.ToInt32(Console.ReadLine());
            Person person2 = new Person(name, age);

            Console.Write("Name of third person: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Age of third person: ");
            age = Convert.ToInt32(Console.ReadLine());
            Person person3 = new Person(name, age);


            person.ShowData();
            person2.ShowData();
            person3.ShowData();

            if (person.Age > person2.Age && person.Age > person3.Age)
            {
                person.OlderAge();
            }
            else if (person2.Age > person.Age && person2.Age > person3.Age)
            {
                person2.OlderAge();
            }
            else if (person2.Age == person.Age && person2.Age == person3.Age)
            {
                Console.WriteLine("All people are the same age!");
            }
            else
            {
                person3.OlderAge();
            }
        }
    }

}