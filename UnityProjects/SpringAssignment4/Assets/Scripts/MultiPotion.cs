/*
 * Liam Barrett
 * MultiPotion.cs
 * Assigment 4
 * Subclass of potion that has a balanced bonus in health, mana, and stamina
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPotion : Potion
{
    public MultiPotion()
    {
        this.healthBuff = 5;
        this.manaBuff = 5;
        this.staminaBuff = 5;
    }

    public override int getHealthBuff()
    {
        return this.healthBuff;
    }

    public override int getManaBuff()
    {
        return this.manaBuff;
    }

    public override int getStamBuff()
    {
        return this.staminaBuff;
    }
}
