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
      public void Create_viewtoindex_Index()
      {
        //Arrange
        List<string> emptyList = new List<string>{};
        WordCounterController controller = new WordCounterController();
        ViewResult actionResult = controller.Create("to","to be or not to be ",emptyList) as ViewResult;

        //Act
        string result = actionResult.ViewName;

        //Assert
        Assert.AreEqual(result, "Index");
      }

  // test for the data type for controller
  [TestMethod]
    public void Create_ReturnsCorrectActionType_ViewResult()
    {
        //Arrange
        WordCounterController controller = new WordCounterController();
        List<string> emptyList = new List<string>{};
        //Act
        IActionResult view = controller.Create("to","to be or not to be ",emptyList);

        //Assert
        Assert.IsInstanceOfType(view, typeof(ViewResult));
    }
  }
}
