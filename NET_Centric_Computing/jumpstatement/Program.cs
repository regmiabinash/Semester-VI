using System;

namespace jumpstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //goto
            Console.WriteLine("Before the jump statement");

            goto JumpLabel;

            Console.WriteLine("This line will be skipped due to the jump statement");

        JumpLabel:
            Console.WriteLine("After the jump statement");

            // continue and break
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                else if (i == 4)
                {
                    break;
                }
                Console.WriteLine($"Current value of i: {i}");
            }
            //return
            int number = 10;
            int result = Add(number);
        }
        public static int Add(int number)
        {
            Console.WriteLine("Inside the Add method");
            Console.WriteLine(number);
            return number + number;
            Console.WriteLine("This line will not be executed due to the return statement");
            return number;

        }
    }
}