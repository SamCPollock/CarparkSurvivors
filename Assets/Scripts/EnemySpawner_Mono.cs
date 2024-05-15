using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner_Mono : MonoBehaviour
{

    public GameObject spawnedObjectPrefab;

    public float spawnDelay = 1; 
    private float _timeSinceLastSpawn; 

    private void Update()
    {
        ///SHOT TIMER
        Timer();
    }

    private void Timer()
    {
        _timeSinceLastSpawn += Time.deltaTime;

        if (_timeSinceLastSpawn >= spawnDelay)
        {
            Spawn();
            _timeSinceLastSpawn = 0;
        }
        
    }

    private void Spawn()
    {
        GameObject spawnedObject = GameObject.Instantiate(spawnedObjectPrefab, transform.position, transform.rotation);
    }
}
