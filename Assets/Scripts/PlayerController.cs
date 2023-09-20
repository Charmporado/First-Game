using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 2;
    private Rigidbody rb;
    public float jumpForce;
    public float gravityScale;
    public float distToGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        distToGround = GetComponent<Collider>().bounds.extents.y;
    }

    // Update is called once per frame
    void Update()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (movementHorizontal, 0.0f, movementVertical);
        rb.AddForce (movement * speed);

        if (Input.GetButtonDown("Jump"))
        {
            if (IsGrounded())
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            }
            Debug.Log("Jumping");
        }
        if (transform.position.y < -4)
        {
                GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

        // Checks if Player has collision with an object below it.
        bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + (float)0.1);
    }
}
