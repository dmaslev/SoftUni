using System;
using System.Collections.Generic;

class LongestWord
{
    static void Main()
    {
        string word = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string longestWord = string.Empty;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                string leftWord = FindAlphabeticalWord(word, n, row, col, -1, 0);
                longestWord = CompareWords(leftWord, longestWord);
                string rightWord = FindAlphabeticalWord(word, n, row, col, 1, 0);
                longestWord = CompareWords(rightWord, longestWord);
                string upWord = FindAlphabeticalWord(word, n, row, col, 0, -1);
                longestWord = CompareWords(upWord, longestWord);
                string downWord = FindAlphabeticalWord(word, n, row, col, 0, 1);
                longestWord = CompareWords(downWord, longestWord);
            }
        }
        Console.WriteLine(longestWord);
    }

    private static string CompareWords(string leftWord, string longestWord)
    {
        if (leftWord.Length > longestWord.Length ||
            (leftWord.Length == longestWord.Length && //this was the missing equation
            leftWord.CompareTo(longestWord) < 0))
        {
            return leftWord;
        }
        return longestWord;
    }

    private static string FindAlphabeticalWord(string word, int n, int row, int col, int directionX, int directionY)
    {
        char currentLetter = GetCharAtPosition(word, n, row, col);
        List<char> alphabeticalWord = new List<char>();
        alphabeticalWord.Add(currentLetter);

        while (true)
        {
            row = row + directionY;
            col = col + directionX;
            if ((row < 0 || row >= n) || (col < 0 || col >= n))
            {
                break;
            }

            char nextLetter = GetCharAtPosition(word, n, row, col);

            if (currentLetter >= nextLetter)
            {
                break;
            }
            alphabeticalWord.Add(nextLetter);
            currentLetter = nextLetter;
        }
        string currentWord = new string(alphabeticalWord.ToArray());
        return currentWord;
    }

    private static char GetCharAtPosition(string word, int n, int row, int col)
    {
        char currentLetter = word[(row * n + col) % word.Length];
        return currentLetter;
    }
}
