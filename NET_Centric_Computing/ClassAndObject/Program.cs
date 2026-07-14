using System;
using ClassAndObject;

namespace ClassAndObject
{
    class Program
    {
        static void Main()
        {
                Car myCar = new Car();

                Car myCar1 = new Car();


                myCar.Model = "Toyota";
                myCar.Color = "Red"; 
                myCar.Year = 2020;

                myCar1.Model = "Ford";
                myCar1.Color = "Blue";
                myCar1.Year = 2021;


                myCar.Start();
                myCar.Accelerate();
                myCar.Brake();

                myCar1.Accelerate();
                myCar1.Brake();
                myCar1.Start();

                Console.WriteLine("This is a properties of Car myCar");
                Console.WriteLine(myCar.Year);
                Console.WriteLine(myCar.Model);
                Console.WriteLine(myCar.Color);

            

        }
    }
}
