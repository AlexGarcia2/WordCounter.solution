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

    [TestMethod]
    public void WordCompare_ReturnComparisonOfTthreeLetterString_true()
    {
      string threeWordTestString = "Cat";
      string threeWordTestWord = "cat";

      WordFinder newFinder = new WordFinder (threeWordTestWord, threeWordTestString);

      bool result = newFinder.WordCompare(threeWordTestString);

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void FindMatchingWords_ReturnEmpty_list()
    {
      string threeWordTestString = "";
      string threeWordTestWord = "";
      List<string> testWordList = new List<string>{};

      WordFinder newFinder = new WordFinder(threeWordTestWord,threeWordTestString);

      List<string> result = newFinder.FindMatchingWords();
      Console.WriteLine(result);

      CollectionAssert.AreEqual(testWordList, result);
    }
    [TestMethod]
    public void FindMatchingWords_ReturnMatchesOfGivenString_list()
    {
      string testString = "is there any one in";
      string testWord = "there";
      List<string> testWordList = new List<string>{testWord};
      WordFinder newFinder = new WordFinder(testWord, testString);

      List<String> result = newFinder.FindMatchingWords();

      CollectionAssert.AreEqual(testWordList, result);
    }
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
