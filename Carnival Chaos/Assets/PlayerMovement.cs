using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Joystick joystick;
    float horizontalMove = 0f;
    public float runSpeed;
    private bool facingRight = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        horizontalMove = joystick.Horizontal;
        rb.velocity = new Vector2(horizontalMove * runSpeed, rb.velocity.y);

        if (facingRight == false && horizontalMove > 0)
        {
            Flip();
        }

        else if (facingRight == true && horizontalMove < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }




}

