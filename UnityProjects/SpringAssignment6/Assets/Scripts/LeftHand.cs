/*
 * Liam Barrett
 * LeftHand.cs
 * Spring Assignment 6
 * Factory method pattern creator that makes ice blocks
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : Hand
{
    public IceBlock iceBlock;

    void Start()
    {
        iceBlock = GameObject.FindGameObjectWithTag("Ice Block").GetComponent<IceBlock>();
    }

    public override void spawnBlock()
    {
        Instantiate(iceBlock, transform.position, transform.rotation);
    }
}
