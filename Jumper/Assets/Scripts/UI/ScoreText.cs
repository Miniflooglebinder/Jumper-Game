using UnityEngine;
using UnityEngine.UI; // Used for Text at the bottom of this file
using TMPro; // Used for TextMeshProUGUI at the bottom of this file

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component on this object
    private int score = 0;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = score.ToString();
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString(); // Update the score text
    }
}