using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class PlayerMove : MonoBehaviour
{
    public bool Turn = false;
    public float jumpForce = 10;
    public float moveSpeed = 10;
    Rigidbody2D rb;
    Vector2 movement;

    //Animation
    public GameObject Facing;
    public GameObject TurnL;
    public GameObject TurnR;
    public GameObject Down;

    public AudioSource Boing1;
    public AudioSource Boing2;
    public AudioSource Boing3;
    public AudioSource Boing4;

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

            TurnL.SetActive(false);
            TurnR.SetActive(false);
            Facing.SetActive(false);
            Down.SetActive(true);

            Invoke("Press", 0.3f);

            int BoingWhat = Random.Range(1, 5);

            if (BoingWhat == 1)
            {
                Boing1.Play();
            }

            if (BoingWhat == 2)
            {
                Boing2.Play();
            }

            if (BoingWhat == 3)
            {
                Boing3.Play();
            }

            if (BoingWhat == 4)
            {
                Boing4.Play();
            }

            if (BoingWhat == 5)
            {
                Boing1.Play();
            }


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
            Down.SetActive(false);
        }

        if (Right == true)
        {
            TurnL.SetActive(false);
            TurnR.SetActive(true);
            Facing.SetActive(false);
            Down.SetActive(false);
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
                Facing.SetActive(false);
                Down.SetActive(true);
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
                Facing.SetActive(false);
                Down.SetActive(true);
            }
        }

       

    }

    public void Press()
    {
        Down.SetActive(false);
        Facing.SetActive(true);
    }




}
