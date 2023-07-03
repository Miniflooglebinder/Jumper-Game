using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // A script that moves the pipes to the left including the top and bottom pipes and the gap between them
    // This script is attached to the Pipes object

    public float speed = 5.5f;
    public float leftBound = -25f; // The left bound of the pipes before they are destroyed

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime); // Move the pipes to the left

        if (transform.position.x < leftBound) // If the pipes have reached the left bound
        {
            Destroy(gameObject); // Destroy the pipes
        }
    }
}
