namespace OopTest
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int _health;
        
        // add a public "getter" property to access health
        public int Health {
            get {
                return _health;
            }
            set {
                _health = value;
            }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name, int strength, int intelligence){
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = 3;
            _health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int health){
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            _health = health;
        }

        // Build Attack method
        // Now add a new method called Attack, which when invoked, should reduce the 
        // health of a Human object that is passed as a parameter. The damage done should
        // be 5 * strength (5 points of damage to the attacked, for each 1 point of strength 
        // of the attacker). This method should return the remaining health of the target object.
        public int Attack(Human target)
        {
            target.Health = target.Health - 5 * Strength;

            return target.Health;
        }
    }
}
