using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LunchBuddy.Restaurant
{
    class Restaurants
    {

        public string Name { get; set; }

        
        public static string RandoRestaurant()
        {
            List<string> RestaurantList = new List<string>() {"Joyland", "CFA", "Vui's","Redhead STranger","Nectar", "Hawker's", "Mas Tacos" };
            Random rnd = new Random();
            int Index = rnd.Next(RestaurantList.Count);
            var RandoRest = RestaurantList[Index];
            return RandoRest;
 
        }

        public Restaurants()
        {
            Name = RandoRestaurant();
        }

    }
}
