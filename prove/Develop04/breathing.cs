using System;

public class Breathing: Activity
{
    public Breathing(): base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void startActivity(DateTime _futureTime)
    {
        bool continueGoing;
        do 
        {
            showMessagePause("Breathe in...", "countDown", 5);
            
            showMessagePause("Breathe out...", "countDown", 5);

            Console.WriteLine(" ");

            continueGoing = keepGoing(_futureTime);
        }
        while(continueGoing == true);
        
    }
}