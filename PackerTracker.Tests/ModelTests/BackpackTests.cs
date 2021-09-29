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

    // [TestMethod]
    // public void Find_FindItemsWithTheId_Int()
    // {
    //   //Arrange - create an item so we have some data to test
    //   string description01 = "Walk the dog";
    //   Item newItem = new Item(description01);

    //   //Act - call the function we're testing
    //   Item foundItem = Item.Find(1);
    //   int resultId = foundItem.Id;
    //   int expectedId = newItem.Id;

    //   //Assert
    //   Assert.AreEqual(expectedId, resultId);
    // }
  }
}