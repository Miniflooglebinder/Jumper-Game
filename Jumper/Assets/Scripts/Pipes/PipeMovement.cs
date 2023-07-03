using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed =  5f;
    public float leftLimit = -25f;

    // move the pipe set to the left
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // If the pipe set is out of the screen, destroy it
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }
    
}
