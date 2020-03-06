using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      ShowGreeting();
      string userWord = GetWord();
      string userSentance = GetSentance();
      RepeatCounter repeatCounter = new RepeatCounter();
      repeatCounter.AddWord(userWord);
      repeatCounter.AddSentance(userSentance);
      CheckIfWord();
    }
    public static string ShowGreeting()
    {
      Console.WriteLine("Welcome to my Console Application!");
    }
    public static string GetWord()
    {
      Console.WriteLine("Enter a word: ");
      return string word = Console.ReadLine();
    }
    public static string GetSentance()
    {
      Console.WriteLine("Enter a sentance: ");
      return string sentance = Console.ReadLine();
    }
    public static void ShowWordCount()
    {
      if (repeatCounter.ContainsWord())
      {
        int wordCount = repeatCounter.WordRepeatCount();
        Console.WriteLine("Total Word Count: " + wordCount);
      }
      else
      {
        Console.WriteLine("The word you entered cannot be found in the sentance you entered. Please try again!"); 
      }
    }
  