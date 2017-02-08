using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _placeName;
    private static List<string> _destinations = new List<string> {};

    public Place (string placeName)
    {
      _placeName = placeName;
    }
    public string GetplaceName()
    {
      return _placeName;
    }
    public void SetplaceName(string newplaceName)
    {
      _placeName = newplaceName;
    }
    public static List<string> GetAll()
    {
      return _destinations;
    }
    public void Save()
    {
      _destinations.Add(_placeName);
    }
  }
}
