using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //primitive types
       // int i;
        string s;
        char c;
        float f;
        double d;
        byte b;

        //lists - new kewword

        List<int> myInts = new List<int>();
        myInts.Add(2);
        myInts.Add(55);
        myInts.Remove(1);
        myInts.Insert(1, 57);

        var myStrings = new List<string>();
        myStrings.Add("Hello World");

        //Iterate over items

        foreach (var i in myInts)
        {
            Console.WriteLine($"i = {i}");
        }
        
        int count =0;
        int sum=0;
        int Num =1;
        int LNum =1;
        List<int> Numbers =new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.WriteLine("Enter number ");
            string NumString=Console.ReadLine();
            Num = int.Parse(NumString);
            Numbers.Add(Num);
            count++;
        }
        while(Num != 0);

        int countF = count--;

        float Ave = (((float)sum) / (float)countF);

        foreach (var i in Numbers)
        {
            sum +=i;
            if (i > LNum)
            {
                LNum = i;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {Ave}");
        Console.WriteLine($"The largest number is: {LNum}");
    }
}