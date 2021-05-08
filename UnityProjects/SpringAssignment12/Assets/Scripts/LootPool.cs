using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPool : LootComponent
{
    public List<LootComponent> lootComponents;

    public LootPool()
    {
        lootComponents = new List<LootComponent>();
    }

    public override void add(LootComponent l)
    {
        lootComponents.Add(l);
    }

    public override void remove(LootComponent l)
    {
        lootComponents.Remove(l);
    }

    public override LootComponent getChild(int index)
    {
        return lootComponents[index];
    }

    public override void spawnLoot()
    {
        foreach (LootComponent loot in lootComponents)
        {
            float rand = Random.value;

            if (rand >= .50f)
            {
                loot.spawnLoot();
            }
        }
    }
}
