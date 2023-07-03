using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessManager : MonoBehaviour
{
    
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public Jump jump;
    public Rigidbody playerRb;
    public PipeMovement pipeMovement;
    public NewBehaviourScript pipeSpawner;
    public AutoJump autoJump;

    void Start()
    {
        jump = GameObject.FindObjectOfType<Jump>();
        playerRb = GameObject.FindObjectOfType<Rigidbody>();
        pipeSpawner = GameObject.FindObjectOfType<NewBehaviourScript>();
        autoJump = GameObject.FindObjectOfType<AutoJump>();
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void StartGame()
    {
        jump.enabled = true;
        pipeSpawner.enabled = true;
        pipeMovement.enabled = true;
        autoJump.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && autoJump.enabled == true)
        {
            StartGame();
        }
    }

}
