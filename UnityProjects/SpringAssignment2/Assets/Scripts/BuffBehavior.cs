/*
 * Liam Barrett
 * Spring Assignment 2
 * BuffBehavior.cs
 * Interface for buffs that different shoes provide
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BuffBehavior : MonoBehaviour
{
    public PlayerController player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    public abstract void buff();
    public abstract void debuff();
}
