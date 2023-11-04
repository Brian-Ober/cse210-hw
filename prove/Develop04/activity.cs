using System;
using System.ComponentModel.DataAnnotations;

public class Activity 
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _startTime = DateTime.Now;
        

    }
    private DateTime _startTime;
    private DateTime _futureTime;

    public DateTime showStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(" ");
        Console.WriteLine($"{_description}");
        Console.WriteLine(" ");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string _durationString = Console.ReadLine();
        _duration = int.Parse(_durationString);

        Console.Clear();

        Console.WriteLine("Get ready... ");
        showAnimation("spinner", 2);
        Console.WriteLine(" ");
        _futureTime = _startTime.AddSeconds(_duration);
        return _futureTime;
    }

    public void showEndMessage(DateTime _futureTime)
    {
        Console.WriteLine("Well done!! ");

        Console.WriteLine("");

        TimeSpan _duration = _futureTime - _startTime;

        Console.WriteLine($"You have completed another {_duration} seconds of the {_description}.");
        showAnimation("spinner", 2);
        Console.Clear();
    }

    protected void showMessagePause(string message, string animationType, int interval)
    {
        Console.Write($"{message}");
        showAnimation(animationType, interval);
        Console.WriteLine("");

    }

    protected bool keepGoing(DateTime _futureTime)
    {
        DateTime currentTime = DateTime.Now;
        bool keepGoing = true;
        if (currentTime < _futureTime)
        {
            keepGoing = true;
        }
        else
        {
            keepGoing = false;
        }
        return keepGoing;
    }

    private void showAnimation(string animationType, int interval)
    {
        if (animationType =="countDown")
        {
            do
            {
                Console.Write($"{interval}");
                Thread.Sleep(1000);
                interval --;
                Console.Write("\b \b");
            }
            while (interval > 0);
        }

        if (animationType =="spinner")
        {
            do
            {
                Console.Write($"-");
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("|");
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(100);
                Console.Write("\b \b");
                 Console.Write($"-");
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("|");
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(100);
                Console.Write("\b \b");
                interval --;
            }
            while (interval > 0);
        }
    }

    protected string GetRandomString(string[] strings)
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, strings.Length);
        string selectedString = strings[index];
        return selectedString;
    }
}