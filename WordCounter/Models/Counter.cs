using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class WordFinder
  {
    private string _inputWord;
    private string _inputString;
    private List<string> _result;
    private List<string> _wordCount;


    public WordFinder (string inputWord , string inputString)
    {
      _inputWord = inputWord;
      _inputString = inputString;
    }
    public string GetInputWord()
    {
      return _inputWord;
    }
    public void SetInputWord(string newInputWord)
    {
       _inputWord = newInputWord;
    }

    public string GetResult()
    {
      return _result;
    }

    public void SetResult(string newResult)
    {
       _result = newResult;
    }

    public string GetCount()
    {
      return _wordCount;
    }
    public void SetCount(string newCount)
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
    public List<string> FindMatchingWords()
    {

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
      _wordCount = FindMatchingWords();
      int count = wordCount.Count;
      return count;
    }
  }
}
