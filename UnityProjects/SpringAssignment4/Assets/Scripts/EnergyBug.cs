/*
 * Liam Barrett
 * EnergyBug.cs
 * Assigment 4
 * An Ingredient that adds 10 stamina to the Potion it's added to
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBug : Ingredient
{
    Potion potion;

    public EnergyBug(Potion potion)
    {
        this.potion = potion;
    }

    public override int getHealthBuff()
    {
        return potion.getHealthBuff();
    }

    public override int getManaBuff()
    {
        return potion.getManaBuff();
    }

    public override int getStamBuff()
    {
        return potion.getStamBuff() + 10;
    }
}
