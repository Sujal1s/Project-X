using UnityEngine;
using UnityEngine.SceneManagement;

public class escbutton : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Retry screen"); // Replace "RetryScene" with the name of your retry scene
        }
    }
}