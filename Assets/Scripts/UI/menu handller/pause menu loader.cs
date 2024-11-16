using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class pausemenuloader : MonoBehaviour
{
    public string uiSceneName = "UI"; // Name of the scene containing the panels
    public string panelName = "Pause Menu"; // Name of the panel to activate

    public void LoadUISceneAndShowPanel()
    {
        SceneManager.LoadScene(uiSceneName, LoadSceneMode.Additive);
        StartCoroutine(ActivatePanel());
    }

    private IEnumerator ActivatePanel()
    {
        yield return new WaitForSeconds(0.1f); // Wait for the scene to load

        // Find all panels and deactivate them
        GameObject[] panels = GameObject.FindGameObjectsWithTag("UI");
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }

        // Activate the specified panel
        GameObject targetPanel = GameObject.Find(panelName);
        if (targetPanel != null)
        {
            targetPanel.SetActive(true);
        }
    }
}