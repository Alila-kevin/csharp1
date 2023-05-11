using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your name buddy's");
        string? username = Console.ReadLine();
        Console.WriteLine("You have a nice name "+username+" "+ "welcome to c sharp program");
       
        Console.ReadKey();
    }
}