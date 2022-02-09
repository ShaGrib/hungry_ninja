using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("Chibi Roll", 1000, false, false),
            new Food("Sashimi", 400, false, false),
            new Food("Foo Yung Mein", 800, true, false),
            new Food("Powdered Dough Balls", 1200, false, true),
            new Food("Sketchy Rice", 600, false, false),
            new Food("Fu Ming Lo mein", 900, true, false),
            new Food("Miso Soup", 700, false, false)
        };
        }

        public Food Serve()
        {
            Random rand = new Random();
            int item = rand.Next(Menu.Count);
            return Menu[item];
        }
    }
}