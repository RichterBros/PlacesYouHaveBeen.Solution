using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesYouHaveBeen;
using PlacesYouHaveBeen.Models;
using System;

namespace PlacesYouHaveBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Portland");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetPlace_ReturnsPlaceName_String()
    {
      string cityName = "Portland";
      Place place = new Place(cityName);
      string result = place.PlaceName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetPlace_SetPlaceName_String()
    {
      string cityName = "Portland";
      Place place = new Place(cityName);

      string newCityName = "Seattle";
      place.PlaceName = newCityName;
      string result = place.PlaceName;

      Assert.AreEqual(newCityName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlacesList()
    {
      List<Place> newList = new List<Place>();
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllPlaces_PlacesList()
    {
      string cityName1 = "Portland";
      string cityName2 = "Seattle";
      Place place1 = new Place(cityName1);
      Place place2 = new Place(cityName2);
      List<Place> newList = new List<Place> { place1, place2 };

      List<Place> result = Place.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

  }
}