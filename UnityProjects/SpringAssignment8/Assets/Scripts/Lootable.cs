/*
 * Liam Barrett
 * Lootable.cs
 * Spring Assignment 8
 * Abstract class of the template method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Lootable : MonoBehaviour
{
    public void loot()
    {
        //code to trigger animation of chest opening and making sound would go here
        getReward();
    }

    public void OnMouseDown()
    {
        loot();
    }

    public abstract void getReward();
}
