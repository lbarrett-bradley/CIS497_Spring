/*
 * Liam Barrett
 * Spring Assignment 2
 * JumpShoe.cs
 * Shoe that applies JumpHeightUp buff
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpShoe : Shoe
{
    public override void setBuffBehavior()
    {
        isActiveShoe = true;
        buffBehavior = new JumpHeightUp();
        buffBehavior.buff();
    }
}
