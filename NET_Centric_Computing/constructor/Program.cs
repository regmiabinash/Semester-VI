using System;

namespace Constructor
{
    public class Person
    {
        public int Age;
        public string Name;

        public static string Category;

        static Person()
        {
            Category = "Human";
        }

        private Person(int age, string name)
        {
            Name = name;
            Age = age;

        }
        public static Person CreateSpecialPerson(int age, string name)
        {
            return new Person(age, name);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Category: {Category}");
        }

        ~Person()
        {
            Console.WriteLine("Hello Bye");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Category from static constructor: {Person.Category}");
            Person p4 = Person.CreateSpecialPerson(30, "John Doe");
            p4.DisplayInfo();
        }
    }
}