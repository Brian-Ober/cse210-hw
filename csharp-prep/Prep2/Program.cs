using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");


        Console.WriteLine("What is your grade percentage? ");
        string grade= Console.ReadLine();
        int percent = int.Parse(grade);
        string letter=" ";
        string pass=" ";

        if (percent > 90)
        {
            letter ="A";
        }
        else if (percent > 80)
        {
            letter ="B";
        }
        else if (percent > 70)
        {
            letter ="C";
        }
        else if (percent > 60)
        {
            letter ="D";
        }
        else
        {
            letter="F";
        }

        if (percent > 70)
        {
            pass="Congatulations you passed!";
        }
        else
        {
            pass="Better luck next time.";
        }

        Console.WriteLine($"You got an {letter}");
        Console.Write(pass);
    }
}