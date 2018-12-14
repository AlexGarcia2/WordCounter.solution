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
      List<string> emptyList = new List<string>{};
      WordFinder newFinder = new WordFinder (testWord, testString,emptyList);

      bool result = newFinder.WordCompare(testString);

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void WordCompare_ReturnComparisonOfTthreeLetterString_true()
    {
      string threeWordTestString = "Cat";
      string threeWordTestWord = "cat";
      List<string> emptyList = new List<string>{};
      WordFinder newFinder = new WordFinder (threeWordTestWord, threeWordTestString,emptyList);

      bool result = newFinder.WordCompare(threeWordTestString);

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void FindMatchingWords_ReturnEmpty_list()
    {
      string threeWordTestString = "";
      string threeWordTestWord = "";
      List<string> testWordList = new List<string>{};

      WordFinder newFinder = new WordFinder(threeWordTestWord,threeWordTestString,testWordList);

      List<string> result = newFinder.GetWordList();
      Console.WriteLine(result);

      CollectionAssert.AreEqual(testWordList, result);
    }
    [TestMethod]
    public void FindMatchingWords_ReturnMatchesOfGivenString_list()
    {
      string testString = "is there any one in";
      string testWord = "there";
      List<string> testWordList = new List<string>{testWord};
      WordFinder newFinder = new WordFinder(testWord, testString,testWordList);

      List<String> result = newFinder.GetWordList();

      CollectionAssert.AreEqual(testWordList, result);
    }
    [TestMethod]
    public void RepeatCounter_ReturnCorrectNumberOfInstancesOfGivenWordInString_int()
    {
      string testString = "is there any one in there";
      string testWord = "there";
      List<string> emptyList = new List<string>{};
      WordFinder newFinder = new WordFinder(testWord, testString,emptyList);

      int result = newFinder.RepeatCounter();

      Assert.AreEqual(0, result);
    }
  }
}
