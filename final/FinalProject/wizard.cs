using System;
using System.Runtime.CompilerServices;
namespace dnd;
public class Wizard: Character
{
    public Wizard(): base("Benjamin Lomi", "Wizard", "A young human male with a olive complexion in a silk tunic", 15, 15, 4, 10, 50, 3) 
    {
        weaponsList.Add(weapon1);
    }

    private int _numSpells =3;
    Dagger weapon1 = new Dagger();

    public override int getNumSpells()
    {
        return _numSpells;
    }
} 