using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameToStartScript : MonoBehaviour
{
    public void GoBackToStart()
    {
        SceneManager.LoadScene("StartScene");
    }
}
