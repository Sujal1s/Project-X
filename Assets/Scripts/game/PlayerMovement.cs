using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 5f;
    public Rigidbody2D body;
    public bool isJumping;
    public Joystick joystick;
    public Button jumpButton;
    public Button quitButton; // Reference to the quit button


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        jumpButton.onClick.AddListener(Jump);
        quitButton.onClick.AddListener(QuitGame); // Add listener for quit button
    }

    void Update()
    {
        // Get horizontal input from joystick and keyboard
        float horizontal = joystick.Horizontal + Input.GetAxis("Horizontal");

        // Set velocity based on horizontal input
        body.linearVelocity = new Vector2(horizontal * speed, body.linearVelocity.y);

        // Player flip
        if (horizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (horizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
        }

        // Jump with space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        if (!isJumping)
        {
            body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

 
}