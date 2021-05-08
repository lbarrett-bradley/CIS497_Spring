using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LootComponent
{
    public virtual void spawnLoot()
    {
        throw new System.Exception("Invalid Operation for this object");
    }

    public virtual void add(LootComponent lootComponent)
    {
        throw new System.Exception("Invalid Operation for this object");
    }

    public virtual void remove(LootComponent lootComponent)
    {
        throw new System.Exception("Invalid Operation for this object");
    }

    public virtual LootComponent getChild(int index)
    {
        throw new System.Exception("Invalid Operation for this object");
    }
}
