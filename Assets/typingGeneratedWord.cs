using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class typingGeneratedWord : MonoBehaviour
{
    Dictionary<int, string> wordList = new Dictionary<int, string>();


    public Text shownWord = null;
    public Text shownCount = null;

    private string remainingLetters = string.Empty;
    private string wordToType;
    private int wordCount = 0;


    private void pickWordToType()
    {
        //function to randomly select from the wordList dictionary
        List<string> words = new List<string>();

        StreamReader streamReader = new StreamReader(@"DifficultWords.txt");

        int fileIn = 0;

        while (streamReader.Peek() >= 0)
        {
            words.Add(streamReader.ReadLine().ToLower());
            fileIn++;
        }

        streamReader.Close();

        for (int i = 0; i < words.Count; i++)
        {
            wordList.Add(i, words[i]);
        }
    }

    private void Start()
    {
        pickWordToType();
        setWordToType();
    }

    private void setWordToType()
    {
        System.Random random = new System.Random();
        int rand = random.Next(0, wordList.Count);
        wordToType = wordList[rand];
        setRemainingLetters(wordToType);
    }

    private void setRemainingLetters(string newString)
    {
        remainingLetters = newString;
        shownWord.text = remainingLetters;
    }

    private void Update()
    {
        checkInput();
    }

    private void checkInput()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if (keysPressed.Length == 1) //ensures no error if 2 keys are pressed at the same time
            {
                enterLetter(keysPressed);
            }
        }
    }

    private void enterLetter(string typedLetter)
    {
        if (isCorrectLetter(typedLetter))
        {
            removeLetter();

            if (isWordComplete())
            {
                wordCount++;
                shownCount.text = wordCount.ToString();
                setWordToType();
            }
        }
        else //resets word if press wrong key
        {
            setRemainingLetters(wordToType);
        }
    }

    private bool isCorrectLetter(string letter)
    {
        return remainingLetters.IndexOf(letter) == 0;
    }

    private void removeLetter()
    {
        string newString = remainingLetters.Remove(0, 1);
        setRemainingLetters(newString);
    }

    private bool isWordComplete()
    {
        return remainingLetters.Length == 0;
    }

    public void resetGame()
    {
        wordCount = 0;
        shownCount.text = "0";
        setWordToType();
    }
}