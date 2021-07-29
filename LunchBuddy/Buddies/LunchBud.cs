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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Restaurant { get; set; }
        public LunchBud(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Restaurant = Restaurants.RandoRestaurant();

        }

        public string Eat()
        {
            Console.WriteLine($"{FirstName} {LastName} is at {Restaurant}.");
            return Restaurant;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"You and {FirstName} ate {food} at the office");
        }

        public void Eat(List<LunchBud> companions)
        {
            Console.WriteLine($"Your buddy, {FirstName} is at {Restaurant}. Betrayal! They are " +
                $" with all your friends!");
            foreach (LunchBud companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }

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
