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
      ShowWordCount(repeatCounter);
      ShowGoodbye();
    }
    public static void ShowGreeting()
    {
      RainbowPrint("Welcome to my Console Application!");
    }
    public static void ShowGoodbye()
    {
      RainbowPrint("Goodbye! Thanks for using my application");
    }
    public static string GetWord()
    {
      Console.WriteLine("Enter a word: ");
      string word = Console.ReadLine();
      return word;
    }
    public static string GetSentance()
    {
      Console.WriteLine("Enter a sentance: ");
      string sentance = Console.ReadLine();
      return sentance;
    }
    public static void ShowWordCount(RepeatCounter repeatCounter)
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
    public static void RainbowPrint(string text)
		{
			char[] rainbowArray = text.ToCharArray();
			ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
			int i = 1;
			foreach(char letter in rainbowArray)
			{
				if (i == 1 || i == 2 || i == 4  || i == 5|| i == 6) {
					Console.ForegroundColor = colors[i];
					Console.Write(letter);
					i++;
				} 
        else if ( i >= 15 ) 
        {
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
  