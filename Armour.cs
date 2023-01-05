namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines a set of Armour
    /// </summary>
    public class Armour : Item
    {
        private int armourValue; //The amount of armour the set gives the user

        /// <summary>
        /// Simple constructor assigning the appropriate variables
        /// </summary>
        /// <param name="name">The name of the armour</param>
        /// <param name="value">The value of the armour</param>
        /// <param name="armourValue">The armour value of the armour, higher means more defense</param>
        public Armour(string name, int value, int armourValue) : base(name, value)
        {
            this.armourValue = armourValue;
        }
        /// <summary>
        /// Getter for the armourValue
        /// </summary>
        public int ArmourValue
        {
            get { return armourValue; }
        }
    }
}