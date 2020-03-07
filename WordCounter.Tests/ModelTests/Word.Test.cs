using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Test
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void RepeatCounter_VerifyInputWordWithinRepeatCounter_String()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      repeatCounter.AddWord("walk");
      //Assert
      Assert.AreEqual("walk", repeatCounter.WordInput);
    }
    [TestMethod]
    public void RepeatCounter_FormatAndVerifyInputStringWithinRepeatCounter_String()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      repeatCounter.AddSentence("I took the cat for a walk");
      //Assert
      Assert.AreEqual(" I took the cat for a walk ", repeatCounter.SentenceInput);

    }
    [TestMethod]
    public void SentenceToArray_IntakesUserSentenceAndReturnsArrayOfWords_WordString()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      repeatCounter.AddSentence("I took the cat for a walk");
      //Act
      string[] sentenceArray = RepeatCounter.SentenceToArray(repeatCounter.SentenceInput);
      //Assert
      Assert.AreEqual("walk", sentenceArray[7]);
    }
    [TestMethod]
    public void ContainsWord_SearchesForOccuranceUserWordInSentenceArray_True()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      repeatCounter.AddWord("walk");
      repeatCounter.AddSentence("I took my cat Walker for a walk");
      //Act
      bool result = repeatCounter.ContainsWord();
      //Assert
      Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void WordRepeatCount_TotalsNumberOfTimesUserWordOccursInSentenceArray_integer()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      repeatCounter.AddWord("walk");
      repeatCounter.AddSentence("I took my cat Walker for a walk!");
      //Act
      int wordCount = repeatCounter.WordRepeatCount();
      //Assert
      Assert.AreEqual(1, wordCount);
    }
    [TestMethod]
    public void IsAWord_ChecksToSeeIfUserWordIsInEnglishDictionary_true()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      repeatCounter.AddWord("date");
      //Act
      bool wordResult = RepeatCounter.IsAWord(repeatCounter.WordInput);
      //Assert
      Assert.AreEqual(true, wordResult);
    }
  } 

}