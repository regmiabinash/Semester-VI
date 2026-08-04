using System;
using System.Text;

namespace Method_Overloading
{
    public class Student
    {
        public String Info(int ID, string Name)
        {
            Console.WriteLine("Student ID: " + ID);
            Console.WriteLine("Student Name: " + Name);
            return "Student Info: " + ID + ", " + Name;
        }
        public String Info(string fname, string lname)
        {
            Console.WriteLine("Student First Name: " + fname);
            Console.WriteLine("Student Last Name: " + lname);
            return "Student Name: " + fname + " " + lname;
        }
        public String Info(int ID, string Name, int Rollno)
        {
            Console.WriteLine("Student ID: " + ID);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Roll No: " + Rollno);
            return "Student Info: " + ID + ", " + Name + ", " + Rollno;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Info(1, "Dipesh");
            student.Info("Dipesh", "Bista");
            student.Info(7, "Dipesh", 18);
        }
    }
}