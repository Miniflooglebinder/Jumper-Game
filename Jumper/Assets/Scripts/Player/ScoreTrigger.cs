using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public ScoreText scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Counter"))
        {
            scoreText.IncrementScore();
        }
    }
}
