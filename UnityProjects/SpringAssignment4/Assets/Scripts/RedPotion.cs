/*
 * Liam Barrett
 * RedPotion.cs
 * Assigment 4
 * Subclass of potion that has a high health bonus, but no other bonuses
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPotion : Potion
{
    public RedPotion()
    {
        this.healthBuff = 20;
        this.manaBuff = 0;
        this.staminaBuff = 0;
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
