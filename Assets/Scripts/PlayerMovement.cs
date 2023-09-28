using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this to control the movement speed
    public float jumpForce = 10.0f; // Adjust this to control the jump force
    private Rigidbody2D rb;
    private bool isGrounded;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the movement vector
        Vector2 movement = new Vector2(horizontalInput * moveSpeed * Time.deltaTime, rb.velocity.y);

        // Move the player horizontally
        rb.velocity = movement;

        // Check if the player is grounded
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        // Handle jumping
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // Flip the player's sprite based on the movement direction
        if (horizontalInput > 0)
        {
            // Moving right, flip the sprite to face right
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            // Moving left, flip the sprite to face left
            spriteRenderer.flipX = true;
        }
    }
}