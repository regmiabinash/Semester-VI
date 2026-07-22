using System;

namespace Destructors
{
    public class Test
    {
        public int Id;
        public string Name;
        public Test()
        {
            Id = 0;
            Name = "Ram";
        }
        public void Displayinfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}");
        }
        ~Test()
        {
            Console.WriteLine("Destructor called");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Displayinfo();
        }
    }
}