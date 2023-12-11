namespace dnd;
public class Barbarian: Character
{
    public Barbarian(): base("Tri-Kaki", "Barbarian", "A 7 feet long Aric T’ach with brown and white feathers and polished toe claws",20,20,10,2,10, 1)
    {
        weaponsList.Add(weapon1);
        weaponsList.Add(weapon2);
    }
    Spear weapon1 = new Spear();
    GreatSword weapon2 = new GreatSword();

    
}