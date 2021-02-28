/*
 * Liam Barrett
 * Spring Assignment 2
 * JumpHeightUp.cs
 * BuffBehavior that applies 2x jump height
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHeightUp : BuffBehavior
{
    public override void buff()
    {
        player.jumpForce *= 2;
    }

    public override void debuff()
    {
        player.jumpForce /= 2;
    }
}
