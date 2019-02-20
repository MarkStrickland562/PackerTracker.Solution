using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class TrackerTest
  {
    [TestMethod]
    Verify that an instance of ItemName can be created.
    public void ItemNameConstructor_CreatesInstanceOfItemName()
    {
      //Arrange
      string myItemName = "tent";
      Tracker newItemName = new Tracker(myItemName);

      //Act
      Type myItemNameType = typeof(ItemName);
      Type newItemNameType = newItemName.GetType();

      //Assert
      Assert.AreEqual(myItemNameType, newItemNameType);
    }

    [TestMethod]
    // Verify that the ItemName getter method returns the value of the ItemName.
    public void GetItemName_ReturnsItemName_String()
    {
      //Arrange
      string myItemName = "tent";
      Tracker newItemName = new Tracker(myItemName);

      //Act
      string result = newItemName.GetItemName();

      //Assert
      Assert.AreEqual(myItemName, result);
    }

    [TestMethod]
    // Verify that the ItemName setter method can update the value of the ItemName.
    public void SetItemName_SetItemName_String()
    {
      //Arrange
      string myItemName = "seattle";
      Tracker newItemName = new Tracker(myItemName);

      //Act
      string updatedItemName = "portland";
      newItemName.SetItemName(updatedItemName);
      string result = newItemName.GetItemName();

      //Assert
      Assert.AreEqual(updatedItemName, result);
    }



  }
}
