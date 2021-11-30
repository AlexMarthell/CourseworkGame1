using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick redJoystick;
    public Joystick joystick;
    public float speed;
    public float JumpForce;
    private float MoveInput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    public bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private Animator anim;
    public float health;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

   private void FixedUpdate()
    {
        MoveInput = joystick.Horizontal;
        rb.velocity = new Vector2(MoveInput * speed, rb.velocity.y);
        if(facingRight ==false && MoveInput > 0)
        {
            Flip();
        }
        if (facingRight == true && MoveInput < 0)
        {
            Flip();
        }
        if (MoveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
        //if (redJoystick.Horizontal> 0.5f && facingRight == false)
        //{
        //    Flip();
        //}
        //if (redJoystick.Horizontal < 0f && facingRight == true)
        //{
        //    Flip();
        //}
    }

    public void Update()
    {
        float verticalMove = joystick.Vertical;
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded == true && verticalMove > .5f) 
        {
            rb.velocity = Vector2.up * JumpForce;
            anim.SetTrigger("takeOff");
        }
        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }
        else
        {
            anim.SetBool("isJumping", true);
        }
        
    }
    public void TakeDamage(int damage)
    {
        
        health -= damage;
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        if (MoveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (MoveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            
        }
        
    }
}
