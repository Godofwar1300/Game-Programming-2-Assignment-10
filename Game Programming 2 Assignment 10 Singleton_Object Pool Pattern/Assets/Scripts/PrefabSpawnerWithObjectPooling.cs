/*
* (Christopher Green)
* (PrefabSpawnerWithObjectPooling.cs)
* (Assignment 10)
* (This script defines where the object will be spawned.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawnerWithObjectPooling : MonoBehaviour
{

    ObjectPooler objectPooler;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.uniqueInstance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int spawnPositionX = Random.Range(80, 400);
        //int spawnPositionY = Random.Range(80, 400);
        int spawnPositionZ = Random.Range(80, 400);

        Vector3 randomSpawnPosition = new Vector3(spawnPositionX, transform.position.y, spawnPositionZ);

        objectPooler.SpawnFromPool("Rain Drop", randomSpawnPosition, Quaternion.identity);
    }
}
