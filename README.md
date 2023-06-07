# TypingEfficiencyGame
This is a typing game that I am making with Unity.  It is meant to improve your typing skills with difficult words.  The game works by showing a word on the screen that you must type.  As you type the word, each letter you type disappears, showing only what is left for you to type.

Basic explanation of how the code works within the game:

I have a list of words in a text file that I got from this website, https://grammarist.com/tricky-hard-words-to-spell/.  Within my code, the text file is read into a list data structure, which is then fed into a dictionary data structure.  This allows me to randomly access a key from the dictionary and use the corresponding value that is the word to be spelled.  As you type, the game checks the keys you press on your keyboard to make sure they match the next letter that needs to be typed.  If at any point you misspell a word, the same word is given back to you to type again until you complete it.  Each time you complete a word, a new one randomly appears from the dictionary.  When you are done playing, you can press the exit button and the application will close.

Screenshot of game:
![image](https://github.com/Leolife/TypingEfficiencyGame/assets/95724102/cd5a52ee-9ac1-4043-81f6-cd265a7160f4)
