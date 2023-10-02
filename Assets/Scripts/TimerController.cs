using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerController : MonoBehaviour
{

    public float timerDuration = 0f;
    private float timer;
    private bool isGameRunning = true;


    public TextMeshProUGUI timerText;

    void Start()
    {
        timer = timerDuration;
    }

    void Update()
    {
        if (isGameRunning)
        {
            timer += Time.deltaTime;
            UpdateTimerDisplay();
        }
    }
    public void EndGame()
    {
        isGameRunning = false;
        // Store the timer value in PlayerPrefs with a key, e.g., "ElapsedTime".
        PlayerPrefs.SetFloat("ElapsedTime", timer);
        PlayerPrefs.Save();
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
