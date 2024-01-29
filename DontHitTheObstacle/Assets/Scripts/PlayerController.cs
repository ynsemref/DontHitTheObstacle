using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    bool isGrounded = false;
    bool facingRight = true;
     
    
    

    void Update()
    {
        HandleMovement();
        handleTouchInput();
    }

    void HandleMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 moveDirection = new Vector2(horizontalInput, 0).normalized;

        if (isGrounded)
        {
            transform.Translate(moveDirection * MoveSpeed * Time.deltaTime);
        }

        if (ShouldFlip(horizontalInput))
        {
            FlipFace();
        }
    }

    bool ShouldFlip(float horizontalInput)
    {
        return (horizontalInput < 0 && facingRight) || (horizontalInput > 0 && !facingRight);
    }
    

    void FlipFace()
    {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
    }
    void handleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                moveLeft();
            }
            else if (touch.position.x >= Screen.width / 2)
            {
                moveRight();
            }
        }
    }
    void moveRight()
    {
        transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
        FlipFace();
    }
    void moveLeft()
    {
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
        FlipFace();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
}
