/*
 * Liam Barrett
 * Potion.cs
 * Assigment 4
 * Base class for the potion object
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Potion
{
    public int healthBuff = 0;
    public int manaBuff = 0;
    public int staminaBuff = 0;

    public abstract int getHealthBuff();

    public abstract int getManaBuff();

    public abstract int getStamBuff();
}
