using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Words
  {
    public string UserWord {get; set;}
    public int Id {get; set;}
    public string UserSentence {get; set;}
    private static List<Words> _instances = new List<Words> {};

    public Words (string userWord, string userSentence)
    {
      UserWord = userWord;
      UserSentence = userSentence;
      _instances.Add(this);
      Id = _instances.Count;
    }


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
