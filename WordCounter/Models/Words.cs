using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Words
  {
    public string UserWord {get; set;}
    public int Id {get; set;}
    public string UserSentence {get; set;}
    public int RepeatCount {get; set;}
    private static List<Words> _instances = new List<Words> {};

    public Words (string userWord, string userSentence)
    {
      UserWord = userWord.ToLower();
      UserSentence = userSentence.ToLower();
      _instances.Add(this);
      Id = _instances.Count;
      RepeatCount = RepeatCounter(UserWord, UserSentence);
      // RepeatCount.RepeatCounter(string UserWord, string UserSentence);
    }

    public int RepeatCounter (string userWord, string userSentence)
    {
      UserWord = userWord.ToLower();
      UserSentence = userSentence.ToLower();
      string[] sentenceList = UserSentence.Split(" ");
      int timesAppeared = 0;
      foreach (string i in sentenceList)
      {
        if (i == userWord)
        {
          timesAppeared += 1;
        }
        else
        {
          timesAppeared += 0;
        }
      }
      return timesAppeared;
    }


    public bool SentenceContainsWord()
    {
      string[] sentenceArray = UserSentence.Split(" ");
      if (((IList<string>)sentenceArray).Contains(UserWord))
      {
        return true;
      }
      else
      {
        return false;
      }
    }


    // public bool RemoveNonAlphabet(char userInput)
    // {
    //   return Char.IsLetter(userInput);
    // }


    public int GetId()
    {
      return Id;
    }

    public static List<Words> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Words Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
