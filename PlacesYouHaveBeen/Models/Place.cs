using System.Collections.Generic;

namespace PlacesYouHaveBeen.Models
{
  public class Place
  {
    public string PlaceName {get; set;}
    public int NumberOfDays {get; set;}
    public string Description {get; set;}
    public int Id{get;}
    private static List<Place> _places = new List<Place>();

    public static Place Find(int searchId)
    {
      return _places[searchId - 1];
    }

    public Place(string name, int days, string description)
    {
      PlaceName = name;
      NumberOfDays = days;
      Description = description;
      _places.Add(this);
      Id = _places.Count;
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