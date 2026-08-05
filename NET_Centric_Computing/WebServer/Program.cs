using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class WebServer
{
    static async Task Main(string[] args)
    {
        Stopwatch requestStopwatch = Stopwatch.StartNew();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Starting the request...");
        Console.WriteLine(FirstMethod());
        Console.WriteLine(SecondMethod());
        Console.WriteLine(LastMethod());
        requestStopwatch.Stop();
        Console.WriteLine($"Request completed in {requestStopwatch.ElapsedMilliseconds} second.");

        Stopwatch requestStopwatch2 = Stopwatch.StartNew();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Asynchronous request started...");
        Task task1 = Task.Run(() => { Console.WriteLine(FirstMethod()); });
        Task task2 = Task.Run(() => { Console.WriteLine(SecondMethod()); });
        Task task3 = Task.Run(() => { Console.WriteLine(LastMethod()); });
        Task.WaitAll(task1, task2, task3);
        Console.WriteLine($"Request handled in {requestStopwatch2.ElapsedMilliseconds} second.");

        Console.ReadKey();
    }
    public static string FirstMethod()
    {
        Console.WriteLine("First method started...");
        Thread.Sleep(6000);
        Console.WriteLine("Stop First");
        return "I am first task";
    }
    public static string SecondMethod()
    {
        Console.WriteLine("Second method started...");
        Thread.Sleep(6000);
        Console.WriteLine("Stop Second");
        return "I am second task";
    }
    public static string LastMethod()
    {
        Console.WriteLine("Last method started...");
        Thread.Sleep(6000);
        Console.WriteLine("Stop Last");
        return "I am last task";
    }
}