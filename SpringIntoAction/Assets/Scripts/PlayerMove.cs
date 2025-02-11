using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jumpForce = 10;
    public float moveSpeed = 10;
    Rigidbody2D rb;
    Vector2 movement;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }
    }
    private void Update()
    {
        //movement.x = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.A))
        {

            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }

    }
    
    private void FixedUpdate()
    {
       // rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
