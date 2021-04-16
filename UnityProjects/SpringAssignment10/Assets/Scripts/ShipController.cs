using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public Vector3 laserSpawnPosition;
    ObjectPooler objectPooler;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        laserSpawnPosition = new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            objectPooler.SpawnFromPool("Laser", laserSpawnPosition, transform.rotation);
        }
    }
}
