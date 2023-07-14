# TypingEfficiencyGame

## Type as many difficult words as you can in 30 seconds!

This is a typing game that is made with Unity.  It is meant to improve your typing skills with difficult words.  The game works by showing a word on the screen that you must type.  As you type the word, each letter you type disappears, showing only what is left for you to type.  It shows how many words you have typed.  There includes a home screen and an option to pause.

Basic explanation of how the code works within the game:

I have a list of difficult words in a text file.  Within my code, the text file is read into a list data structure, which is then fed into a dictionary data structure.  This allows me to randomly access a key from the dictionary and use the corresponding value that is the word to be spelled.  As you type, the game checks the keys you press on your keyboard to make sure they match the next letter that needs to be typed.  If at any point you misspell a word, the same word is given back to you to type again until you complete it.  Each time you complete a word, the word count increases by one and a new word randomly appears from the dictionary.  There is a timer set for 30 seconds that, upon completion, signals for the end game screen to display showing your final score.

## Game Screenshots
Home Screen:
![image](https://github.com/Leolife/TypingEfficiencyGame/assets/95724102/45889a1a-ccef-464c-9aeb-5a99b2ec4c4f)

During the game:
![image](https://github.com/Leolife/TypingEfficiencyGame/assets/95724102/2f2fe36e-4252-48ee-aa58-8d1335c40be0)

Pause Menu:
![image](https://github.com/Leolife/TypingEfficiencyGame/assets/95724102/4edeb421-8911-47f9-ad88-d972d47f81bb)

End Screen:
![image](https://github.com/Leolife/TypingEfficiencyGame/assets/95724102/3c58dce7-2b81-416b-9081-ca7606904384)
