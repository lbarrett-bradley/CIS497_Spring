using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private LootComponent allLoot;
    private LootComponent loot1;
    private LootComponent loot2;
    private LootComponent loot3;
    private LootComponent loot2And3Pool;

    public GameObject loot1Prefab;
    public GameObject loot2Prefab;
    public GameObject loot3Prefab;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;

        loot1 = new Loot(loot1Prefab, gameObject);
        loot2 = new Loot(loot2Prefab, gameObject);
        loot3 = new Loot(loot3Prefab, gameObject);

        loot2And3Pool = new LootPool();
        loot2And3Pool.add(loot2);
        loot2And3Pool.add(loot3);

        allLoot = new LootPool();
        allLoot.add(loot1);
        allLoot.add(loot2And3Pool);
    }

    public void onKill()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        allLoot.spawnLoot();
    }
}
