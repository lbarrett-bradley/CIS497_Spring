using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    LootComponent lootDrop;

    public Boss(LootComponent lootDrop)
    {
        this.lootDrop = lootDrop;
    }

    public void onKill()
    {
        lootDrop.spawnLoot();
    }
}
