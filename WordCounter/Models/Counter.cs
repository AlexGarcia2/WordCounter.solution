using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class WordFinder
  {
    private string _inputWord;
    private string _inputString;
    private List<string> _result;
    private List<int> _wordCount;


    public WordFinder (string newInputWord, string newInputString, List<string> newResult, List<int> newCount)
    {
      _inputWord = newInputWord;
      _inputString = newInputString;
      _result = newResult;
      _wordCount = newCount;
    }
    public string GetInputWord()
    {
      return _inputWord;
    }
    public void SetInputWord(string newInputWord)
    {
       _inputWord = newInputWord;
    }

    public List<string> GetResult()
    {
      return _result;
    }

    public void SetResult(List<string> newResult)
    {
       _result = newResult;
    }

    public List<int> GetCount()
    {
      return _wordCount;
    }
    public void SetCount(List<int> newCount)
    {
       _wordCount = newCount;
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
    public List<string> FindMatchingWords(List<string> newResult)
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

    // public int RepeatCounter()
    // {
    //   List<int> wordCount = new List<int>{};
    //   wordCount = FindMatchingWords();
    //   int count = wordCount.Count;
    //    wordCount.Add(count);
    //    return wordCount;
    // }
  }
}
