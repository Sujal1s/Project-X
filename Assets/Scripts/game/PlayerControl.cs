using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 5f;
    public Rigidbody2D body;
    public bool isJumping;
    public Button jumpButton;
    public Button quitButton; // Reference to the quit button
    public Animator _Animator;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.constraints = RigidbodyConstraints2D.FreezeRotation; // Disable Z rotation
        jumpButton.onClick.AddListener(Jump);
        quitButton.onClick.AddListener(QuitGame); // Add listener for quit button
        _Animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Get horizontal input from keyboard
        float horizontal = Input.GetAxis("Horizontal");
        // Set velocity based on horizontal input
        body.linearVelocity = new Vector2(horizontal * speed, body.linearVelocity.y);

        // Player flip based on 'A' and 'D' key presses
        if (Input.GetKeyDown(KeyCode.D))
        {
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.flipX = true;
        }

        // Jump with space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        _Animator.SetBool("iswalking", horizontal != 0);    
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