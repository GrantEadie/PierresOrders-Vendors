using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakerySupply.Models;

namespace BakerySupply.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()

    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetItem_ReturnsItem_String()
    { //arange
      string item = "bread";
      Order newOrder = new Order(item);
      //Act
      string result = newOrder.Item;
      //Assert
      Assert.AreEqual(item, result);
    }
    [TestMethod]
    public void SetItem_SetItem_String()
    {
      //Arrange
      string item = "pastry";
      Order newOrder = new Order(item);

      //Act
      string updatedItem = "bread";
      newOrder.Item = updatedItem;
      string result = newOrder.Item;

      //Assert
      Assert.AreEqual(updatedItem, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string item = "bread";
      Order newOrder = new Order(item);

      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order () {
      //Arrange
      string item01 = "bread";
      string item02 = "lots of bread";
      Order newOrder1 = new Order (item01);
      Order newOrder2 = new Order (item02);

      //Act
        Order result = Order.Find(2);

      //Assert
      Assert.AreEqual (newOrder2, result);
    }

  }
}