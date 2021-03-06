﻿/*
 * Liam Barrett
 * Chest.cs
 * Spring Assignment 8
 * Subclass of Lootable that gives players money when interacted with
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Lootable
{
    public GameManager gameManager;
    private bool isOpen;

    public Chest()
    {
        isOpen = false;
    }

    public override void getReward()
    {
        if (!isOpen)
        {
            isOpen = true;
            gameManager.gold += 100;
            gameManager.tutorialText.text = "You got 100 Gold!";
        }
    }
}
