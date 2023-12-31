using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // References to Components
    public Jump jump; // Reference to the PlayerJump script
    public GroundStop groundStop; // Reference to the GroundStop script
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;

    // Variables
    public bool hasStarted = false;
    public bool hasEnded = false;


    void Start()
    {
        jump = FindObjectOfType<Jump>(); // Find the PlayerJump script
        groundStop = FindObjectOfType<GroundStop>(); // Find the GroundStop script
        highScoreText = GameObject.Find("Highscore").GetComponent<TextMeshProUGUI>();
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    
    public void StartGame()
    {
        jump.canJump = true;
        hasStarted = true;

        highScoreText.enabled = false;
        scoreText.enabled = true;

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

    public void ResetHighScore() // Not in use yet
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScoreText.text = "Highscore: 0";
    }
}
