using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Scrollbar resolutionScrollbar;
    public Scrollbar audioScrollbar;
    public TextMeshProUGUI resolutionText;
    public TextMeshProUGUI audioText;

    void Start()
    {
        resolutionScrollbar.onValueChanged.AddListener(OnResolutionChange);
        audioScrollbar.onValueChanged.AddListener(OnAudioChange);
        OnResolutionChange(resolutionScrollbar.value); // Initialize with the current scrollbar value
        OnAudioChange(audioScrollbar.value); // Initialize with the current scrollbar value
    }

    void OnResolutionChange(float value)
    {
        int resolutionIndex = Mathf.RoundToInt(value * 3); // Assuming the scrollbar value ranges from 0 to 1
        string resolutionString = "";
        switch (resolutionIndex)
        {
            case 0:
                Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
                resolutionString = "1920 x 1080";
                break;
            case 1:
                Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
                resolutionString = "1280 x 720";
                break;
            case 2:
                Screen.SetResolution(640, 480, FullScreenMode.Windowed);
                resolutionString = "640 x 480";
                break;
            case 3:
                Screen.SetResolution(640, 360, FullScreenMode.Windowed);
                resolutionString = "640 x 360";
                break;
            default:
                Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
                resolutionString = "1920 x 1080";
                break;
        }
        resolutionText.text = "" + resolutionString;
    }

    void OnAudioChange(float value)
    {
        int audioLevel = Mathf.RoundToInt(value * 100); // Assuming the scrollbar value ranges from 0 to 1
        AudioListener.volume = audioLevel / 100f; // Set the game audio level
        audioText.text = "" + audioLevel + "%";
    }
}