using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnagram
{
    public class Anagram
    {
        public string Reverse(string? text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            if (text.Length == 1)
            {
                return text;
            }
            char[] textInChars = text.ToCharArray();
            int start = 0;
            for (int i = 0; i < textInChars.Length; i++)
            {
                if (textInChars[i] == ' ' || i == textInChars.Length - 1)
                {
                    ReverseWord(ref textInChars, start, i);
                    start = i;
                }
            }
            return new string(textInChars);
        }

        private char[] ReverseWord(ref char[] word, int start, int end)
        {
            if (start == end)
            {
                return word;
            }
            int movementСount = 0;
            int nonAlphabetCount = 0; ;
            int middle = (start + end) / 2;
            for (int i = start; i <= middle + nonAlphabetCount; i++)
            {
                if (i == end + 1)
                {
                    return word;
                }
                if (char.IsLetter(word[i]))
                {
                    for (int j = end - movementСount; j > i; j--)
                    {
                        if (char.IsLetter(word[j]))
                        {
                            char temp = word[i];
                            word[i] = word[j];
                            word[j] = temp;
                            movementСount++;
                            break;
                        }
                        movementСount++;
                    }
                    continue;
                }
                nonAlphabetCount++;
            }
            return word;
        }
    }
}
