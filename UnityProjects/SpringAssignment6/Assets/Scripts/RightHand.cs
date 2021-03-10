/*
 * Liam Barrett
 * RightHand.cs
 * Spring Assignment 6
 * Factory method pattern creator that makes fire blocks
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : Hand
{
    public FireBlock fireBlock;

    void Start()
    {
        fireBlock = GameObject.FindGameObjectWithTag("Fire Block").GetComponent<FireBlock>();
    }

    public override void spawnBlock()
    {
        Instantiate(fireBlock, transform.position, transform.rotation);
    }
}
