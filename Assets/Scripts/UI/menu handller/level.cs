using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level : MonoBehaviour
{
    // Public variables to assign the buttons in the Unity Editor
    public Button level1Button;
    public Button backButton;

    void Start()
    {
        // Add listeners to the buttons to call the respective methods when clicked
        level1Button.onClick.AddListener(OnLevel1ButtonClick);
        backButton.onClick.AddListener(OnBackButtonClick);
    }

    // This method is called when the level 1 button is clicked
    public void OnLevel1ButtonClick()
    {
        // Load the Level1 scene
        SceneManager.LoadScene("Level1");
    }

    // This method is called when the back button is clicked
    public void OnBackButtonClick()
    {
        // Load the MainMenu scene
        SceneManager.LoadScene("Main menu");
    }
}