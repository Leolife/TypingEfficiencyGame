using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenManager : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject homeScreen;
    public typingGeneratedWord type;

    void Start()
    {
        type = GameObject.FindGameObjectWithTag("typingManager").GetComponent<typingGeneratedWord>();
        Time.timeScale = 0f;
    }
    public void startGame()
    {
        homeScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    public void goHomeScreen()
    {
        homeScreen.SetActive(true);
        pauseScreen.SetActive(false);
        type.resetGame();
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
