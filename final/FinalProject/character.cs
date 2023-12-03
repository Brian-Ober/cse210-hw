using System;
namespace dnd;
public class Character
{
    public Character (string name, string playerClass, string playerDescription, int maxHp, int currentHp, int maxAttack, int diplomacy, int money)
    {
        _name = name;
        _playerClass = playerClass;
        _playerDescription = playerDescription;
        _maxHp = maxHp;
        _currentHp = currentHp;
        _maxAttack = maxAttack;
        _diplomacy = diplomacy;
        _money = money;
    }
    protected string _name;
    protected string _playerClass;
    protected string _playerDescription;
    protected int _maxHp;
    protected int _currentHp;
    protected int _maxAttack;
    protected int _diplomacy;
    protected int _money;

    public void display()
    {
        Console.WriteLine($"{_name} ");
        Console.WriteLine($"{_playerClass} ");
        Console.WriteLine($"{_playerDescription} ");
    }
}


