using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie1 : MonoBehaviour
{
    public int health;
    public float speed;
    private float timeBtwAttcak;
    public float startTimeBtwAttcak;
    public int damage;
    private float stopTime;
    public float startStopTime;
    public float normalSpeed;
    private PlayerController player;
    private Animator anim;
    public GameObject bloodEffect;

    private void Start()
    {
        anim = GetComponent<Animator>();
        player = FindObjectOfType<PlayerController>();
        normalSpeed = speed;
        
    }

    private void Update()
    {
        if (stopTime <= 0)
        {
            speed = normalSpeed;

        }
        else
        {
            speed = 0;
            stopTime -= Time.deltaTime;
        }
        if (health <= 0)
        {
            Instantiate(bloodEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (player.health > 0)
        {
            if (player.transform.position.x > transform.position.x)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
        
        }
        if (player.health > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        /*transform.Translate(Vector2.left * speed * Time.deltaTime)*/;
    }
    public void TakeDamage(int damage)
    {
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        stopTime = startStopTime;
        health -= damage;
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (timeBtwAttcak <= 0)
            {
                anim.SetTrigger("attack");
                OnEnemyAttack();
            }
            else
            {
                timeBtwAttcak -= Time.deltaTime;
            }
        }
        
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("isRunning", true);
        }
    }
    public void OnEnemyAttack()
    {
        if (player.health > 0)
        {
            player.health -= damage;
            timeBtwAttcak = startTimeBtwAttcak;
        }
       
    }
}
