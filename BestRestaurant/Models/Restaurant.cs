using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string HoursOfOperation { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }

}