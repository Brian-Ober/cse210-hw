using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // while loop
        //bool var keepGoing = true;
        var count = 0;
        while (count <5) 
        {
            Console.WriteLine("Still Going");
            ++count;
        }

        // do-while loop

        count =0;
        do 
        {
            Console.WriteLine("hit");
            count++;
        }
        while ( count < 5);

        //for loop

        for (var i =0; i<5; ++i)
        {
            Console.WriteLine($"i = {i}");
        }

        //foreach loop

        var myInts = new int[]{1,20,3,4,5};
        foreach (var i in myInts)
        {
            Console.WriteLine($"i = {i}");
        }



        //Assignment

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);
        var guessNumber = 0;

        do
        {
            Console.Write("Guess the number: ");
            string guessNumberString = Console.ReadLine();
            guessNumber = int.Parse(guessNumberString);
            
            if (guessNumber > randomNumber)
            {
                Console.WriteLine("You guessed too high");
            }
            
            if (guessNumber < randomNumber)
            {
            Console.WriteLine("You guessed too low");
            }

            if (guessNumber == randomNumber)
            {
            Console.WriteLine("You guessed right");
            }
        }
        while (guessNumber != randomNumber);
        
    }
}