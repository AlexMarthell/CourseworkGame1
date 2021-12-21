using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Zombie1 enemy;
    private Spawner spawner;

    private void Start()
    {
        spawner = FindObjectOfType<Spawner>();
        Instantiate(enemy, transform.position, transform.rotation);
        
    }
}
