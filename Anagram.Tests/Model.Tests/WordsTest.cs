using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Anagram;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest : IDisposable
  {
    [TestMethod]
    public void SetWord_ReturnsWord_True()
    {
      //Arrange
      string anagramWord = "bread";
      Anagram newWord = new Anagram();

      //Act
      newWord.SetWord(anagramWord);
      string result = newWord.GetWord();

      //Assert
      Assert.AreEqual(anagramWord, result);
    }

    [TestMethod]
    public void SortWord_ReturnsSortedArray_True()
    {
      //Arrange
      string testWord = "dog";
      char[] sortedArray = {'d','g','o'};
      Anagram newWord = new Anagram();


      //Act
      newWord.SetWord(testWord);
      char[] resultArray = newWord.SortWord();

      //Assert
      CollectionAssert.AreEqual(sortedArray, resultArray);
    }

    [TestMethod]
    public void IsAnagram_ComparesTwoArrays_True()
    {
      //Arrange
      char[] word1 = {'d','g','o'};
      char[] word2 = {'d','g','o'};

      //Act
      bool result = Anagram.IsAnagram(word1, word2);

      //Assert
      Assert.AreEqual(true, result);
    }

    public void Dispose()
    {

    }
  }
}
