using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter 
  {
    public string WordInput { get; set; }
    public string SentanceInput { get; set; }
    public static string[] wordList = System.IO.File.ReadAllLines(@"/Users/Guest/Desktop/WordCounter.Solution/WordCounter/Models/WordList.txt");

    public void AddWord(string userWord)
    {
      WordInput = userWord;
    }
    public void AddSentance(string userSentance)
    {
      SentanceInput = " " + userSentance + " ";
    }
    public static string[] SentanceToArray(string userSentance)
    {
      string[] sentanceArray = userSentance.Split(" ");
      return sentanceArray;
    }
    public bool ContainsWord()
    {
      return SentanceInput.Contains(WordInput);
    }
    public int WordRepeatCount()
    {
      string[] sentanceArray = SentanceToArray(SentanceInput);
      int wordCount = 0;
      foreach(string word in sentanceArray)
      {
        Console.WriteLine(word);
        if (word.Contains(WordInput))
        {
          wordCount += 1;
        }
      }
      return wordCount;
    }
    public bool IsAWord(string userInput)
    {
      foreach (string entry in wordList)
      {
        if (entry.Contains(userInput))
        {
          return true;
        }
      }
      return false;
    }
  }
} 