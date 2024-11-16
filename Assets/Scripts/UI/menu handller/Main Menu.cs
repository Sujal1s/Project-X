using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject settingsmenu;
    public GameObject levelselctor;
    public GameObject pausemenu;
    //  public GameObject creditsPanel; // This will be commented out for now

    public Button playButton;
    public Button settingsButton;
    public Button creditsButton; // This will be commented out for now
    public Button quitButton;

    void Start()
    {
        // Initialize the first active screen
        ShowMainMenu();

        // Add listeners to buttons
        playButton.onClick.AddListener(ShowLevelSelector);
        settingsButton.onClick.AddListener(ShowSettingsMenu);
        // creditsButton.onClick.AddListener(ShowCredits); // Commented out for now
        quitButton.onClick.AddListener(QuitGame);
    }

    void ShowMainMenu()
    {
        mainmenu.SetActive(true);
        settingsmenu.SetActive(false);
        levelselctor.SetActive(false);
        pausemenu.SetActive(false);
        // creditsPanel.SetActive(false); // Commented out for now
    }

    void ShowSettingsMenu()
    {
        mainmenu.SetActive(false);
        settingsmenu.SetActive(true);
        levelselctor.SetActive(false);
        // creditsPanel.SetActive(false); // Commented out for now
    }

    void ShowLevelSelector()
    {
        mainmenu.SetActive(false);
        settingsmenu.SetActive(false);
        levelselctor.SetActive(true);
        // creditsPanel.SetActive(false); // Commented out for now
    }
    

    // void ShowCredits()
    // {
    //     mainmenu.SetActive(false);
    //     settingsmenu.SetActive(false);
    //     levelselctor.SetActive(false);
    //     creditsPanel.SetActive(true);
    // }

    void QuitGame()
    {
        // Quit the application
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}