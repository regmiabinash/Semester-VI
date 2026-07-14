using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class person
    {
        public int Id;
        public string Name;
        public int Age;

        public void Eat()
        {
            Console.WriteLine($"Eating {Name} of {Id} with {Age}");
        }

        public void Sleep()
        {
            Console.WriteLine($"Sleeping {Name} ");

        }

        public void Walk()
        {
            Console.WriteLine("walking");
        }
    }
}
