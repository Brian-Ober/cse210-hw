using System;
using System.Net.Quic;


namespace dnd;
public class Session
{
    int hp;
    int maxHP;
    bool quit = false;
    string answer;
    public void runEncounter(string type)
    {
        Character character;
        if (type =="1")
        {
            character = new Wizard();
            
        }
        if (type == "2")
        {
            character = new Barbarian();
        }
        else{
            character = new Wizard();
        }   

        do {
            (hp, maxHP) = character.getHp();
            int numSpells = character.getNumSpells();
            int diplomacy = character.getDiplomacy();
            int money = character.getMoney();
            var newEnounter = new Encounter();
            int maxAttack = character.getAttack();
            int attackModifer = character.chooseWeapon();
            int numPotions = character.getNumPotions();

            (int newHp, int newNumPotions, money, string newWeapon) = newEnounter.randomEncounter(maxHP, hp, money, diplomacy, numPotions, numSpells, maxAttack, attackModifer);

            character.update(newHp, newNumPotions, money, newWeapon);
            if (newHp > 0)
            {
                Console.WriteLine("Do you want to continue? y/n");
                answer = Console.ReadLine();
            }
            else{
                answer = "n";
            }
            
            if (answer == "n")
            {
                quit = true;
            }
            else 
            {
                quit = false;
            }

        }
        while (hp >= 0 && quit != true);
    }
}