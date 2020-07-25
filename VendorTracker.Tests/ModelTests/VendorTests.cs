using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test Vendor", "Test Address");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      string address = "Test Address";
      Vendor newVendor = new Vendor(name, address);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void Getaddress_Returnsaddress_String()
    {
      string name = "Test Vendor";
      string address = "Test Address";
      Vendor newVendor = new Vendor(name, address);
      string result = newVendor.Address;
      Assert.AreEqual(address, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string address = "Test Address";
      Vendor newVendor = new Vendor(name, address);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Cafe";
      string name02 = "Coffee Shop";
      string address01 = "Broadway";
      string address02 = "5th";
      Vendor newVendor1 = new Vendor(name01, address01);
      Vendor newVendor2 = new Vendor(name02, address02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Cafe";
      string name02 = "Coffee Shop";
      string address01 = "Broadway";
      string address02 = "5th";
      Vendor newVendor1 = new Vendor(name01, address01);
      Vendor newVendor2 = new Vendor(name02, address02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string date = "7/24/2020";
      string address = "Broadway";
      object items = (1, "pastry");
      Order newOrder = new Order(date, items);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, address);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
