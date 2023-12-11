using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
namespace dnd;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        
        var newWizard = new Wizard();
        var newBarbarian = new Barbarian();
        

        Console.WriteLine("Choose Your Character ");
        Console.WriteLine("1");
        newWizard.display();
        Console.WriteLine();
        Console.WriteLine("2");
        newBarbarian.display();

        string choice = Console.ReadLine();

        var newSession = new Session();

        newSession.runEncounter(choice);
        
    }
}