using System;

Scripture firstScripture = new Scripture(new Reference("1 Nephi", 1, 1, 2), "1. I, Nephi, having been born of goodly parents. 2. Words of the prophet yo.");

firstScripture.ConvertStringToList();

firstScripture.HideDemWords();

Word firstWord = new Word("POYO", true);
firstWord.HideWord();
