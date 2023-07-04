using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // References to Components
    public Jump jump; // Reference to the PlayerJump script
    public GroundStop groundStop; // Reference to the GroundStop script

    // Variables
    public bool hasStarted = false;
    public bool hasEnded = false;


    void Start()
    {
        jump = FindObjectOfType<Jump>(); // Find the PlayerJump script
        groundStop = FindObjectOfType<GroundStop>(); // Find the GroundStop script
    }

    
    public void StartGame()
    {
        jump.canJump = true;
        hasStarted = true;

        FindObjectOfType<AudioManager>().Play("Start");
    }

    public void EndGame()
    {
        jump.canJump = false;
        hasEnded = true;
        groundStop.Stop();

        Invoke("Restart", 2f); // Restart the game after 2 seconds
    }

    void Restart()
    {
        // Restart the game after 2 seconds
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
