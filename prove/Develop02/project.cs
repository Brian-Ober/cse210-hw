using System;


public class Entry
{
    public string _entry;
    public string _usedPrompt;
    
    public string Prompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0,4);

        _usedPrompt = prompts[index];

        return _usedPrompt;
    }

   public string NewEntry()
   {
    Console.WriteLine($"{Prompt()}");
    _entry = Console.ReadLine();
    return _entry;
   }

   public void Display()
   {
    
    Console.WriteLine($"{_usedPrompt}, {_entry}");
   }

   public void Save()
   {
    using (StreamWriter outputFile = new StreamWriter("journal.csv"))
    {
        outputFile.WriteLine($"{_usedPrompt}, {_entry}");
    }
   }
}

