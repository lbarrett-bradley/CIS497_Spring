/*
 * Liam Barrett
 * Spring Assignment 2
 * SpeedShoe.cs
 * Shoe that applies SpeedUp buff
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedShoe : Shoe
{
    public override void setBuffBehavior()
    {
        isActiveShoe = true;
        buffBehavior = new SpeedUp();
        buffBehavior.buff();
    }
}
