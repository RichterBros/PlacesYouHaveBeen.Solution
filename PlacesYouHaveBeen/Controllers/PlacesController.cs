using Microsoft.AspNetCore.Mvc;
using PlacesYouHaveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouHaveBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string placeName)
    {
      Place newPlace = new Place(placeName);
      return RedirectToAction("Index");
    }
  }
}