namespace OopTest
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Food(string name, int calories, bool isSpicy, bool isSweet){
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }

    }
}
