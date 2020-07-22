using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouHaveBeen;
using PlacesYouHaveBeen.Models;

namespace PlacesYouHaveBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
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
  }
}