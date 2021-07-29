using System;
using LunchBuddy.Buddies;
using System.Collections.Generic;

namespace LunchBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some buddies! declare a new variable, add new since this is a new instance of a LunchBud
            //call the lunch bud constructor and pass it your two params
            var katy = new LunchBud("Katy", "Fry");
            var audrey = new LunchBud("Audrey", "H");
            var jessica = new LunchBud("Jessica", "Fry");
            var bethany = new LunchBud("Bethany", "D");

            //call first method
            katy.Eat();

            //call second method
            audrey.Eat("cheese dip");

            //call third method
            // new list instance of lunch buds. Pass friends from the above options.
            jessica.Eat(new List<LunchBud>() { audrey, katy });

            //call fourth method
            //also don't forget to add generic using statement at the top of the file
            katy.Eat("cheese dip AGAIN", new List<LunchBud>() { jessica, audrey, bethany });

            //each instance will get the same random restaurant whenever the Eat method is invoked.
            //this is because I am setting the random behavior only once, when the lunch bud is constructed. 
            katy.Eat();
            bethany.Eat();
            jessica.Eat();
            audrey.Eat();

        }
    }
}
