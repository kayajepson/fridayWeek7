using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordsControllerTest
  {
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
      IActionResult view = controller.Create("Portland");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }
    //
    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      WordsController controller = new WordsController();
      RedirectToActionResult actionResult = controller.Create("Portland") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
  }
}
