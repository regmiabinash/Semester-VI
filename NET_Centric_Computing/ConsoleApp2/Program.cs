using System;

namespace Base
{
    public class ParentClass
    {
        public string Name;

        public ParentClass(string name)
        {
            Name = name;
        }

        public void DisplayParent()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    public class ChildClass : ParentClass
    {
        public int Roll;

        public ChildClass(string name, int roll) : base(name)
        {
            Roll = roll;
        }
        public void DisplayChild()
        {
            Console.WriteLine($"Name: {Name}, Roll: {Roll}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ParentClass parent = new ParentClass("Dipesh");
            parent.DisplayParent();

            ChildClass child = new ChildClass("Dipesh", 7);
            child.DisplayChild();
        }
    }
}