using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Height Calculator!");
            Console.ResetColor();
            Console.Write("Enter weight(lb): ");
            string? weight = Console.ReadLine();
            Console.Write("Enter Height(cm): ");
            string? height = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("[    ] Searching database...");
            Thread.Sleep(5000);
            Console.WriteLine("[|   ] Looking on google...");
            Thread.Sleep(5000);
            Console.WriteLine("[||  ] Asking ChatGPT...");
            Thread.Sleep(5000);
            Console.WriteLine("[||| ] Searching libraries...");
            Thread.Sleep(5000);
            Console.WriteLine("[||||] Finding the meaning of life...");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your height is: {height}");
            Console.ResetColor();
        }
    }
}