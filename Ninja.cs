using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull
        {
            get
            {
                return calorieIntake > 1200;
            }
        }

        public bool Eat(Food item)
        {
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"{item.Name} is Spicey: {item.IsSpicy}, and is {item.IsSweet}.");
            }
            return IsFull;
        }
    }
}