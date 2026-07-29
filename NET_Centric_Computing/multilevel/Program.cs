using System;

namespace Multilevel
{
    public class Animal
    {
        public string Name { get; set; }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
    public class Domestic : Animal
    {
    }
    public class Cat : Domestic
    {
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Animal A = new Animal();
            A.Name = "Animal";
            A.Display();
            Domestic D = new Domestic();
            D.Name = "Domestic";
            D.Display();
            Cat C = new Cat();
            C.Name = "Cat";
            C.Display();
        }
    }
}