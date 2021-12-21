using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] variants;
    private float timeBtwSpawn;
    public float startTimeBTWSpawn;
    public float decreaseTime;
    public float minTime;


    public float enemyHealth;
    public float increaseHealth;
    public float enemyDamage;
    public float increaseDamage;

   

   
    void Update()
    {
        enemyHealth += Time.deltaTime * increaseHealth;

        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, variants.Length);
            Instantiate(variants[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBTWSpawn;
            if (startTimeBTWSpawn > minTime)
            {
                startTimeBTWSpawn -= decreaseTime;
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;
            }
        }
    }
}
