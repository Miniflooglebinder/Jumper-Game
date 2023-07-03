using UnityEngine;

public class AutoJump : MonoBehaviour
{
    public Rigidbody playerRb;
    public float jumpForce = 18f;
    public float gravityBase = 30f;
    public float gravityExpontent = 2f;
    public float maxGravity = 70f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Jump() 
    {
        playerRb.velocity = Vector3.up * jumpForce;
    }

    void Update()
    {
        if (playerRb.position.y < 5f)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        float gravity = gravityBase * Mathf.Pow(playerRb.velocity.y, gravityExpontent);
        gravity = Mathf.Clamp(gravity, 0f, maxGravity);
        playerRb.AddForce(Vector3.down * gravity * playerRb.mass);
    }
}
