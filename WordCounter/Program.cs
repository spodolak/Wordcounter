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
      string userSentence = GetSentence();
      RepeatCounter repeatCounter = new RepeatCounter();
      repeatCounter.AddWord(userWord);
      repeatCounter.AddSentence(userSentence);
      ShowWordCount(repeatCounter);
      ShowGoodbye();
    }

    //Console greetings
    public static void ShowGreeting()
    {
      RainbowPrint("Welcome to my console application!");
    }
    public static void ShowGoodbye()
    {
      RainbowPrint("Goodbye! Thanks for using my application");
    }

    //Adds user input to back end constructor. Will notify user if inputted word is not a 'real' word.
    public static string GetWord()
    {
      Console.WriteLine("Enter a word: ");
      string word = Console.ReadLine();
      if (RepeatCounter.IsAWord(word))
      {
        return word.ToLower();
      }
      else
      {
        Console.WriteLine("Hey, That's not a real word! But I'll search for it anyway");
        return word;
      }
    }
    public static string GetSentence()
    {
      Console.WriteLine("Enter a sentence: ");
      string sentence = Console.ReadLine();
      return sentence.ToLower();
    }

    //Checks and returns word count in user sentence
    public static void ShowWordCount(RepeatCounter repeatCounter)
    {
      if (repeatCounter.ContainsWord())
      {
        int wordCount = repeatCounter.WordRepeatCount();
        Console.WriteLine(repeatCounter.WordInput + " shows ups " + wordCount + " times in your sentence");
      }
      else
      {
        Console.WriteLine("The word you entered cannot be found in the sentence you entered. Sorry!"); 
      }
    }

    //Stand-alone method that returns rainbow text to console
		public static void RainbowPrint(string text)
		{
			char[] rainbowArray = text.ToCharArray();
			ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
			int i = 1;
      Console.BackgroundColor = ConsoleColor.Black;
			foreach(char letter in rainbowArray)
			{
				if (i<15) {
					Console.ForegroundColor = colors[i];
					Console.Write(letter);
					i++;
				}
				else {
					i = 1;
					Console.ForegroundColor = colors[i];
					Console.Write(letter);
				}
			}
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
		}
  }
}
  