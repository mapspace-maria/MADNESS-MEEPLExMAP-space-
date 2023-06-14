using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TextMeshProUGUI scoreText;

    public int maxScore = 10;
    public int currentScore = 0;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    public void UpdateScore(int score)
    {
        currentScore = score;
        scoreText.text = "Coins: " + currentScore.ToString() + "/" + maxScore.ToString();

        if (currentScore == maxScore)
        {
        // Load the scene with index number 3
         SceneManager.LoadScene(3);
        }
    }
}
