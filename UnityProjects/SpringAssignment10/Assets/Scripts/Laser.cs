using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour, PooledObject
{
    public float speed;
    private Rigidbody rb;

    public void OnObjectSpawn()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        //would play shoot sound here
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //IEnumerable shoot()
    //{

    //}
}
