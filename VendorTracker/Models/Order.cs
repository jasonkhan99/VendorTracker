using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string date)
    {
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string Date = "7/24/2020";
      Item newItem = new Item(Date);
      string result = newItem.Date;
      Assert.AreEqual(date, result);
    }

  }  
}