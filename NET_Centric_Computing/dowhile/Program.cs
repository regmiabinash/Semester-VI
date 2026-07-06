using System;

namespace Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a < 10)
            {
                Console.WriteLine(a);
                a++;
            }

            int b = 2;
            do
            {
                Console.WriteLine(b);
                b++;
            }
            while (b < 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}