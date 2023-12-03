using System;
using System.Text;

public class Normal: Goal
{
   
     public override void NewGoal()
    {
        
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal");
        string pointsSring = Console.ReadLine();

        _assignedPoints = int.Parse(pointsSring);
        
    }

    public override void Completed()
    {
        throw new NotImplementedException();
    }

    public override void display()
    {
        Console.WriteLine($"{_name}, {_description}, {_assignedPoints}");
        
    }
}