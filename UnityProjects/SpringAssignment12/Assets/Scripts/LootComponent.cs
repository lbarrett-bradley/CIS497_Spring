using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LootComponent : MonoBehaviour
{
    public void spawnLoot()
    {
        throw new System.Exception("Invalid Operation for this object");
    }

    public void add(LootPool pool)
    {
        throw new System.Exception("Invalid Operation for this object");
    }

    public void remove(LootPool pool)
    {
        throw new System.Exception("Invalid Operation for this object");
    }

    public LootComponent getChild(int index)
    {
        throw new System.Exception("Invalid Operation for this object");
    }
}
