using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!"); 

        //string interpolation
        int myInt =5;
        Console.WriteLine("my int = " + myInt);
        Console.WriteLine($"my int = {myInt}");

        //Readline
        Console.Write("What is your name? ");
        string name =Console.ReadLine();
        Console.WriteLine($"name = {name}");

        //Conditionals
        if (name == "Brian")
        {
            Console.WriteLine("Hey that's me");
        }
        else 
        {
            Console.WriteLine($"Hi there, {name}");

        }

        Console.WriteLine(" ");


        Console.Write("What is your first name? ");
        string fname =Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname =Console.ReadLine();

        Console.WriteLine(" ");

        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}