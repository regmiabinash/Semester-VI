using System;

namespace day2part2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string gender = "F";
            int Age = 17;
            if (gender == "F")
            {
                Console.WriteLine("You are a female");
                 if (Age < 18)
                {
                    Console.WriteLine("You are less than 18");
                }
                else
                {
                    Console.WriteLine("Age is greater than 18");
                }

            }
            else
            {
                Console.WriteLine("You are a male");
                if (Age < 18)
                {
                    Console.WriteLine("You are less than 18");

                }
                else
                {
                    Console.WriteLine("Age is greater than 18");
                }
            }
        }
    }
}
