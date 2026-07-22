using System;
namespace Strings
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ////Character Conversion
            string s = "Hello";
            Console.WriteLine(s[0]);  // Output: 'H'

            Console.WriteLine(s.Length);  // Output: 5
            Console.WriteLine(s.IndexOf('e'));  // Output: 1
            Console.WriteLine(s.LastIndexOf('l'));  // Output: 3
            Console.WriteLine(s.Contains("lo"));  // Output: True
            Console.WriteLine(s.StartsWith("He"));  // Output: True
            Console.WriteLine(s.EndsWith("lo"));  // Output: True
            Console.WriteLine(s.Substring(1, 3));  // Output: "ell"
            Console.WriteLine(s.ToUpper());  // Output: "HELLO"
            Console.WriteLine(s.ToLower());  // Output: "hello"

            ////String Concatenation
            string str1 = "Hello";
            string str2 = "World";
            string result = str1 + " " + str2;
            Console.WriteLine(result);
            // Output: "Hello World"

            string result2 = string.Concat(str1, " ", str2);
            Console.WriteLine(result2);
            // Output: "Hello World"

            //String Interpolation
            string name = "Alice";
            int age = 30;
            string message = $"My name is {name} and I am {age} years old.";
            Console.WriteLine(message);
            // Output: "My name is Alice and I am 30 years old."
        }
    }
}
