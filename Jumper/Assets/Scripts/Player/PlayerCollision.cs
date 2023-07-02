using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // Reference to the PlayerMovement script

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") // If the player collides with an object with the tag "Obstacle"
        {
            movement.enabled = false; // Disable the PlayerMovement script
        }
    }
}
