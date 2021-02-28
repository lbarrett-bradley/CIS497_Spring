/*
 * Liam Barrett
 * Spring Assignment 2
 * Shoe.cs
 * Abstract class for shoe items that provide different buffs to the player when worn
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shoe : MonoBehaviour
{
    public BuffBehavior buffBehavior;
    public bool isActiveShoe;

    public abstract void setBuffBehavior();
    public void endBuff()
    {
        buffBehavior.debuff();
        isActiveShoe = false;
    }
}
