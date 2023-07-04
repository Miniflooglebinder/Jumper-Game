using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed =  5f;
    public float leftLimit = -25f;

    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // move the pipe set to the left
    void Update()
    {
        if (!gameManager.hasEnded)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            // If the pipe set is out of the screen, destroy it
            if (transform.position.x < leftLimit)
            {
                Destroy(gameObject);
            }
        }

        else
        {
            // Stop the pipe set from moving
            transform.Translate(Vector3.left * 0 * Time.deltaTime);
        }
    }
    
}
