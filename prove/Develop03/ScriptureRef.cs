
using System;

public class ScriptureRef
    {
        private int Chapter;
        private int StartVerse;
        private int EndVerse;

        private ScriptureRef(int chapter, int startVerse, int endVerse = 0)
        {
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

 public override string ToString()
        {
            if (EndVerse == 0)
            {
                return $"{Chapter}:{StartVerse}";
            }
            else
            {
                return $"{Chapter}:{StartVerse}-{EndVerse}";
            }
        }
    }
