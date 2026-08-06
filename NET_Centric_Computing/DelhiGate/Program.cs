using System;

public class Program
{
    public delegate void MyDelegate();


    public static void Hello()
    {
        Console.WriteLine("Hello World! ");
    }

    public static void HiFunc()
    {
        Console.WriteLine("Hi World! ");
    }

    public static void Main()

    {
        MyDelegate del = Hello;
        del();
        del = HiFunc;
        del();
    }


}


