using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LootComponent loot1;
    public LootComponent loot2;
    public LootComponent loot3;
    public LootComponent loot2And3Pool;

    public GameObject loot1Prefab;
    public GameObject loot2Prefab;
    public GameObject loot3Prefab;

    // Start is called before the first frame update
    void Start()
    {
        loot1 = new Loot(loot1Prefab);
        loot2 = new Loot(loot2Prefab);
        loot3 = new Loot(loot3Prefab);

        loot2And3Pool = new LootPool();

        loot2And3Pool.add(loot2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
