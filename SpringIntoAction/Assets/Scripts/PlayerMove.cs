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

    //Animation
    public GameObject Facing;
    public GameObject TurnL;
    public GameObject TurnR;

    public bool Left;
    public bool Right;

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
        if (Left == true) 
        {
            TurnL.SetActive(true);
            TurnR.SetActive(false);
            Facing.SetActive(false);
        }

        if (Right == true)
        {
            TurnL.SetActive(false);
            TurnR.SetActive(true);
            Facing.SetActive(false);
        }

        if (Turn == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Left = true;
                rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            }


            else
            {
                Left = false;
                TurnL.SetActive(false);
                TurnR.SetActive(false);
                Facing.SetActive(true);
            }

            if (Input.GetKey(KeyCode.D))
            {
                Right = true;

                rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            }

            else
            {
                Right= false;
                TurnL.SetActive(false);
                TurnR.SetActive(false);
                Facing.SetActive(true);
            }
        }

       

    }
    
    

}
