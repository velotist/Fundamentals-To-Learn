using System;
using System.Threading;

internal class ThreadTest
{
    private static void Main()
    {
        Thread thread = new Thread(WriteY);
        thread.Start();
        Thread.CurrentThread.Name = "mainThread";
        Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine(Thread.CurrentThread.IsAlive);
        using System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"P:\Thread.txt", true);
        for (int i = 0; i < 1000; i++)
        {
            file.WriteLine("x");
        }
    }

    private static void WriteY()
    {
        Thread.CurrentThread.Name = "writeYThread";
        Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine(Thread.CurrentThread.IsAlive);
        using System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"P:\ThreadY.txt", true);
        for (int i = 0; i < 1000; i++)
        {
            file.WriteLine("y");
        }
    }
}