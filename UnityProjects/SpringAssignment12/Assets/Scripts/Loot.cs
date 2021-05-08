using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : LootComponent
{
    public GameObject lootPrefab;

    public Loot(GameObject lootPrefab)
    {
        this.lootPrefab = lootPrefab;
    }

    new public void spawnLoot()
    {
        Instantiate(lootPrefab, transform.position, transform.rotation);
    }
}
