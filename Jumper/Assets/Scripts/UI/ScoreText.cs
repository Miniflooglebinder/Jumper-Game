using UnityEngine;
using UnityEngine.UI; // Used for Text at the bottom of this file
using TMPro; // Used for TextMeshProUGUI at the bottom of this file

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component on this object
    private int score = 0;

    private TextMeshProUGUI highScoreText;

    private void Start()
    {
        highScoreText = GameObject.Find("Highscore").GetComponent<TextMeshProUGUI>();
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = score.ToString();
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString(); // Update the score text

        PlayerPrefs.SetInt("HighScore", score);
    }
}