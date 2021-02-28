/*
 * Liam Barrett
 * Spring Assignment 2
 * Shoe.cs
 * Abstract class for shoe items that provide different buffs to the player when worn.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shoe : MonoBehaviour
{
    public PlayerController player;
    public BuffBehavior buffBehavior;

    public abstract void setShoe();
}
