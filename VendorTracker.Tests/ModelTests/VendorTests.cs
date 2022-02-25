using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test Vendor";
      string description = "test description";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "test Vendor";
      string description = "test description";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
      {
        string name01 = "test one";
        string name02 = "test two";
        string description01 = "test description one";
        string description02 = "test description two";
        Vendor newVendor1 = new Vendor(name01, description01);
        Vendor newVendor2 = new Vendor(name02, description02);
        List<Vendor> vendorList = new List<Vendor> {newVendor1, newVendor2};

        List<Vendor> result = Vendor.GetAll();

        CollectionAssert.AreEqual(vendorList, result);
      }
      [TestMethod]
      public void FindVendor_ReturnsCorrectVendorById_Vendor()
      {
        string name01 = "test one";
        string name02 = "test two";
        string description01 = "test description one";
        string description02 = "test description two";
        Vendor newVendor1 = new Vendor(name01, description01);
        Vendor newVendor2 = new Vendor(name02, description02);
        List<Vendor> vendorList = new List<Vendor> {newVendor1, newVendor2};

        Vendor desiredVendor = newVendor2;
        Vendor result = Vendor.Find(2);

        Assert.AreEqual(desiredVendor, result);
      }
    
  }
}