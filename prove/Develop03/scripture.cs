using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Scripture
{
    Word test = new Word();
    Reference test2 = new Reference();
    private string prompt;

    public void Run()
    {
        string _verse = test2.GetVerse();
        string _refernce = test2.GetReference();
        do 
        {
            Console. Clear();
            Console.Write($"{_refernce} ");
            string[] verse = test.ModifiedVerse(_verse);
            foreach (var word in verse)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Do you want to go again");
            prompt = Console.ReadLine();
            }
        while (prompt != "quit");
    }

}