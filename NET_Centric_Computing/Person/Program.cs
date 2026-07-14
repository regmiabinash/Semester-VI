using System;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            person1.Id = 1;
            person1.Name = "John";
            person1.Age = 30;

            person1.Eat();
            person1.Sleep();
            person1.Walk();
        }
    }
}
