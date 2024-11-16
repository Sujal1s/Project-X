using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public GameObject settingsMenuPanel;
    public GameObject mainMenuPanel;
    public Button resumeButton;
    public Button restartButton;
    public Button settingsButton;
    public Button mainMenuButton;

    private bool isPaused = false;

    void Start()
    {
        // Add listeners to buttons
        resumeButton.onClick.AddListener(ResumeGame);
        restartButton.onClick.AddListener(RestartGame);
        settingsButton.onClick.AddListener(ShowSettingsMenu);
        mainMenuButton.onClick.AddListener(ReturnToMainMenu);
    }

    void Update()
    {
        // Check for pause input (e.g., Escape key)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f; // Pause the game
        isPaused = true;
    }

    void ResumeGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f; // Resume the game
        isPaused = false;
    }

    void RestartGame()
    {
        Time.timeScale = 1f; // Ensure the game is not paused
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the current scene
    }

    void ShowSettingsMenu()
    {
        settingsMenuPanel.SetActive(true);
        pauseMenuPanel.SetActive(false);
    }

    void ReturnToMainMenu()
    {
        Time.timeScale = 1f; // Ensure the game is not paused
        SceneManager.LoadScene("MainMenu"); // Load the main menu scene
    }
}

public class SceneLoader : MonoBehaviour
{
    public string uiSceneName = "UIScene"; // Name of the scene containing the pause menu

    public void LoadUISceneAndShowPauseMenu()
    {
        SceneManager.LoadScene(uiSceneName, LoadSceneMode.Additive);
        StartCoroutine(ActivatePauseMenu());
    }

    private IEnumerator ActivatePauseMenu()
    {
        yield return new WaitForSeconds(0.1f); // Wait for the scene to load
        GameObject pauseMenuPanel = GameObject.Find("PauseMenuPanel");
        if (pauseMenuPanel != null)
        {
            pauseMenuPanel.SetActive(true);
        }
    }
}