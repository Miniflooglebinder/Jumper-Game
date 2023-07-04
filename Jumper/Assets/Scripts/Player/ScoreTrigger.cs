using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public ScoreText scoreText;

    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<ScoreText>();
        //Q: What is the (ScoreText) doing here?
        //A: It's called casting. We're telling the compiler that we know that the object we're getting has a ScoreText component on it.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Counter"))
        {
            scoreText.IncrementScore();
        }
    }
}