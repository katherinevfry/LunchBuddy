using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LunchBuddy.Restaurant
{
    class Restaurants
    {
        //create a Name
        private string Name { get; set; }

        //Write the logic to generate a random restaurant. Create a list of options. Create a new random instance.
        //Generate a random number based on the index of the list count
        //Create random restaurant var ... assign it the random index of an item of the list
        //return the variable
        public static string RandoRestaurant()
        {
            List<string> RestaurantList = new List<string>() {"Joyland", "CFA", "Vui's","Redhead STranger","Nectar", "Hawker's", "Mas Tacos" };
            Random rnd = new Random();
            int Index = rnd.Next(RestaurantList.Count);
            var RandoRest = RestaurantList[Index];
            return RandoRest;
 
        }
        // Class Constructor to spit out a random restaurant
        public Restaurants()
        {
            Name = RandoRestaurant();
        }

    }
}
