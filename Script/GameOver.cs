using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static ScoreManager Instance;

    public TextMeshProUGUI scoreText;

    private int maxScore = 10;
    private int currentScore = 0;

    public void UpdateScore(int score)
    {
        currentScore = score;
        scoreText.text = "Total Coins: " + currentScore.ToString() + "/" + maxScore.ToString();

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
