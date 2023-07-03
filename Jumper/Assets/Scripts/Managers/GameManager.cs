using UnityEngine;

public class GameManager : MonoBehaviour
{
    // References to Components
    public Jump jump; // Reference to the PlayerJump script


    // Start method that gets/finds components
    void Start()
    {
        jump = FindObjectOfType<Jump>(); // Find the PlayerJump script
    }

    
    public void EndGame()
    {
        Debug.Log("Game Over");
        jump.enabled = false; // Disable the PlayerJump script
    }

}
