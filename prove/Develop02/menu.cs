using System;
using System.Net.Quic;
using Microsoft.VisualBasic;

public class Menu
{
    public bool quit = false;
    int count =0;
    
    public void menu()
    {
        var journals = new List<Entry>();
        do 
        {
            Console.WriteLine("Pick an option from the menu");
            Console.WriteLine("1 New Entry");
            Console.WriteLine("2 Save");
            Console.WriteLine("3 Display journal");
            Console.WriteLine("4 Load");
            Console.WriteLine("5 Quit");
            string prompt = Console.ReadLine();

            if (prompt =="1" || prompt == "one" || prompt =="One")
            {
                Entry myEntry = new Entry();
                myEntry.NewEntry();
                journals.Add(myEntry);

               
            }

            else if (prompt =="2" || prompt == "two" || prompt =="Two")
            {
                if (File.Exists("journal.csv"))
                {
                    foreach (Entry journal in journals)
                    {
                        journal.Save();
                    }
                }
                else 
                {
                    File.Create("journal.csv");
                    foreach (Entry journal in journals)
                    {
                        journal.Save();
                    }
                }
            }
            else if (prompt == "3" || prompt =="three" || prompt == "Three")
            {
                using(StreamReader file = new StreamReader("journal.csv")) 
                {
                    string ln;
                    while ((ln = file.ReadLine()) != null) 
                    {
                        Console.WriteLine(ln);
                    }
                        file.Close();
                }
            }
            else if (prompt =="4" || prompt =="four" || prompt == "Four")
            {
                foreach (Entry journal in journals)
                {
                    count++;
                }
                while (count  != 0)
                {
                    journals.RemoveAt(count - 1);
                    count --;
                }
            }
            else if (prompt =="5" || prompt == "five" || prompt =="Five")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("That was not a viable option try again");
            }
        }
        while (quit == false);
    }
}