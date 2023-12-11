using System;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
namespace dnd;
public class Character
{
    public Character (string name, string playerClass, string playerDescription, int maxHp, int currentHp, int maxAttack, int diplomacy, int money, int numPotions)
    {
        _name = name;
        _playerClass = playerClass;
        _playerDescription = playerDescription;
        _maxHp = maxHp;
        _currentHp = currentHp;
        _maxAttack = maxAttack;
        _diplomacy = diplomacy;
        _money = money;
        _numPotions = numPotions;
    }
    protected string _name;
    protected string _playerClass;
    protected string _playerDescription;
    protected int _maxHp;
    protected int _currentHp;
    protected int _maxAttack;
    protected int _diplomacy;
    protected int _money;

    protected int _attackModifer;

    protected int _numPotions;

    protected List <Weapon> weaponsList = new List<Weapon>();

    public void display()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine($"Class: {_playerClass} ");
        Console.WriteLine($"Description: {_playerDescription} ");
        Console.WriteLine($"HP: {_maxHp} ");
        Console.WriteLine($"Max Attack: {_maxAttack} ");
        Console.WriteLine($"Diplomacy {_diplomacy} ");
        Console.WriteLine($"Money: {_money} Gold Pieces ");
    }

    public (int, int) getHp()
    {return (_currentHp, _maxHp);}


    public void update(int newHP, int newNumPotion, int newMoney, string newWeapon)
    {
        _currentHp = newHP;
        _numPotions = newNumPotion;
        _money = newMoney;

        if (newWeapon == "a Sword" )
        {
            GreatSword newSword = new GreatSword();
            weaponsList.Add(newSword);
        }
        else if (newWeapon == "a Spear")
        {
            Spear newSpear = new Spear();
            weaponsList.Add(newSpear);
        }
        else if (newWeapon == "a Dagger" )
        {
            Dagger newDagger = new Dagger();
            weaponsList.Add(newDagger);
        }
        else if (newWeapon == "a BattleAx" )
        {
            BattleAx newAx = new BattleAx();
            weaponsList.Add(newAx);
        }
    }

    public int getAttack()
    {
        return _maxAttack;
    }

    public virtual int getNumSpells()
    {
        return 0;
    }

    public int getNumPotions()
    {
        return _numPotions;
    }

    public int getDiplomacy()
    {
        return _diplomacy;
    }

    public int getMoney()
    {
        return _money;
    }

    public int chooseWeapon()
    {
        
        int i = 0;
        Console.WriteLine("Choose your weapon");
        foreach(Weapon weapon in weaponsList)
        {
            Console.Write($"{i} ");
            weapon.Display();
            i++;
        }
        Console.WriteLine("If unarmed put 'unarmed'");
        string choice = Console.ReadLine();
        if (choice == "unarmed")
        {
            _attackModifer = 0;
        }
        else
        {
            int index = int.Parse(choice);
            if (index == 0)
            {
                _attackModifer = weaponsList[0].getattackModifer();
            }
            else if (index == 1)
            {
                _attackModifer = weaponsList[1].getattackModifer();
            }
            else if (index == 2)
            {
                _attackModifer = weaponsList[2].getattackModifer();
            }
            else if (index == 3)
            {
                _attackModifer = weaponsList[3].getattackModifer();
            }
            else
            {
                _attackModifer = 0;
            }
        }
        return _attackModifer;
    }
}


