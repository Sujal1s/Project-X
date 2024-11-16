using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    // Public variable to assign the button in the Unity Editor
    public Button retryButton;

    void Start()
    {
        // Add a listener to the button to call the OnRetryButtonClick method when clicked
        retryButton.onClick.AddListener(OnRetryButtonClick);
    }

    // This method is called when the retry button is clicked
    public void OnRetryButtonClick()
    {
        // Load the Level1 scene
        SceneManager.LoadScene("Level1");
    }
}