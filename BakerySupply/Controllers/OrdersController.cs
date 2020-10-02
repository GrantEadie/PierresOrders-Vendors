using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BakerySupply.Models;

namespace BakerySupply.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{VendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpGet("/vendor/{categoryId}/orders/{itemId}")]
    public ActionResult Show(int orderId, int vendorId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("Order", order);
      model.Add("Vendor", vendor);
      return View(model);
    }
    
    [HttpPost("/Orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
  }
}