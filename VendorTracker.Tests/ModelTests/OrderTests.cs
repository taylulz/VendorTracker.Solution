using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Tests
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
      string newOrderTitle = "Lindas b&b";
      string newOrderDescription = "Lindas b&b Description";
      string newOrderDate = "12-18-20";
      int newOrderPrice = 100;
      Order newOrder = new Order(newOrderTitle, newOrderDescription, newOrderDate, newOrderPrice);
      Assert.AreEqual(newOrderTitle, newOrder.Title);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfInstantiatedOrderObjs_OrderInstances()
    {
      string newOrderTitle = "Lindas b&b";
      string newOrderDescription = "Lindas b&b Description";
      string newOrderDate = "12-18-20";
      int newOrderPrice = 100;
      Order newOrder = new Order(newOrderTitle, newOrderDescription, newOrderDate, newOrderPrice);
      List<Order> newList = new List<Order> { newOrder };
      List<Order> getResults = Order.GetAll();
      CollectionAssert.AreEqual(newList, getResults);
    }

    [TestMethod]
    public void GetId_OrderObjsInstantiatedWithIdAndGetterReturnsId_Int()
    {
      Order newOrder = new Order("newOrderTitle", "newOrderDescription", "newOrderDate", 10);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order newOrderOrder1 = new Order("newOrderTitle", "newOrderDescription", "newOrderDate", 10);
      Order newOrder2 = new Order("newOrderTitle2", "newOrderDescription2", "newOrderDate2", 10);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}