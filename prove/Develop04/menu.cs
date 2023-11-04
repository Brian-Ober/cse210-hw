using System;
using System.Xml.Serialization;
public class Menu
{
    public void menu()
    {
        bool quit = false;

        
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                var activity = new Breathing();
                DateTime futureTime = activity.showStartMessage();
                activity.startActivity(futureTime);
                activity.showEndMessage(futureTime);
                break;

                case "2":
                var activity2 = new Reflection();
                DateTime futureTime2 = activity2.showStartMessage();
                activity2.startActivity(futureTime2);
                activity2.showEndMessage(futureTime2);
                break;

                case "3":
                var activity3 = new Listing();
                DateTime futureTime3 = activity3.showStartMessage();
                activity3.startActivity(futureTime3);
                activity3.showEndMessage(futureTime3);
                break;

                case "4":
                quit = true;
                break;
            }
        }
        while(quit == false);
    }
}