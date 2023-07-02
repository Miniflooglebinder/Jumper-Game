using UnityEngine;
using UnityEngine.SceneManagement; // Allows us to use SceneManager

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f; // Delay before restarting the game

    public GameObject completeLevelUI; // Reference to the UI that displays when the level is complete
    public PlayerMovement movement;
    public Rigidbody rb;

    void Start()
    {
        movement = GameObject.FindObjectOfType<PlayerMovement>(); // Find the PlayerMovement script
        rb = GameObject.FindObjectOfType<Rigidbody>(); // Find the Rigidbody
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true); // Display the UI
    }

    public void EndGame()
    {
        if (gameHasEnded == false) // If the game has not ended
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay); // Restart the game after 1 second
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the current scene (level)
    }

    // Upon user pressing space, the PlayerMovement script will be enabled and the game will start
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && movement.enabled == false)
        {
            movement.enabled = true;
            rb.useGravity = true;
        }
    }

}
