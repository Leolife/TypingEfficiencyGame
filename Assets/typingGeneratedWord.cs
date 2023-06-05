using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class typingGeneratedWord : MonoBehaviour
{
    Dictionary<int, string> wordList = new Dictionary<int, string>();


    public Text shownWord = null;

    private string remainingLetters = string.Empty;
    private string wordToType;


    private void pickWordToType()
    {
        //function to randomly select from the wordList dictionary
        string[] words = new string[84];

        StreamReader streamReader = new StreamReader(@"DifficultWords.txt");

        for (int i = 0; i < 84; i++)
        {
            words[i] = streamReader.ReadLine().ToLower();
        }

        streamReader.Close();

        for (int i = 0; i < words.Length; i++)
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
        int rand = random.Next(0, 84);
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

}