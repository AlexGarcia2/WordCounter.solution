using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace Wordcounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    //test the data type of the model
    [TestMethod]
    public void Index_HasCorrectModelType_WordList()
    {
      //Arrange
      ViewResult indexView = new WordCounterController().Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<WordFinder>));
    }

//test the action of the Controller
    [TestMethod]
  public void Create_RedirectsToCorrectAction_Index()
  {
      //Arrange
      WordCounterController controller = new WordCounterController();

      RedirectToActionResult actionResult = controller.Create("to","to be or not to be ") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
  }
//   // test for the data type for controller
//   [TestMethod]
//     public void Create_ReturnsCorrectActionType_RedirectToActionResult()
//     {
//         //Arrange
//         CitiesController controller = new CitiesController();
//
//         //Act
//         IActionResult view = controller.Create("Walk the dog","this","that");
//
//         //Assert
//         Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
//     }
  }
}
