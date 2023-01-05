using System;

namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines a Character.The character contains a name, hitpoints, a maximumHitPoints, and a Random instance
    /// </summary>
    public abstract class Character
    {
        private string name;        //The name of the character
        private int hitPoints;      //The curetn hit points of the charater
        private int maxHitPoints;   //The maximum hitpoints of the character

        private Random random = new Random(); //The Random instance of the character, used for simulating rolling dice.

        /// <summary>
        /// Simple Constructor for the Character class. Assigns the given arguments and also sets the maximumHitPoints based on the given hitpoints
        /// </summary>
        /// <param name="name">The name of the character</param>
        /// <param name="hitPoints">The character's starting hit points</param>
        protected Character(string name, int hitPoints)
        {
            this.name = name;
            this.hitPoints = hitPoints;
            maxHitPoints = hitPoints;
        }
        /// <summary>
        /// Method to check if the character is dead or not
        /// </summary>
        /// <returns>True if character is dead, false if alive</returns>
        public bool CheckIfDead()
        {
            return hitPoints <= 0;
        }

        /// <summary>
        /// Abtract method for rolling attacks, overwritten by subclasses
        /// </summary>
        /// <returns>A tuple (int, bool) containing information about the rolled attack</returns>
        public abstract (int, bool) RollAttack();

        /// <summary>
        /// Abtract method for rolling damage, overwritten by subclasses
        /// </summary>
        /// <returns>The amount of damage rolled</returns>
        public abstract int RollDamage();

        /// <summary>
        /// Getter and setter for the name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Getter and setter for the hit points
        /// </summary>
        public int HitPoints
        {
            get { return hitPoints; }
            set { hitPoints = value;}
        }
        /// <summary>
        /// Getter and setter for the max hit points
        /// </summary>
        public int MaxHitPoints
        {
            get { return maxHitPoints; }
            set { maxHitPoints = value; }
        }
        /// <summary>
        /// Getter for the Random instance
        /// </summary>
        public Random Random
        {
            get { return random; }
        }
    }
}