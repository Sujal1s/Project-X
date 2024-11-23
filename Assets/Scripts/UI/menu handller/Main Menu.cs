using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button settingsButton;
    public Button creditsButton;
    public Button quitButton;

    void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        settingsButton.onClick.AddListener(OpenSettings);
        creditsButton.onClick.AddListener(OpenCredits);
        quitButton.onClick.AddListener(QuitGame);
    }

    void PlayGame()
    {
        SceneManager.LoadScene("Level Manger");
    }

    void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    void OpenCredits()
    {
        // Uncomment the line below to enable the credits scene
        // SceneManager.LoadScene("Credits");
    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}