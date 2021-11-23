using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float offset;
    public GameObject bullet;
    public Transform shotpoint;
    private float timeBTWShots;
    public float startTimeBTWShots;
    private PlayerController player;
    private float rot2;
    private Vector2 difference;
    private void Start()
    {
      /*  player = GameObject.FindGameObjectsWithTag("Player").GetComponent<PlayerController>()*/;
    }
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        if (timeBTWShots <= 0)
        {

            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, shotpoint.position, transform.rotation);
                timeBTWShots = startTimeBTWShots;
            }

        }
        else 
        {
            timeBTWShots -= Time.deltaTime;
        }
    }

    
}
