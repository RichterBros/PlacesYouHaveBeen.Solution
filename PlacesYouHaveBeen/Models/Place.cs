using System.Collections.Generic;

namespace PlacesYouHaveBeen.Models
{
  public class Place
  {
    public string PlaceName {get; set;}

    private static List<Place> _places = new List<Place>();

    public Place(string name)
    {
      PlaceName = name;
      _places.Add(this);
    }
    public static List<Place> GetAll()
    {
      return _places;
    }

    public static void ClearAll()
    {
      _places.Clear();
    }

  }
}