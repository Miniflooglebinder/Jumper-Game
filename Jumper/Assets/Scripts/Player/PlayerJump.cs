using UnityEngine;

public class Jump : MonoBehaviour
{
    public bool canJump = true;

    public float jumpForce = 18f;
    public float gravityBase = 30f;
    public float gravityExpontent = 2f;
    public float maxGravity = 70f;

    private Rigidbody playerRB; // Reference to the Rigidbody component of the object this script is attached to (the player)
    private Transform playerTR; // Reference to the Transform component of the object this script is attached to (the player)

    private GameManager gameManager; // Reference to the GameManager script

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
        playerTR = GetComponent<Transform>();

        //Q: Why do we use FindObjectOfType instead of GetComponent for the GameManager script?
        //A: Because the GameManager script is attached to a different object than the player.
    }

    void jump()
    {
        playerRB.velocity = Vector3.up * jumpForce;
    }

    void Update()
    {
        if (gameManager.hasStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canJump)
            {
                jump();
            }
        }

        else if (!gameManager.hasStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameManager.StartGame();
                jump(); // Prevents having to press space twice to jump when the game starts
            }

            else if (playerTR.position.y < 4f) // Idle jump before the game starts
            {
                jump();
            }
        }
    }

    void FixedUpdate()
    {
        float gravity = gravityBase * Mathf.Pow(playerRB.velocity.y, gravityExpontent);
        gravity = Mathf.Clamp(gravity, 0f, maxGravity);
        playerRB.AddForce(Vector3.down * gravity * playerRB.mass);
    }
}