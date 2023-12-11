using System;
namespace dnd;

public class Merchant:NPC
{
    public Merchant(): base("A merchant is walking down the road towards you", 0, 15, 100, 0)
    {}

    public override void openingDialogue()
    {
        Console.WriteLine("Hello Adventurer would you like to sample my wares?");
        Console.WriteLine("");
    }

}