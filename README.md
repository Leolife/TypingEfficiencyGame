# TypingEfficiencyGame
This is a typing game that is made with Unity.  It is meant to improve your typing skills with difficult words.  The game works by showing a word on the screen that you must type.  As you type the word, each letter you type disappears, showing only what is left for you to type.  It shows how many words you have typed.  There includes a home screen and an option to pause.

Basic explanation of how the code works within the game:

I have a list of difficult words in a text file.  Within my code, the text file is read into a list data structure, which is then fed into a dictionary data structure.  This allows me to randomly access a key from the dictionary and use the corresponding value that is the word to be spelled.  As you type, the game checks the keys you press on your keyboard to make sure they match the next letter that needs to be typed.  If at any point you misspell a word, the same word is given back to you to type again until you complete it.  Each time you complete a word, the word count increases by one and a new word randomly appears from the dictionary.  There is a timer set for 30 seconds that, upon completion, signals for the end game screen to display showing your final score.

Home Screen:
![image](https://github.com/Leolife/TypingEfficiencyGame/assets/95724102/fe9fe11c-3915-4a51-ba24-6a88ccf23cef)

During the game:
![image](https://github.com/Leolife/TypingEfficiencyGame/assets/95724102/43df1707-5247-4950-b941-fc61b9ec3528)

Pause Menu:
![image](https://github.com/Leolife/TypingEfficiencyGame/assets/95724102/2dc65561-e3cc-450a-ba82-3b013ba5dbf9)

End Screen:
![image](https://github.com/Leolife/TypingEfficiencyGame/assets/95724102/d4a1633f-5e5a-40b1-9dc4-d6fba2405f77)
