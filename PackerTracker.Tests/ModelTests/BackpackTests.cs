using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class BackpackTests : IDisposable
  {

    public void Dispose()
    {
      Backpack.ClearAll();
    }

    [TestMethod]
    public void BackpackConstructor_CreatesInstanceOfBackpack_Backpack()
    {
      Backpack newBackpack = new Backpack("test");
      Assert.AreEqual(typeof(Backpack), newBackpack.GetType());
    }

    [TestMethod]
    public void GetThing_ReturnsThing_String()
    {
      //Arrange
      string thing = "matches";

      //Act
      Backpack newBackpack = new Backpack(thing);
      string result = newBackpack.Thing;

      //Assert
      Assert.AreEqual(thing, result);
    }

    [TestMethod]
    public void GetAll_ReturnsBackpack_BackpackList()
    {
      //Arrange
      string thing01 = "matches";
      string thing02 = "camp stove";
      Backpack newBackpack1 = new Backpack(thing01);
      Backpack newBackpack2 = new Backpack(thing02);
      List<Backpack> newList = new List<Backpack> { newBackpack1, newBackpack2 };

      //Act
      List<Backpack> result = Backpack.GetAll();
      // Console.WriteLine($"Expected: {newList.Count}");
      // Console.WriteLine($"Result: {result.Count}");
      
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}