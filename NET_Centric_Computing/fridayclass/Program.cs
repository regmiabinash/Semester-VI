using System;

namespace constructor
{
    public class Person
    {
        public string Name;
        public int Age;


        public Person()
        {
             Name = "Unknown";
             Age = 22;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public Person(Person person)
        {
            Name = person.Name;
            Age = person.Age;
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.DisplayInfo();
            Person person2 = new Person("Alice", 30);
            person2.DisplayInfo();
            Person person3 = new Person(person2);
            person3.DisplayInfo();
        }
    }   
}
