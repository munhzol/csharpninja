using System;
using System.Collections.Generic;

namespace OopTest
{
    class Buffet
    {   
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            // List from https://www.delish.com/cooking/menus/g2616/italian-dinner-recipes/?slide=10
            Menu = new List<Food>()
            {
                new Food("Chicken Marsala", 110, true, false),
                new Food("Air Fryer Pizza", 150, false, true),
                new Food("Cumin Spiced Chicken Meatballs", 120, false, false),
                new Food("Pasta e Fagioli", 300, true, false),
                new Food("Easy Chicken Parm", 200, true, true),
                new Food("Flatbread Pizza", 150, true, false),
                new Food("Garlic Butter Turkey Meatballs", 100, true, false),
                new Food("Pasta Puttanesca", 210, true, false),
                new Food("Calzones", 210, true, true)
            };
        }
        
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }

    }
}
