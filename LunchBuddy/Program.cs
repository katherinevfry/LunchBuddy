using System;
using LunchBuddy.Buddies;
using System.Collections.Generic;

namespace LunchBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var katy = new LunchBud("Katy", "Fry");
            var audrey = new LunchBud("Audrey", "H");
            var jessica = new LunchBud("Jessica", "Fry");
            var bethany = new LunchBud("Bethany", "D");

            katy.Eat();

            audrey.Eat("cheese dip");

            jessica.Eat(new List<LunchBud>() { audrey, katy });

            katy.Eat("cheese dip AGAIN", new List<LunchBud>() { jessica, audrey, bethany });

            katy.Eat();
            bethany.Eat();
            jessica.Eat();
            audrey.Eat();

        }
    }
}
