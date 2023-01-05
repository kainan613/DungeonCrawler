using System;

namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines an equipable weapon.
    /// </summary>
    public class Weapon : Item
    {
        private int minDamage;      //The minimum damage the weapon can deal
        private int maxDamage;      //The maximum damage the weapon can deal
        private int attackBonus;    //The attackbonus of the weapon. The higher, the easier it is to hit a target.

        /// <summary>
        /// Constructor for the Weapon
        /// </summary>
        /// <param name="name">The name of the weapon</param>
        /// <param name="value">The value of the weapon</param>
        /// <param name="minDamage">The minimum damage that the weapon can deal</param>
        /// <param name="maxDamage">The maximum damage that the weapon can deal</param>
        /// <param name="attackBonus">The bonus to attack rolls when using this weapon</param>
        public Weapon(string name, int value, int minDamage, int maxDamage, int attackBonus) : base(name, value)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.attackBonus = attackBonus;
        }
        /// <summary>
        /// Simulates a diceroll to determine the amount of damage the weapon deals
        /// </summary>
        /// <param name="random">A Random object to simulate the diceroll</param>
        /// <returns>The damage dealt by this weapon.</returns>
        public int CalcDamage(Random random)
        {
            return random.Next(minDamage, maxDamage+1);
        }
        /// <summary>
        /// Gets the minimum damage that this weapon can deal.
        /// </summary>
        public int MinDamage
        {
            get { return minDamage; }
        }
        /// <summary>
        /// Gets the maximum damage that this weapon can deal.
        /// </summary>
        public int MaxDamage
        {
            get { return maxDamage; }
        }
        /// <summary>
        /// Gets the attackbonus of this weapon
        /// </summary>
        public int AttackBonus
        {
            get { return attackBonus; }
        }
    }
}