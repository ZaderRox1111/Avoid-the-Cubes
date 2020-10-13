using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject spawner;
    public Transform[] spawnSpots;
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float gameDifficulty;
    public float timeToBeginSpawning;

    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;

    }

    

    void Update()
    {
        if (Time.time >= timeToBeginSpawning)
        {
            gameObject.SetActive(true);
        }

        if (timeBtwSpawns / gameDifficulty <= 0 )
        {
            int randPos = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        } else
        {
            timeBtwSpawns -= Time.deltaTime * gameDifficulty;    
        }

        
    }

    
}
