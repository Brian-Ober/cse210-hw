using System;
namespace dnd;

public class Weapon:Items {
    public Weapon( string name, int attackModifer)
    {
        
        _name = name;
        _attackModifer = attackModifer;
    }
    
    protected string _name;
    protected int _attackModifer;

    public void Display()
    {
        Console.WriteLine($"{_name}, attack modifer: {_attackModifer}");
    }

    public int getattackModifer()
    {
        return _attackModifer;
    }

    public string getName()
    {
        return _name;
    }
}