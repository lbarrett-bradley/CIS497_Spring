using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPool : LootComponent
{
    public List<LootComponent> lootComponents;

    public void add(LootComponent l)
    {
        lootComponents.Add(l);
    }

    public void remove(LootComponent l)
    {
        lootComponents.Remove(l);
    }

    new public LootComponent getChild(int index)
    {
        return lootComponents[index];
    }

    new public void spawnLoot()
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
