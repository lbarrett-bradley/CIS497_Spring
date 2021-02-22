/*
 * Liam Barrett
 * ManaShroom.cs
 * Assigment 4
 * An Ingredient that adds 10 mana to the Potion it's added to
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaShroom : Ingredient
{
    Potion potion;

    public ManaShroom(Potion potion)
    {
        this.potion = potion;
    }

    public override int getHealthBuff()
    {
        return potion.getHealthBuff();
    }

    public override int getManaBuff()
    {
        return potion.getManaBuff() + 10;
    }

    public override int getStamBuff()
    {
        return potion.getStamBuff();
    }
}
