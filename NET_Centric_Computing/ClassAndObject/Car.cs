using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    public class Car
    {
        public string Color;
        public string Model;
        public int Year;

        public void Start()
        {
            Console.WriteLine("Car is starting...");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating...");
        }

        public void Brake()

        {
            Console.WriteLine("Car is braking...");

        }
    }

    //public class Person { }
    //{
    //    public int 1D;
    //    public string Name;
    //    public string Address;
    //}

    ////behavior
    //public void Eat()
    //{
    //    Console.WriteLine('Eating');
    //}

    //public void Sleep()
    //{
    //    Console.WriteLine('zzzzzzzzzzz....');
    //}

    //public class Test
    //{
    //    Person P = new Person();
    //    Person.1D = 1;
    //    P.Name = "John";
    //    P.Address = "Ktm";
    //    P.Eat()
    //}

}

