using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    // A script that will be attached to the TextMeshPro object that displays the score in the UI and will be used to update the score ny 1 when IncrementScore() is called.
    private TextMeshProUGUI scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = score.ToString("0");
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
