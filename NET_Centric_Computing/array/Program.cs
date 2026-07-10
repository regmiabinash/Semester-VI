using System;
using System.Runtime.InteropServices;

namespace array
{
    class Program
    {

        public static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i =0; i<numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Even number:");
            foreach (int number in numbers)
            {
                if (number%2 == 0)
                {
                    Console.WriteLine(" The even numbers are :" + number);
                }
                
            }

            Console.WriteLine("Odd number:  ");
            foreach(int number in numbers)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
            }
            //string[] arr = new string[4];
            //Console.WriteLine("Enter 4 Names: ");
            
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i]=Console.ReadLine();
   
            //}
            //foreach (string name in arr)
            //{


                
            //    Console.WriteLine(name);
            //}

        }
    }
}
