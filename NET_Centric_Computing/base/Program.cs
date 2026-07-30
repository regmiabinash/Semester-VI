using System;

namespace BaseKeyword
{
    public class ParentClass
    {
        public string Message;
        //public ParentClass(string message)
        //{
        //    Message = message;
        //}
        public void DisplayMessage()
        {
            Console.WriteLine($"ParentClass Message: {Message}");
        }
        public virtual void Test()
        {
            Console.WriteLine("ParentClass Test method");
        }
    }
    public class ChildClass : ParentClass
    {
        //public ChildClass(string message) : base(message)
        //{
        //}
        public void DisplayChildMessage()
        {
            Console.WriteLine($"ChildClass Message");
            base.Test();
        }
        public override void Test()
        {
            Console.WriteLine("ChildClass Test method");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = "Hello from ParentClass!";
            ChildClass child = new ChildClass();
            child.DisplayChildMessage();
            child.DisplayMessage();
        }
    }
}