using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;

    private void Awake()
    {
        int starterNum = 4;
        SpawnStarter(starterNum);
    }

    private void SpawnStarter(int numberOfSpawning)
    {
        for (int index = 0; index < numberOfSpawning; index++)
        {
            int randomInt = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[randomInt], gameObject.transform);
        }
    }
    
    public void Spawn(int numberOfSpawning)
    {
        int oxygenIndex = 0;
        Instantiate(prefabs[oxygenIndex], gameObject.transform);
        
        for (int index = 0; index < numberOfSpawning - 1; index++)
        {
            int randomInt = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[randomInt], gameObject.transform);
        }
    }
    
}
