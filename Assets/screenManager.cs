using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenManager : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject homeScreen;

    void Start()
    {
        Time.timeScale = 0f;
    }
    public void startGame()
    {
        homeScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    public void pauseGame()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resumeGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
