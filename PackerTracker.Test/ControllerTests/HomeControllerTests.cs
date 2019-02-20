using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Controllers;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
    //Arrange
    HomeController controller = new HomeController();

    //Act
    ActionResult indexView = controller.Index();

    //Assert
    Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
      public void Index_HasCorrectModelType_PackerTrackerList()
      {
      //Arrange
      ViewResult indexView = new HomeController().Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Tracker>));
      }

      [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      PackerTrackerController controller = new PackerTrackerController();

      //Act
      IActionResult view = controller.Create("tent");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      PackerTrackerController controller = new PackerTrackerController();
      RedirectToActionResult actionResult = controller.Create("tent") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }

  }
}
