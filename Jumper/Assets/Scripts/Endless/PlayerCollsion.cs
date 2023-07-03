using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{
    public Jump movement; // Reference to the PlayerMovement script

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") // If the player collides with an object with the tag "Obstacle"
        {
            movement.enabled = false; // Disable the jump script
            FindObjectOfType<EndlessManager>().EndGame();
        }
    }
}
