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
      public void GetId_ItemsInstantiateWithAnIdReturns_Int()
      {
        //Arrange
        Words myWords = new Words("cat", "the cat in the hat");

        //Act
        int result = myWords.GetId();

        //Assert
        Assert.AreEqual(1, result);
      }

    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      //Arrange
      Words myWords = new Words("cat", "the cat in the hat");
      WordsController controller = new WordsController();

      //Act
      ActionResult showView = controller.Show(1);

      //Assert
      Assert.IsInstanceOfType(showView, typeof(ViewResult));
    }


    [TestMethod]
     public void RepeatCounter_ReturnsOne_IntOne()
     {
         // Arrange
         Words myWords = new Words("cat", "the cat in the hat");

         // Assert
         Assert.AreEqual(1, myWords.RepeatCount);
     }

    [TestMethod]
    public void Index_HasCorrectModelType_WordsList()
    {
      //Arrange
      Words myWords = new Words("cat", "the cat in the hat");
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
      // Words myWords = new Words("cat", "the cat in the hat");
      WordsController controller = new WordsController();

      //Act
      IActionResult view = controller.Create("cat", "the cat in the hat");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }
    //
    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      WordsController controller = new WordsController();
      RedirectToActionResult actionResult = controller.Create("cat", "the cat in the hat") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
  }
}
