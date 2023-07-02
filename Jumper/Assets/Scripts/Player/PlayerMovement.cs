using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 22f;
    public float gravityBase = 30f;
    public float gravityExpontent = 2f;
    public float maxGravity = 70f;

    private Rigidbody rb; // Reference to the player's Rigidbody

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the player's Rigidbody
        rb.freezeRotation = true; // Freeze the player's rotation
    }

    void jump()
    {
        rb.velocity = Vector3.up * jumpForce; // Set the player's velocity to up times the jump force
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // If the player presses the space key
        {
            jump(); // Call the jump function
        }
    }

    void FixedUpdate()
    {
        float gravity = gravityBase * Mathf.Pow(rb.velocity.y, gravityExpontent); // Calculate the gravity
        gravity = Mathf.Clamp(gravity, 0f, maxGravity); // Clamp the gravity to the max gravity
        rb.AddForce(Vector3.down * gravity * rb.mass); // Add the gravity to the player

        Vector3 velocity = rb.velocity; // Get the player's velocity
        velocity.x = speed; // Set the x velocity to the speed
        rb.velocity = velocity; // Set the player's velocity to the new velocity
    }

}
