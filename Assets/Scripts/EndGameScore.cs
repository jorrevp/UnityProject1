using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGameScore : MonoBehaviour
{
    public TextMeshProUGUI elapsedTimeText;

    void Start()
    {
        // Retrieve the timer value from PlayerPrefs.
        float elapsedTime = PlayerPrefs.GetFloat("ElapsedTime", 0);

        // Display the elapsed time in your TextMeshPro Text element.
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 1000) % 1000);
        elapsedTimeText.text = string.Format("Elapsed Time: {0:00}:{1:00}.{2:000}", minutes, seconds, milliseconds);
    }
}
