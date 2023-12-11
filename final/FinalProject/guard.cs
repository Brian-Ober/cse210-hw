using System;
namespace dnd;

public class Guard:NPC {
    public Guard(): base("A guard weilding a Dane Axe walks up to you", 4, 15, 25, 6)
    {}

    public override void openingDialogue()
    {
        Console.WriteLine("What do we have here, a threat perhaps?");
        Console.WriteLine("");
    }
}