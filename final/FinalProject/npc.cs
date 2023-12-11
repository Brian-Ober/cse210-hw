using System;
using System.Dynamic;
namespace dnd;
public class NPC:Encounter {

    public NPC (string description, int maxAttack, int hp, int money, int npcAttackModifier)
    {
        _description = description;
        _maxAttack = maxAttack;
        _hp = hp;
        _money = money;
        _npcAttackModifier = npcAttackModifier;
    }
    protected string _description;
    protected int _maxAttack;
    protected int _hp;
    protected int _money;
    protected int _npcAttackModifier;
    public int Attack(int baseAttack, int attackModifer)
    {
        Random randomGenerator = new Random();
        int attack = randomGenerator.Next(1, baseAttack) + attackModifer;
        return attack;
    }

    public void display()
    {
        Console.WriteLine($"{_description}");
    }

    public virtual void openingDialogue()
    {
        
    }

    public (int, int, int, int) getNPC()
    {
        return(_hp, _maxAttack, _npcAttackModifier, _money);
    }
}