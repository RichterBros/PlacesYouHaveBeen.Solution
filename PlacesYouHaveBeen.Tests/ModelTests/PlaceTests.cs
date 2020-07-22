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
      Place newPlace = new Place("Portland", 3, "A lot of bridges");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetPlace_ReturnsPlaceName_String()
    {
      string cityName = "Portland";
      Place place = new Place(cityName, 3, "A lot of bridges");
      string result = place.PlaceName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetPlace_SetPlaceName_String()
    {
      string cityName = "Portland";
      Place place = new Place(cityName,  3, "A lot of bridges");

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
      Place place1 = new Place(cityName1,  3, "A lot of bridges");
      Place place2 = new Place(cityName2, 3, "A lot of rain");
      List<Place> newList = new List<Place> { place1, place2 };

      List<Place> result = Place.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      Place place = new Place("Seattle", 3, "A lot of rain");
      int result = place.Id;

      Assert.AreEqual(1, result);
    }  

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      string cityName1 = "Portland";
      string cityName2 = "Seattle";
      Place place1 = new Place(cityName1,  3, "A lot of bridges");
      Place place2 = new Place(cityName2, 3, "A lot of rain");

      Place result = Place.Find(2);

      Assert.AreEqual(place2, result);
    }

  }
}