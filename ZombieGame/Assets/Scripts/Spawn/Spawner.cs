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
            Instantiate(spawnEffect, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBTWSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime; 
        }
    }
    //public GameObject[] variants;
    //private float timeBtwSpawn;
    //public float startTimeBTWSpawn;
    //public float decreaseTime;
    //public float minTime;

    //public float enemyHealth;
    //public float increaseHealth;
    //public float enemyDamage;
    //public float increaseDamage;

    //void Update()
    //{
    //    enemyHealth += Time.deltaTime * increaseHealth;

    //    if (timeBtwSpawn <= 0)
    //    {
    //        int rand = Random.Range(0, variants.Length);
    //        Instantiate(variants[rand], transform.position, Quaternion.identity);
    //        timeBtwSpawn = startTimeBTWSpawn;
    //        if (startTimeBTWSpawn > minTime)
    //        {
    //            startTimeBTWSpawn -= decreaseTime;
    //        }
    //        else
    //        {
    //            timeBtwSpawn -= Time.deltaTime;
    //        }
    //    }
    //}
}
