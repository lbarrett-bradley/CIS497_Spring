using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : LootComponent
{
    public GameObject lootPrefab;
    public GameObject enemyToSpawnAt;

    public Loot(GameObject lootPrefab, GameObject enemyToSpawnAt)
    {
        this.lootPrefab = lootPrefab;
        this.enemyToSpawnAt = enemyToSpawnAt;
    }

    public override void spawnLoot()
    {
        GameObject.Instantiate(lootPrefab, enemyToSpawnAt.transform.position + new Vector3(Random.Range(-1.5f, 1.5f), 0f, 0f), enemyToSpawnAt.transform.rotation);
    }
}
