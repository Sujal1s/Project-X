using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
  
    public Button retryButton;
    public Button mainMenuButton;

    void Start()
    {
        
        retryButton.onClick.AddListener(OnRetryButtonClick);
        mainMenuButton.onClick.AddListener(OnMainMenuButtonClick);
    }

   
    public void OnRetryButtonClick()
    {
        // Load the Level1 scene
        SceneManager.LoadScene("Level1");
    }

    
    public void OnMainMenuButtonClick()
    {
        // Load the MainMenu scene
        SceneManager.LoadScene("Main menu");
    }
}