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

  }  
}