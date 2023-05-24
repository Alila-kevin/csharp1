using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;
        double result;
//we are the the best
        Console.WriteLine("What is your name ?");
        string? username = Console.ReadLine();
        Console.WriteLine("You have a nice name "+username+" "+ "welcome to c sharp program");
        Console.WriteLine("write the first number");
         num1=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("your first number is: "+num1);
        Console.WriteLine("write the second number"); 
         num2=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Your second number is: "+num2);
         result=num1*num2;
       Console.WriteLine(username+" Your answer is: "+result);
        Console.ReadKey();
    }
}
