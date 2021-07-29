using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchBuddy.Restaurant;

namespace LunchBuddy.Buddies
{
    class LunchBud
    {   
        //declare your public properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Restaurant { get; set; }

        //delcare your constructor. this takes in two parameters
        //this constructor also assigns a single restaurant to this lunch bud.
        public LunchBud(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Restaurant = Restaurants.RandoRestaurant();

        }
        //first method prints our bud's name and their restaurant and returns said resturant
        //since we have a return value, we have to define the return type (string)
        public string Eat()
        {
            Console.WriteLine($"{FirstName} {LastName} is at {Restaurant}.");
            return Restaurant;
        }
        // this override method override takes one string param
        //use void since there is no return
        public void Eat(string food)
        {
            Console.WriteLine($"You and {FirstName} ate {food} at the office");
        }

        // this parameters lets the method know to expect a new list.
        // Instead of feeding it a string, we're passing it LunchBud
        //iterate through all the buds (which we will pass to the method in program when we call the method)
        public void Eat(List<LunchBud> companions)
        {
            Console.WriteLine($"Your buddy, {FirstName} is at {Restaurant}. Betrayal! They are " +
                $" with all your friends!");
            foreach (LunchBud companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }
        //same as two methods above
        public void Eat(string food, List<LunchBud> companions)
        {
            Console.WriteLine($"Even more betrayal! Your former friend, {FirstName}, ordered your favorite food" +
                $" {food}. They are STILL hanging out with all your friends at {Restaurant}.");
            foreach (LunchBud companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}, who is dead to you too");
            }
        }
    }
}
