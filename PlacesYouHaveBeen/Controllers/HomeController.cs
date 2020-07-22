using Microsoft.AspNetCore.Mvc;
using PlacesYouHaveBeen.Models;

namespace PlacesYouHaveBeen.Controllers
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