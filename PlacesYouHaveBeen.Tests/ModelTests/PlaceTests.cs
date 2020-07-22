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
  }
}