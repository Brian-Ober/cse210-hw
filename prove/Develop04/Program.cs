using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Welcome to the Mindfulness Program");
        Console.WriteLine("");
        Thread.Sleep(1000);

        var newMenu = new Menu();
        newMenu.menu();
    }
}