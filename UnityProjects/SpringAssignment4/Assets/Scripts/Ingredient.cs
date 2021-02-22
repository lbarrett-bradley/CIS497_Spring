/*
 * Liam Barrett
 * Ingredient.cs
 * Assigment 4
 * Subclass of potion that serves as the parent of ingredients that can be added to a potion
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ingredient : Potion
{
    public abstract override int getHealthBuff();
    public abstract override int getManaBuff();
    public abstract override int getStamBuff();
}
