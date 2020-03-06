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
    public void RepeatCounter_VerifyInputStringWithinRepeatCounter_String()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      //Act
      repeatCounter.AddSentance("I took the cat for a walk");
      //Assert
      Assert.AreEqual(" I took the cat for a walk ", repeatCounter.SentanceInput);

    }
    [TestMethod]
    public void SentanceToArray_IntakesUserSentanceAndReturnsArrayOfWords_WordString()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      repeatCounter.AddSentance("I took the cat for a walk");
      //Act
      string[] sentanceArray = RepeatCounter.SentanceToArray(repeatCounter.SentanceInput);
      //Assert
      Assert.AreEqual("took", sentanceArray[2]);
    }
    [TestMethod]
    public void ContainsWord_SearchesForOccuranceUserWordInSentanceArray_True()
    {
      //Arrange
      RepeatCounter repeatCounter = new RepeatCounter();
      repeatCounter.AddWord("walk");
      repeatCounter.AddSentance("I took my cat Walker for a walk");
      //Act
      bool result = repeatCounter.ContainsWord();
      //Assert
      Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void WordRepeatCount_TotalsNumberOfTimesUserWordOccursInSentanceArray_integer()
    {
      //Arrange
      //Act
      //Assert
    }
  } 

}