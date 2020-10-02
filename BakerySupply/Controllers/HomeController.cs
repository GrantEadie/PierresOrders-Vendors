using Microsoft.AspNetCore.Mvc;

namespace BakerySupply.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}