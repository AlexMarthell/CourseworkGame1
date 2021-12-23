using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] zombies;
    private int rand;
    private int randPos;
    private float timeBtwSpawn;
    public float startTimeBTWSpawn;
    public GameObject spawnEffect;

    private void Start()
    {
        timeBtwSpawn = startTimeBTWSpawn;
        
    }


    private void Update()
    {
        rand = Random.Range(0, zombies.Length);
        randPos = Random.Range(0, spawnPoints.Length);
        if (timeBtwSpawn <= 0)
        {
            Instantiate(zombies[rand], spawnPoints[randPos].transform.position, Quaternion.identity);
            //Instantiate(spawnEffect, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBTWSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime; 
        }
    }
    
}
