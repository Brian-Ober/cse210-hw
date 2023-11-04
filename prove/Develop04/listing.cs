using System;

public class Listing: Activity
{
     public Listing(): base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    private string[] prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private int count = 0;
    public void startActivity(DateTime _futureTime)
    {
        bool continueGoing;
        string prompt = GetRandomString(prompts);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{prompt}---");
        showMessagePause("You may begin in: ", "countDown", 5);
        do
        {
            Console.WriteLine("> ");
            Console.ReadLine();
            count ++;
            continueGoing = keepGoing(_futureTime);
        }
        while (continueGoing == true);
        Console.WriteLine($"You listed {count} items!");
    }
}