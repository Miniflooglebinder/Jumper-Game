using UnityEngine;
using UnityEngine.UI; // Used for Text at the bottom of this file
using TMPro; // Used for TextMeshProUGUI at the bottom of this file

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component on this object
    private int score = 0;
    public bool hasBeatenHighScore = false;

    private TextMeshProUGUI highScoreText;

    private void Start()
    {
        highScoreText = GameObject.Find("Highscore").GetComponent<TextMeshProUGUI>();
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();

        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + score.ToString();
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString(); // Update the score text

        if (score > PlayerPrefs.GetInt("HighScore", 0)) // If the current score is greater than the high score
        {
            if(!hasBeatenHighScore)
            {
                FindObjectOfType<AudioManager>().Play("HighScore");
                hasBeatenHighScore = true;
            }

            PlayerPrefs.SetInt("HighScore", score); // Set the high score to the current score
            highScoreText.text = "Highscore: " + score.ToString();
        }
    }
}