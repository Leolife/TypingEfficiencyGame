using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class RandomWordGenerator : MonoBehaviour
{
    public Text text;
    string downloadedString;
    WebClient client;
    // Start is called before the first frame update
    void Start()
    {
        string randWord = "";
        string rWord = "";
        client = new WebClient();
        downloadedString = client.DownloadString("https://www.wordgenerator.net/application/p.php?id=dictionary_words&type=1&spaceflag=false");
        string randomWord = downloadedString;
        for (int i = 0; i < randomWord.Length; i++)
        {
            if (randomWord[i] == ',')
            {
                randWord += ' ';
            }
            randWord += randomWord[i];
        }
        for (int i = 0; i < randomWord.Length; i++)
        {
            if ((randWord[i] >= 'A' && randWord[i] <= 'Z') || (randWord[i] >= 'a' && randWord[i] <= 'z') || randWord[i] == ' ')
            {
                rWord += randWord[i];
            }
        }
        text.text = rWord;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
