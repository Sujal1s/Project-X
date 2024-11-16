using UnityEngine;
using UnityEngine.SceneManagement;

public class spike : MonoBehaviour
{
    // This method is called when another collider enters the trigger collider attached to this object
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that collided with the spike is the player
        if (other.CompareTag("Player"))
        {
            // Load the retry screen
            SceneManager.LoadScene("Retry screen");
        }
    }
}