using System;

namespace ThakeyDar
{
    public class NewHouse
    {        //static void Main(string[] args)

        //{
        //    Console.WriteLine("Hello World!");
        //}
        public delegate string Thakeydar();
        public static string Labour()
        {
            Console.WriteLine("This is me Labour");
            return "This is me Labour";
        }
        public static string Painter()
        {
            Console.WriteLine("This is me Austrian Painter");
            return "This    ";

        }
        public static string Marvel()
        {
            Console.WriteLine("This is me Hitler");
            return "This";
        }

        public static void Main()
        {
            Thakeydar del = Labour;
            del();

            del = Painter;
            del();

            del = Marvel;
            del();

        }
    }
}
