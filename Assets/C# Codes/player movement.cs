using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;  // Movement speed of the character
    private Rigidbody2D rb;  // Reference to the Rigidbody2D component
    private Vector2 moveDirection;  // Direction to move in

    void Start()
    {
        // Get the Rigidbody2D component attached to this GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from horizontal (A/D or Left/Right arrows) and vertical (W/S or Up/Down arrows) axes
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Set the move direction based on input
        moveDirection = new Vector2(moveX, moveY).normalized;  // Normalize to prevent faster diagonal movement
    }

    void FixedUpdate()
    {
        // Apply the movement in FixedUpdate for physics-based calculations
        rb.velocity = moveDirection * moveSpeed;  // Set the velocity of the Rigidbody2D
    }
}