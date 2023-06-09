using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenManager : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject homeScreen;
    public GameObject endScreen;
    public typingGeneratedWord type;

    public Text shownTimer = null;
    public Text shownFinalScore = null;

    private float timer = 30;
    private bool isTimerOn;

    private void Start()
    {
        type = GameObject.FindGameObjectWithTag("typingManager").GetComponent<typingGeneratedWord>();
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (timer > 0 && isTimerOn)
        {
            timer -= Time.deltaTime;
            int roundedTimer = Mathf.RoundToInt(timer);
            shownTimer.text = roundedTimer.ToString();
            if (roundedTimer == 0)
            {
                isTimerOn = false;
                goEndScreen();
            }
        }
    }

    public void startGame()
    {
        timer = 30;
        type.resetGame();
        homeScreen.SetActive(false);
        endScreen.SetActive(false);
        shownTimer.text = timer.ToString();
        Time.timeScale = 1f;
        startTimer();
    }

    private void goEndScreen()
    {
        Time.timeScale = 0f;
        endScreen.SetActive(true);
        string finalScore = type.getWordCount();
        shownFinalScore.text = finalScore;
    }

    public void goHomeScreen()
    {
        homeScreen.SetActive(true);
        pauseScreen.SetActive(false);
        endScreen.SetActive(false);
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

    public void startTimer()
    {
        isTimerOn = true;
    }
}
