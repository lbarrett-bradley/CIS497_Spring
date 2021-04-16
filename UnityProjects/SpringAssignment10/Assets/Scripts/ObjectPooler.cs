using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    #region Singleton code
    public static ObjectPooler instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a second" +
                "instance of singleton Object Pooler");
        }
    }
    #endregion

    public void FillPoolsWithInactiveObjects()
    {

    }

    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        return null;
    }

    public void ReturnObjectToPool(string tag, GameObject objectToReturn)
    {

    }
}
