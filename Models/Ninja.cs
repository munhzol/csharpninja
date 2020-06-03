using System;
using System.Collections.Generic;

namespace OopTest
{
    class Ninja
    {   
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja() {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull {
            get {
                return calorieIntake>1200;
            }
        }

        // build out the Eat method
        public void Eat(Food item)
        {
            calorieIntake = calorieIntake- 10;
            if(IsFull){
                Console.WriteLine("The ninja is full and cannot eat anymore!!");
            } else {
                calorieIntake +=item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Food name = {item.Name}, spice={item.IsSpicy}, sweet={item.IsSweet}, calorie={item.Calories}");
            }

        }

    }
}
