using System.Runtime.InteropServices;
using System.Transactions;
using System.Xml.Schema;
using System.Xml.Serialization;
using dnd;

public class Encounter
{   
    private int totalDamage;
    private int totalAttack;
    
    private int _numPotions;
    protected string _newWeapon;
    

    
    

    public (int, int, int, string) randomEncounter(int maxHP, int currentHp, int money, int diplomacy, int numPotions, int numSpells, int baseAttack, int attackModifer)
    {
        List<Spell> spellList = new List<Spell>();
        Console.WriteLine($"Num Potions: {numPotions}");
        Console.WriteLine($"Num Spells: {numSpells}");
        if (numSpells > 0)
        {
            List<Spell> spellDescriptions = new List<Spell>();
            Healing heal = new Healing();
            Fire fire = new Fire();
            Ice ice = new Ice();
            spellDescriptions.Add(heal);
            spellDescriptions.Add(fire);
            spellDescriptions.Add(ice);
            int i = 0;
            
            Console.WriteLine("Choose your spells");
            
            while (i < numSpells)
            {
                Spell newSpell;
                Console.WriteLine("Choose a spell");
                foreach (Spell spell in spellDescriptions)
                {
                    spell.display();
                }
                string spellChoice = Console.ReadLine();
                if (spellChoice == "Healing")
                {
                    newSpell = new Healing();
                    spellList.Add(newSpell);
                }
                else if (spellChoice == "Fire")
                {
                    newSpell = new Fire();
                    spellList.Add(newSpell);
                }
                else if (spellChoice == "Ice")
                {
                    newSpell = new Ice();
                    spellList.Add(newSpell);
                }
                else
                {
                    newSpell = new Healing();
                    spellList.Add(newSpell);
                }
                i++;
            }
        }

        Random randomGenerator = new Random();
        int encounterNum = randomGenerator.Next(1,8);
        
        
        

        if (encounterNum == 1 | encounterNum == 2)
        {
            Treasure newTreasure = new Treasure();
            newTreasure.display();
            int newMoney = newTreasure.getMoney();
            money += newMoney;
            _newWeapon = newTreasure.getWeapon();
            int newPotions = newTreasure.getNumPotions();
            Console.WriteLine($"You have found {newMoney} Gold, {newPotions} Potions, and {_newWeapon}");
            numPotions += newPotions;
            
        }
        else if (encounterNum == 3 | encounterNum == 4 | encounterNum == 5 | encounterNum == 6 | encounterNum == 7 | encounterNum == 8)
        {
            NPC npc;

            if (encounterNum == 3)
            {
                npc = new Merchant();
                npc.display();
                npc.openingDialogue();
                Treasure newTreasure = new Treasure();
                string weaponSell = newTreasure.getWeapon();
                if (weaponSell == "No weapons")
                {
                    weaponSell = "a Dagger";
                }
                int potions = 5;
                int total;
                Console.WriteLine("");
                Console.WriteLine($"{potions} Healing Potions for 5 gold each");
                Console.WriteLine($"{weaponSell} for 10 gold");
                Console.WriteLine("");
                Console.WriteLine("Buy Healing Potions: 0, 1, 2 ,3 ...");
                string potionBuyString = Console.ReadLine();
                int potionBuy = int.Parse(potionBuyString);
                total = potionBuy * 10;
                if (potionBuy > potions | total > money)
                {
                    Console.WriteLine("Transaction invalid");
                    total = 0;
                    potionBuy = 0;
                }

                Console.WriteLine($"Buy {weaponSell} y/n");
                string buyWeapon = Console.ReadLine();
                if (buyWeapon == "n")
                {
                    total += 0;
                    _newWeapon = " ";
                }
                else if (buyWeapon == "y" && 10 > money)
                {
                   Console.WriteLine("Transaction invalid"); 
                   total += 0;
                   _newWeapon = " ";
                }
                else if (buyWeapon == "y" && 10 <= money)
                {
                   total += 10;
                   _newWeapon = weaponSell;
                }
                else{
                    total += 0;
                    _newWeapon = " ";
                }

                Console.WriteLine("");
                Console.WriteLine("Thank You for shopping");
                money -= total;
                numPotions += potionBuy;
            }
            else if (encounterNum == 4 |encounterNum == 5)
            {
                npc = new Guard();
                npc.display();
                npc.openingDialogue();
                if (diplomacy >= 5)
                {
                    Console.WriteLine("No my good sir I am but a simple adventurer out to protect these lands.");
                    Console.WriteLine("");
                    Console.WriteLine("Well be on your way then");
                    _newWeapon = " ";
                }
                else 
                {
                    (int npcHP, int npcBaseAttack, int npcAttackModifier, int npcMoney) = npc.getNPC();
                    string condition = "none";
                    Console.WriteLine("I am but a simpl...");
                    Console.WriteLine("");
                    Console.WriteLine("Silence criminal scum, I will be doing this country a favor by slaying you");
                    do
                    {
                        int enemyAttack = npc.Attack(npcBaseAttack, npcAttackModifier);
                        if (condition != "Freeze")
                        {
                            Console.WriteLine($"Have at thee: -{enemyAttack} HP");
                            currentHp -= enemyAttack;
                        }
                        else 
                        {
                            Console.WriteLine("Your enemy is frozen");
                            condition = "none";
                        }
                        
                        
                        Console.WriteLine("");
                        Console.WriteLine($"Current HP: {currentHp}");
                        Console.WriteLine($"num potions: {numPotions}");
                        Console.WriteLine("");
                        Console.WriteLine("1. attack");
                        if (numSpells >= 1 | numPotions >= 1)
                        {
                            if (numSpells >= 1 && numPotions < 1)
                            {
                                Console.WriteLine("2. Use Spell");
                                string choice = Console.ReadLine();
                                if (choice == "2")
                                {
                                    int index = 0;
                                    int healing;
                                    int attack;
                                    bool used;
                                    Console.WriteLine("");
                                    Console.WriteLine("Choose your spell ");
                                    foreach (Spell prepedSpell in spellList)
                                    {
                                        
                                        (condition, healing,  attack, used) = prepedSpell.spellEffect();
                                        Console.WriteLine($"{index}. ");
                                        prepedSpell.display();
                                        
                                        Console.Write($"{used}");
                                        
                                    }
                                    string spellChoiceString = Console.ReadLine();
                                    int spellChoice = int.Parse(spellChoiceString);
                                    (condition, healing, attack,  used) = spellList[spellChoice].spellEffect();
                                    if (used == false)
                                    {
                                        Console.WriteLine($"A {condition} appears, you are healed by {healing} HP, your enemy is damage by {attack} HP");
                                        currentHp += healing;
                                        npcHP -= attack;
                                        used = true;
                                        spellList[spellChoice].updateSpell(used);
                                    }
                                    else 
                                    {
                                        Console.WriteLine("You have already used that spell");
                                    }
                                    
                                }
                                else
                                {
                                    int damageDealt = npc.Attack(baseAttack, attackModifer);
                                    Console.WriteLine($"Take that: {damageDealt}");
                                    npcHP -= damageDealt;
                                }
                            }
                            else if (numSpells < 1 && numPotions >= 1)
                            {
                                Console.WriteLine("2. Use Potion");
                                string choice = Console.ReadLine();
                                if (choice == "2")
                                {
                                    HealthPotion potion = new HealthPotion();
                                    int healing = potion.getHealing();
                                    numPotions -= 1;
                                    currentHp += healing;
                                }
                                else
                                {
                                    int damageDealt = npc.Attack(baseAttack, attackModifer);
                                    Console.WriteLine($"Take that: {damageDealt}");
                                    npcHP -= damageDealt;
                                }
                            }
                            else
                            {
                                Console.WriteLine("2. Use Spell");
                                Console.WriteLine("3. Use Potion");
                                string choice = Console.ReadLine();
                                if (choice == "2")
                                {
                                    int index = 0;
                                    int healing;
                                    int attack;
                                    bool used;
                                    Console.WriteLine("");
                                    Console.WriteLine("Choose your spell ");
                                    foreach (Spell prepedSpell in spellList)
                                    {
                                        
                                        (condition, healing,  attack, used) = prepedSpell.spellEffect();
                                        Console.WriteLine($"{index}. ");
                                        prepedSpell.display();
                                        
                                        Console.Write($"{used}");
                                        
                                    }
                                    string spellChoiceString = Console.ReadLine();
                                    int spellChoice = int.Parse(spellChoiceString);
                                    (condition, healing, attack,  used) = spellList[spellChoice].spellEffect();
                                    if (used == false)
                                    {
                                        Console.WriteLine($"A {condition} appears, you are healed by {healing} HP, your enemy is damage by {attack} HP");
                                        currentHp += healing;
                                        npcHP -= attack;
                                        used = true;
                                        spellList[spellChoice].updateSpell(used);
                                    }
                                    else 
                                    {
                                        Console.WriteLine("You have already used that spell");
                                    }
                                }
                                else if (choice == "3")
                                {
                                    HealthPotion potion = new HealthPotion();
                                    int healing = potion.getHealing();
                                    numPotions -= 1;
                                    currentHp += healing;
                                }
                                else
                                {
                                    int damageDealt = npc.Attack(baseAttack, attackModifer);
                                    Console.WriteLine($"Take that: {damageDealt}");
                                    npcHP -= damageDealt;
                                }
                            }

                        }
                        else{
                            int damageDealt = npc.Attack(baseAttack, attackModifer);
                            Console.WriteLine($"Take that: {damageDealt}");
                            npcHP -= damageDealt;
                        }
                        if (condition == "Burn")
                        {
                            npcHP -= 2;
                            Console.WriteLine("Your enemy was burnt: -2HP");
                            condition = "none";
                        }
                    }
                    while (currentHp > 0 && npcHP > 0);
                    if (currentHp <= 0)
                    {
                        Console.WriteLine("Game Over");
                    }
                    if (currentHp > 0 && npcHP < 0)
                    {
                        money += npcMoney;
                        Console.WriteLine($"Money Gained: {npcMoney}");
                    }
                    _newWeapon = " ";
                }
            }
            else if (encounterNum == 6 |encounterNum == 7 |encounterNum == 8)
            {
                npc = new Monster();
                npc.display();
                npc.openingDialogue();
                string condition = "none";
                (int npcHP, int npcBaseAttack, int npcAttackModifier, int npcMoney) = npc.getNPC();
                do
                    {
                        int enemyAttack = npc.Attack(npcBaseAttack, npcAttackModifier);
                        if (condition != "Freeze")
                        {
                            Console.WriteLine($"Roar: -{enemyAttack} HP");
                            currentHp -= enemyAttack;
                        }
                        else 
                        {
                            Console.WriteLine("Your enemy is frozen");
                            condition = "none";
                        }
                        
                        
                        Console.WriteLine("");
                        Console.WriteLine($"Current HP: {currentHp}");
                        Console.WriteLine($"num potions: {numPotions}");
                        Console.WriteLine("");
                        Console.WriteLine("1. attack");
                        
                        if (numSpells >= 1 | numPotions >= 1)
                        {
                            if (numSpells >= 1 && numPotions < 1)
                            {
                                Console.WriteLine("2. Use Spell");
                                string choice = Console.ReadLine();
                                if (choice == "2")
                                {
                                    int index = 0;
                                    int healing;
                                    int attack;
                                    bool used;
                                    Console.WriteLine("");
                                    Console.WriteLine("Choose your spell ");
                                    foreach (Spell prepedSpell in spellList)
                                    {
                                        
                                        (condition, healing,  attack, used) = prepedSpell.spellEffect();
                                        Console.WriteLine($"{index}. ");
                                        prepedSpell.display();
                                        index ++;
                                        Console.Write($"{used}");
                                        Console.WriteLine("");
                                        
                                    }
                                    string spellChoiceString = Console.ReadLine();
                                    int spellChoice = int.Parse(spellChoiceString);
                                    (condition, healing, attack,  used) = spellList[spellChoice].spellEffect();
                                    if (used == false)
                                    {
                                        Console.WriteLine($"A {condition} appears, you are healed by {healing} HP, your enemy is damaged by {attack} HP");
                                        currentHp += healing;
                                        npcHP -= attack;
                                        used = true;
                                        spellList[spellChoice].updateSpell(used);
                                    }
                                    else 
                                    {
                                        Console.WriteLine("You have already used that spell");
                                    }
                                    
                                }
                                else
                                {
                                    int damageDealt = npc.Attack(baseAttack, attackModifer);
                                    Console.WriteLine($"Take that: {damageDealt}");
                                    npcHP -= damageDealt;
                                }
                            }
                            else if (numSpells < 1 && numPotions >= 1)
                            {
                                Console.WriteLine("2. Use Potion");
                                string choice = Console.ReadLine();
                                if (choice == "2")
                                {
                                    HealthPotion potion = new HealthPotion();
                                    int healing = potion.getHealing();
                                    currentHp += healing;
                                    numPotions -= 1;
                                }
                                else
                                {
                                    int damageDealt = npc.Attack(baseAttack, attackModifer);
                                    Console.WriteLine($"Take that: {damageDealt}");
                                    npcHP -= damageDealt;
                                }
                            }
                            else
                            {
                                Console.WriteLine("2. Use Spell");
                                Console.WriteLine("3. Use Potion");
                                string choice = Console.ReadLine();
                                if (choice == "2")
                                {
                                    int index = 0;
                                    int healing;
                                    int attack;
                                    bool used;
                                    Console.WriteLine("");
                                    Console.WriteLine("Choose your spell ");
                                    foreach (Spell prepedSpell in spellList)
                                    {
                                        
                                        (condition, healing,  attack, used) = prepedSpell.spellEffect();
                                        Console.WriteLine($"{index}. ");
                                        prepedSpell.display();
                                        index ++;
                                        Console.Write($"{used}");
                                        Console.WriteLine("");
                                        
                                    }
                                    string spellChoiceString = Console.ReadLine();
                                    int spellChoice = int.Parse(spellChoiceString);
                                    (condition, healing, attack,  used) = spellList[spellChoice].spellEffect();
                                    if (used == false)
                                    {
                                        Console.WriteLine($"A {condition} appears, you are healed by {healing} HP, your enemy is damaged by {attack} HP");
                                        currentHp += healing;
                                        npcHP -= attack;
                                        used = true;
                                        spellList[spellChoice].updateSpell(used);
                                    }
                                    else 
                                    {
                                        Console.WriteLine("You have already used that spell");
                                    }
                                }
                                else if (choice == "3")
                                {
                                    HealthPotion potion = new HealthPotion();
                                    int healing = potion.getHealing();
                                    numPotions -= 1;
                                    currentHp += healing;
                                }
                                else
                                {
                                    int damageDealt = npc.Attack(baseAttack, attackModifer);
                                    Console.WriteLine($"Take that: {damageDealt}");
                                    npcHP -= damageDealt;
                                }
                            }

                        }
                        else{
                            int damageDealt = npc.Attack(baseAttack, attackModifer);
                            Console.WriteLine($"Take that: {damageDealt}");
                            npcHP -= damageDealt;
                        }
                        if (condition == "Burn")
                        {
                            npcHP -= 2;
                            Console.WriteLine("Your enemy was burnt: -2HP");
                            condition = "none";
                        }
                    }
                    while (currentHp > 0 && npcHP > 0);
                    if (currentHp <= 0)
                    {
                        Console.WriteLine("Game Over");
                    }
                    if (currentHp > 0 && npcHP < 0)
                    {
                        money += npcMoney;
                        Console.WriteLine($"Money Gained: {npcMoney}");
                    }
                    _newWeapon = " ";
            }
            
            

            
        }

        return(currentHp, numPotions, money, _newWeapon);
    }
}