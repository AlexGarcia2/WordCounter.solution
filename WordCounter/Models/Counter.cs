using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class WordFinder
  {
    private string _inputWord;
    private string _inputString;
    public List<string> _words;


    public WordFinder (string inputWord , string inputString, List<string> words)
    {
      _inputWord = inputWord;
      _inputString = inputString;
      _words = words;
    }
    public string GetInputWord()
    {
      return _inputWord;
    }
    public void SetInputWord(string newInputWord)
    {
       _inputWord = newInputWord;
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
    public int FindMatchingWords()
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
        words = result;

      int output = this.RepeatCounter();

      return output;
    }

    public int RepeatCounter()
    {
      List<string> result = this.words;
      int count = result.Count;
      return count;
    }
  }
}
