using System;

namespace DungeonCrawler.Forms_Design
{
    /// <summary>
    /// This class defines a healing potion that can be consumed to restore hit points.
    /// </summary>
    public class Potion : Item
    {
        private int minHeal; //The minmum value the potion can heal
        private int maxHeal; //The maximum value the potion can heal

        /// <summary>
        /// Constructor for the Potion, takes the given arguments and assigns them appropriately
        /// </summary>
        /// <param name="name">The name of the potion.</param>
        /// <param name="value">The value of the potion.</param>
        /// <param name="minHeal">The minimum amount of hit points the potion will heal.</param>
        /// <param name="maxHeal">The maximum amount of hit points the potion will heal.</param>
        public Potion(string name, int value, int minHeal, int maxHeal) : base(name, value)
        {
            this.minHeal = minHeal;
            this.maxHeal = maxHeal;
        }
        /// <summary>
        /// Returns a random amount of hit points to be healed, between the minimum and maximum heal values of the potion.
        /// </summary>
        /// <param name="random">A Random object to simulate the diceroll</param>
        /// <returns>The amount of hitpoints to heal</returns>
        public int RollHeal(Random random)
        {
            return random.Next(minHeal, maxHeal+1);
        }
    }
}