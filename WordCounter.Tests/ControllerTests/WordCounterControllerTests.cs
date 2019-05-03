using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {

    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      //Arrange
      WordCounterController controller = new WordCounterController();

      //Act
      ActionResult showView = controller.Show();

      //Assert
      Assert.IsInstanceOfType(showView, typeof(ViewResult));
    }

    [TestMethod]
    public void SentenceContainsWord_UserSentenceContainsUserWord_True()
    {
      WordCountGen newComparison = new WordCountGen();
      Assert.AreEqual(true, newComparison.SentenceContainsWord());
    }

    [TestMethod]
    public void WordInSentence_RepeatCounter()
    {
      WordCountGen newComparison = new WordCountGen();
      Assert.AreEqual(2, newComparison.RepeatCounter("cat"));
    }


    [TestMethod]
      public void GetId_ItemsInstantiateWithAnIdReturns_Int()
      {
        //Arrange
        string word = "cat";
        Word newWord = new Word(word);

        //Act
        int result = newWord.GetId();

        //Assert
        Assert.AreEqual(1, result);
      }

      [TestMethod]
        public void GetId_ItemsInstantiateWithAnIdReturns_Int()
        {
          //Arrange
          string word = "cat";
          Word newWord = new Word(word);

          //Act
          int result = newWord.GetId();

          //Assert
          Assert.AreEqual(1, result);
        }

    [TestMethod]
    public void Index_HasCorrectModelType_WordsList()
    {
      //Arrange
      WordsController controller = new WordsController();
      ViewResult indexView = controller.Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Words>));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      WordsController controller = new WordsController();

      //Act
      IActionResult view = controller.Create("Cat");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }
    //
    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      WordsController controller = new WordsController();
      RedirectToActionResult actionResult = controller.Create("cat") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
  }
}
