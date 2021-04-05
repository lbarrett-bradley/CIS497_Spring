using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Lootable : MonoBehaviour
{
    public void loot()
    {
        //code to trigger animation of chest opening and making sound would go here
        getReward();
    }

    public void OnMouseDown()
    {
        loot();
    }

    public abstract void getReward();
}
