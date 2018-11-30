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
}
