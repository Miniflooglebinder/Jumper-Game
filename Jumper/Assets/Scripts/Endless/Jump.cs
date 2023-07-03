using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 22f;
    public float gravityBase = 30f;
    public float gravityExpontent = 2f;
    public float maxGravity = 70f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void jump()
    {
        rb.velocity = Vector3.up * jumpForce;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }

    void FixedUpdate()
    {
        float gravity = gravityBase * Mathf.Pow(rb.velocity.y, gravityExpontent);
        gravity = Mathf.Clamp(gravity, 0f, maxGravity);
        rb.AddForce(Vector3.down * gravity * rb.mass);
    }
}
