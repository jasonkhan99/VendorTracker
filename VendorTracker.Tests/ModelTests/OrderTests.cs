using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
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
    public void GetDate_ReturnsDate_String()
    {
      string date = "7/24/2020";
      Order newOrder = new Order(date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetDate_String()
    {
      string date = "7/24/2020";
      Order newOrder = new Order(date);
      string updatedDate = "8/3/2020";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrdersList()
    {
      string date01 = "7/24/2020";
      string date02 = "8/3/2020";
      Order newOrder1 = new Order(date01);
      Order newOrder2 = new Order(date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string date = "7/24/2020";
      Order newOrder = new Order(date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string date01 = "7/24/2020";
      string date02 = "8/3/2020";
      Order newOrder1 = new Order(date01);
      Order newOrder2 = new Order(date02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }

  }
}