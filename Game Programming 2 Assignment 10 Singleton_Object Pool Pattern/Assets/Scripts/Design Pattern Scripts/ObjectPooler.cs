/*
* (Christopher Green)
* (ObjectPooler.cs)
* (Assignment 10)
* (This script defines what the object pooler is and what it will do.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    // List of Pools
    public List<Pool> pools;

    // Dictionary for the Object Pooler
    public Dictionary<string, Queue<GameObject>> poolDictionary;


    public static ObjectPooler uniqueInstance;

    private void Awake()
    {
        if(uniqueInstance == null)
        {
            uniqueInstance = this;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        FillWithInactiveObjects();
    }

    public void FillWithInactiveObjects()
    {
        foreach(Pool pool in pools)
        {

            Queue<GameObject> objectPool = new Queue<GameObject>();

            for(int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);

                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);

        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 spawnPostion, Quaternion spawnRotation)
    {

        if(poolDictionary.ContainsKey(tag))
        {
            Debug.Log("The key: " + tag + " was found!");
        }
        else if(!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Error: The key: " + tag + " was not found!");
        }

        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);

        objectToSpawn.transform.position = spawnPostion;
        objectToSpawn.transform.rotation = spawnRotation;

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }

}
