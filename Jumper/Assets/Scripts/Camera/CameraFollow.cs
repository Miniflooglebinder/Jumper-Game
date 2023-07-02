using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform

    void Update()
    {
        Vector3 position = transform.position; // Get the current position of the camera (this object)
        position[0] = player.position.x; // Set the x position to the player's x position
        transform.position = position; // Set the camera's position to the new position
    }
}
