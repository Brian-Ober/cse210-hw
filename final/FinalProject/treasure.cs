public class Treasure:Encounter {
    
    protected string _weapon;

    public int getMoney()
    {
        Random randomGenerator = new Random();
        int randomMoney = randomGenerator.Next(1,50);
        return randomMoney;
    }

    public string getWeapon()
    {
        Random randomGenerator = new Random();
        int weaponType = randomGenerator.Next(1,5);
        if (weaponType == 1)
        {
            _weapon = "a Sword";
        }
        else if (weaponType == 2)
        {
            _weapon = "a Spear";
        }
        else if (weaponType == 3)
        {
            _weapon = "a Dagger";
        }
        else if (weaponType == 4)
        {
            _weapon = "a BattleAx";
        }
        else if (weaponType == 5)
        {
            _weapon = "No weapons";
        }
        return _weapon;
    }

    public int getNumPotions()
    {
        Random randomGenerator = new Random();
        int newPotions = randomGenerator.Next(0,2);
        return newPotions;
    }

    public void display()
    {
        Console.WriteLine("You come across a treasure chest");
    }
}