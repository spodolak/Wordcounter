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
      repeatCounter.AddWordAddSentance("walk","");
      //Assert
      Assert.AreEqual("walk", repeatCounter.WordInput);
    }
    [TestMethod]
    public void RepeatCounter_VerifyInputStringWithinRepeatCounter_String()
    {
      //Arrange
      //Act
      //Assert
    }
    [TestMethod]
    public void SentanceToArray_IntakesUserSentanceAndReturnsArrayOfWords_WordString()
    {
      //Arrange
      //Act
      //Assert
    }
    [TestMethod]
    public void ContainsWord_SearchesForOccuranceUserWordInSentanceArray_True()
    {
      //Arrange
      //Act
      //Assert
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