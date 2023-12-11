using System.Data;

public class Spell {
    public Spell(string name, string condition, int hpModifer, int attack, bool used)
    {
        _name = name;
        _condition = condition;
        _hpModifer = hpModifer;
        _attack = attack;
        _used = used;
    }

    public void updateSpell(bool hasBeenused)
    {
        _used = hasBeenused;
    }
    protected string _name;
    protected string _condition;
    protected int _hpModifer;
    protected int _attack;
    protected bool _used;

    public (string, int, int, bool) spellEffect()
    {
        return(_condition,_hpModifer, _attack, _used);
    }


    public void display()
    {
        Console.WriteLine($"Spell Name: {_name}");
        Console.WriteLine($"Condition: {_condition}");
    }
}