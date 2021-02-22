/*
 * Liam Barrett
 * HealingGrass.cs
 * Assigment 4
 * An Ingredient that adds 10 health to the Potion it's added to
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingGrass : Ingredient
{
    Potion potion;

    public HealingGrass(Potion potion)
    {
        this.potion = potion;
    }

    public override int getHealthBuff()
    {
        return potion.getHealthBuff() + 10;
    }

    public override int getManaBuff()
    {
        return potion.getManaBuff();
    }

    public override int getStamBuff()
    {
        return potion.getStamBuff();
    }
}
