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
      Order newOrder = new Order("Name", "test description", "test date", 20);

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      Order newOrder = new Order("Name", "test description", "test date", 20);

      int result = newOrder.Id;

      Assert.AreEqual(1, newOrder.Id);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order newOrder01 = new Order("Name1", "test description1", "test date1", 20);
      Order newOrder02 = new Order("Name2", "test description2", "test date2", 20);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder02, result);
    }
  }
}