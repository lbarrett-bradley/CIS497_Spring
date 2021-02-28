/*
 * Liam Barrett
 * Spring Assignment 2
 * SpeedUp.cs
 * BuffBehavior that applies 2x speed
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : BuffBehavior
{
    public override void buff()
    {
        player.speed *= 2;
    }

    public override void debuff()
    {
        player.speed /= 2;
    }
}
