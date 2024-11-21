using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{



    //Variable for Collectable item controls
    public int Coins;

    //Variables for the UI 
    public TextMeshProUGUI ScoreText;

    //public Text Score;

    [System.Obsolete]
    void Start()
    {
        
        ScoreText.text = "Score: " + Coins;
    }

    public void AddCoins(int numberofCoins)
    {
        Coins += numberofCoins;
        ScoreText.text = "Score: " + Coins;
        DontDestroyOnLoad(ScoreText);
    }
}