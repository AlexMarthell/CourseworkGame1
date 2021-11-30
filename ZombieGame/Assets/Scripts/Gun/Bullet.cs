using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    
    public LayerMask whatIsSolid;
    [SerializeField] bool enemybullet;
    private void Start()
    {
        Invoke("DestroyBullet", lifeTime);
    }
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Zombie1>().TakeDamage(damage); 
            }
            if (hitInfo.collider.CompareTag("Player")&& enemybullet)
            {
                hitInfo.collider.GetComponent<PlayerController>().TakeDamage(damage);
            }

            DestroyBullet();

        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

}
