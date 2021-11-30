using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Joystick joystick;
    public float offset;
    public GameObject bullet;
    public Transform shotpoint;
    private float timeBTWShots;
    public float startTimeBTWShots;
    public GunTipe gunTipe;
    public enum GunTipe { Default, Enemy }
    private float rotZ;
    private Vector3 difference;
    private PlayerController player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        
    }
    void Update()
    {
        if(gunTipe == GunTipe.Default)
        {
            if (Mathf.Abs(joystick.Horizontal) > 0.3f || Mathf.Abs(joystick.Vertical) > 0.3f)
            {
                rotZ = Mathf.Atan2(joystick.Vertical, joystick.Horizontal) * Mathf.Rad2Deg;
            }
        }
      else if(gunTipe == GunTipe.Enemy)
        {
            difference = player.transform.position - transform.position; 
            rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        }
        

        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        if (timeBTWShots <= 0)
        {
            if (gunTipe == GunTipe.Enemy)
            {
                Shoot();
            }
            else if (gunTipe == GunTipe.Default)
            {
                if (joystick.Horizontal != 0 || joystick.Vertical != 0)
                {
                    Shoot();
                    
                }
            }
            
            
        }
        else 
        {
            timeBTWShots -= Time.deltaTime;
        }
    }
    public void Shoot()
    {
        Instantiate(bullet, shotpoint.position, shotpoint.rotation);
        timeBTWShots = startTimeBTWShots;
    }
    
}
