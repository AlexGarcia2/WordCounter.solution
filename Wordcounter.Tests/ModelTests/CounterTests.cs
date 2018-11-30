using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordFinderTest
  {

    [TestMethod]
    public void WordCompare_ReturnComparisonOFString_True()
    {
      string testString = "A";
      string testWord = "A";
      WordFinder newFinder = new WordFinder (testWord, testString);

      bool result = newFinder.WordCompare(testString);

      Assert.AreEqual(true, result);
    }

    // [TestMethod]
    // public void WordCompare_ReturnComparisonOfTthreeLetterString_true()
    // {
    //   string threeWordTestString = "cat";
    //   string threeWordTestWord = "cat";
    //   WordFinder newFinder = new WordFinder (twoWordTestWord, twoWordTestString);
    //
    //   string result = newFinder.WordCompare(threeWordTestString);
    //
    //   Assert.AreEqual(true, result);
    // }

    // [TestMethod]
    // public void ElementCompare_ReturnIndexOfGivenString_True()
    // {
    //   string testString = "is there any one in there";
    //   string testWord = "there";
    //   WordFinder newFinder = new WordFinder(testWord, testString);
    //
    //   bool result = newFinder.ElementCompar();
    //
    //   Assert.AreEqual(true, result);
    // }
    // [TestMethod]
    // public void RepeatCounter_ReturnCorrectNumberOfInstancesOfGivenWordInString_int()
    // {
    //   string testString = "is there any one in there";
    //   string testWord = "there";
    //   WordFinder newFinder = new WordFinder(testWord, testString);
    //
    //   int result = newFinder.RepeatCounter();
    //
    //   Assert.AreEqual(2, result);
    // }
  }
}
