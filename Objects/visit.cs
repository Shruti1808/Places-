using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _placeName;
    private string _cityName;
    private static List<string> _destinations = new List<string> {};

    public Place (string placeName, string cityName)
    {
      _placeName = placeName;
      _cityName = cityName;
    }
    public string GetplaceName()
    {
      return _placeName;
    }
    public void SetplaceName(string newplaceName)
    {
      _placeName = newplaceName;
    }
    public string GetcityName()
    {
      return _cityName;
    }
    public void SetcityName(string newcityName)
    {
      _cityName = newcityName;
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
