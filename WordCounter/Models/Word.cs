using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter 
  {
    public string WordInput { get; set; }
    public string SentanceInput { get; set; }
    // public static string[] wordList = System.IO.File.ReadAllLines(@"/Users/Guest/Desktop/WordCounter.Solution/WordCounter/Models/WordList.txt");

    public void AddWord(string userWord)
    {
      WordInput = userWord;
    }
    public void AddSentance(string userSentance)
    {
      SentanceInput = userSentance;
    }
    public static string[] SentanceToArray()
    {
      string[] sentanceArray = {"",""};
      return sentanceArray;
    }
  }
} 