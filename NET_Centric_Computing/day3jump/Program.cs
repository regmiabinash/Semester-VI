using System;

namespace jump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Each Loop");
            int[] numbersArray = { 1, 2, 3, 4, 5 };
            foreach (int number in numbersArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}