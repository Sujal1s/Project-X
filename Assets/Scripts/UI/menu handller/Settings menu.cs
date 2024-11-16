using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject pauseMenu;
    public Button backButton;

    private bool cameFromPauseMenu = false;

    void Start()
    {
        // Add listener to the back button
        backButton.onClick.AddListener(HandleBackButton);
    }

    public void ShowSettingsFromMainMenu()
    {
        cameFromPauseMenu = false;
        ShowSettingsMenu();
    }

    public void ShowSettingsFromPauseMenu()
    {
        cameFromPauseMenu = true;
        ShowSettingsMenu();
    }

    void ShowSettingsMenu()
    {
        mainMenu.SetActive(false);
        pauseMenu?.SetActive(false);
        settingsMenu.SetActive(true);
    }

    void HandleBackButton()
    {
        if (cameFromPauseMenu)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            mainMenu.SetActive(true);
        }
        settingsMenu.SetActive(false);
    }
}