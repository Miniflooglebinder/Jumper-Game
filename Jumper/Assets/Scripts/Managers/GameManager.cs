using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // References to Components
    public Jump jump; // Reference to the PlayerJump script


    // Start method that finds objects in the scene and assigns them to variables
    void Start()
    {
        jump = FindObjectOfType<Jump>(); // Find the PlayerJump script
    }

    
    public void EndGame()
    {
        Debug.Log("Game Over");
        jump.enabled = false;

        Invoke("Restart", 2f); // Restart the game after 2 seconds
    }

    void Restart()
    {
        // Restart the game after 2 seconds
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
