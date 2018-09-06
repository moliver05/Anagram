using System;
using System.Collections.Generic;

namespace Anagram
{
  public class Anagram
  {
    private string _word;

    public void SetWord(string input)
    {
      _word = input;
    }

    public string GetWord()
    {
      return _word;
    }

    public char[] SortWord()
    {
      string word = GetWord();
      char[] wordArray = word.ToCharArray();
      Array.Sort(wordArray);
      return wordArray;
    }

    public static bool IsAnagram(char[] anagram, char[] test)
    {
      if (anagram == test)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

  public class Program
  {
    static void Main()
    {
    Console.WriteLine("Enter a word");
    string anagramWord = Console.ReadLine();
    Anagram newAnagram = new Anagram();
    newAnagram.SetWord(anagramWord);
    char[] sortedAnagramArray = newAnagram.SortWord();


    Console.WriteLine("Enter a second word and I will check to see if it is an anagram of the first word.");
    string testWord = Console.ReadLine();
    Anagram newTest = new Anagram();
    newAnagram.SetWord(testWord);
    char[] sortedTestArray = newTest.SortWord();

    bool result = Anagram.IsAnagram(sortedAnagramArray, sortedTestArray);
    Console.WriteLine(result);
    }
  }
}
