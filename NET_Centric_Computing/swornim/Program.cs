using System;

namespace swornim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string first_name = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            string last_name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32  (Console.ReadLine());
            Console.WriteLine(age);

            string full_name = first_name + " " + last_name + " " [age];
            Console.WriteLine(full_name);
        }
    }
}
