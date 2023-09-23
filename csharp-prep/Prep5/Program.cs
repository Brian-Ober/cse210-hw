using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        int Add2(int start)
        {
            return start +2;
        }

        Console.WriteLine($"Total from adding = {Add2(4)}");

        static void DisplayString(string value)
        {
            Console.WriteLine(value);
        }

        DisplayString("Hello no return value");

        static int SumItAll(int[] numbers)
        {
            var total = 0;
            foreach (var i in numbers)
            {
                total += i;
            }
            return total;
        }

        var nums = new int[]{1,2,3};
        System.Console.WriteLine($"SumItAll = {SumItAll(nums)}");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string Name = Console.ReadLine();
            return Name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string NumString =Console.ReadLine();
            int Num = int.Parse(NumString);
            return Num;
        }

        static int SquareNumber()
        {
            int number = PromptUserNumber();
            int square = number * number;
            return square;
        }

        static void DisplayResult()
        {
            Console.WriteLine($"{PromptUserName()}, the square of your number is {SquareNumber()}");
        }

        DisplayWelcome();

        DisplayResult();
    }
}