using Nancy;
using Places.Objects;

namespace Places
{
  public class HomeModule : NancyModule
  {
     public HomeModule()
     {
       Get["/"]= _ => View["add_places.cshtml"];
      //  Get["/visit_Places"] = _ => {
      //    Place newPlace = new Place(Request.Query["new-place"]);
      //    return View["view_places.cshtml", newPlace];
      //  };
       Post["/visit_Places"] = _ => {
        Place newPlace = new Place (Request.Form["new-place"], Request.Form["new-city"]);
        newPlace.Save();
        return View["view_places.cshtml", newPlace];
      };
     }
  }
}
