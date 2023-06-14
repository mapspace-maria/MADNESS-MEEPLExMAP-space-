using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer;
    private bool isTimerRunning;

    void Start()
    {
        timer = 60f; // Set timer to 60 seconds (1 minute)
        isTimerRunning = true; // Start timer
    }

    void Update()
    {
        if (isTimerRunning)
        {
            timer -= Time.deltaTime; // Subtract elapsed time from timer
            UpdateTimerText(); // Update UI text
        }

        if (timer <= 0f)
        {
            isTimerRunning = false; // Stop timer
            // Add code here to handle end of game or other actions
            SceneManager.LoadScene(2);
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        timerText.text = string.Format("Timer: {0:00}:{1:00}", minutes, seconds);
    }
}
