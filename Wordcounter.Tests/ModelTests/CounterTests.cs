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
    public void WordCompare_ReturnComparisonOFString_String()
    {
      string testString = "A";
      string testWord = "A";
      WordFinder newFinder = new WordFinder (testWord, testString);

      string result = newFinder.WordCompare();

      Assert.AreEqual(testWord, result);
    }

    [TestMethod]
    public void CompareTwo_ReturnComparisonOfTwoLetterString_String()
    {
      string twoWordTestString = "is there any one in there";
      string twoWordTestWord = "is";
      WordFinder newFinder = new WordFinder (twoWordTestWord, twoWordTestString);

      string result = newFinder.CompareTwo();

      Assert.AreEqual(twoWordTestWord, result);
    }

    [TestMethod]
    public void ElementCompare_ReturnIndexOfGivenString_True()
    {
      string testString = "is there any one in there";
      string testWord = "there";
      WordFinder newFinder = new WordFinder(testWord, testString);

      bool result = newFinder.ElementCompar();

      Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void RepeatCounter_ReturnCorrectNumberOfInstancesOfGivenWordInString_int()
    {
      string testString = "is there any one in there";
      string testWord = "there";
      WordFinder newFinder = new WordFinder(testWord, testString);

      int result = newFinder.RepeatCounter();

      Assert.AreEqual(2, result);
    }
    using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class WordFinder
  {
    private string _inputWord;
    private string _inputString;

    public WordFinder (string inputWord , string inputString)
    {
      _inputWord = inputWord;
      _inputString = inputString;
    }
    public bool WordCompare(string wordInSentence)
    {
      if(_inputWord.ToLower() == wordInSentence.ToLower())
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public List<string> FindMatchingWords()
    {
      List<string> result = new List<string>{};
      string[] array_inputString = _inputString.Split(' ');

      foreach (string word in array_inputString)
      {
        bool isAMatch = WordCompare(word);
        if(isAMatch)
        {
          result.Add(word);
        }
      }
      return result;
    }

    public int RepeatCounter()
    {
      List<string> result = FindMatchingWords();
      int count = result.Count;
      return count;
    }
  }
  [TestMethod]
  public void WordCompare_ReturnComparisonOFString_True()
  {
    string testString = "A";
    string testWord = "A";
    WordFinder newFinder = new WordFinder (testWord, testString);

    string result = newFinder.WordCompare(testString);

    Assert.AreEqual(true, result);
  }



  }
}
