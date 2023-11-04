using System;

public class Reflection: Activity
{
    public Reflection(): base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }
    string[] prompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    string[] questions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public void startActivity(DateTime _futureTime)
    {
        bool continueGoing;
        Console.WriteLine("Consider the following prompt:");
        string prompt = GetRandomString(prompts);
        Console.WriteLine("");
        Console.WriteLine($"{prompt}");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

        showMessagePause("You may begin in: ", "countDown", 5);

        Console.Clear();
        do
        {
            string question = GetRandomString(questions);
            
            showMessagePause($"> {question} ", "spinner", 2);
            
            continueGoing = keepGoing(_futureTime);
        }
        while(continueGoing == true);
    }
}