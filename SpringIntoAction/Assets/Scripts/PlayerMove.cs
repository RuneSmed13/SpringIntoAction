using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool Turn = false;
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
            Turn = true;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Turn = false;
    }
    private void Update()
    {
        if (Turn == true)
        {
            if (Input.GetKey(KeyCode.A))
            {

                rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            }

            if (Input.GetKey(KeyCode.D))
            {

                rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            }
        }

       

    }
    
    

}
