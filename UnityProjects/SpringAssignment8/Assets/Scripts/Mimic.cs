/*
 * Liam Barrett
 * Mimic.cs
 * Spring Assignment 8
 * Subclass of Lootable that kills the player when interacted with
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimic : Lootable
{
    public GameManager gameManager;
    private bool isOpen;

    public Mimic()
    {
        isOpen = false;
    }

    public override void getReward()
    {
        if (!isOpen)
        {
            isOpen = true;
            gameManager.playerAlive = false;
        }
    }
}
