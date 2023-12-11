using System;
namespace dnd;

public class Monster:NPC {
    public Monster(): base("13-foot-long hexapod with long claws on its front legs lies in wait", 5, 20, 0, 0)
    {}

    public override void openingDialogue()
    {
        Console.WriteLine("Roar");
        Console.WriteLine("");
    }
}