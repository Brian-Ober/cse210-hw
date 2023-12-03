using System;
using Microsoft.VisualBasic;

public class Menu
{
    public void runMenu()
    {
        string type = "normal";
        var goals = new List<Goal>();
         
        bool quit = false;

        

        do
        {

            var normalGoal=new Normal();

            Console.WriteLine($"You have points.");
            Console.WriteLine("");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice =="1")
            {
                normalGoal = new Normal();
                normalGoal.NewGoal();
                goals.Add(normalGoal);
            }

            else if (choice =="2")
            {
                foreach (Goal goal in goals)
                {   
                    
                    
                    goal.display();
                   
            
                }
            }

            
            else if (choice =="6")
            {
                quit = true;
            }
        
        }
        while (quit == false);
    }

       
    
}