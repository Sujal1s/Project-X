using TMPro;
using UnityEngine;

public class coinSystem : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private static int score = 0;  // Use static to retain score across instances

    void Start()
    {
        UpdateScoreText();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("coin") && gameObject.CompareTag("Player"))
        {
            Debug.Log("Coin collected!");
            score += 5;
            UpdateScoreText();
            Destroy(collision.gameObject);  // Destroy the coin
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}