using System;

namespace DungeonCrawler
{
    /// <summary>
    /// A class which inherits the Character class, defining an enemy the player can face in combat
    /// </summary>
    public class Enemy : Character
    {
        private int attackBonus;            //The attack bonus innate to the enemy, the higher, the more powerful it is
        private Weapon weapon;              //The weapon the enemy is using
        private int defense;                //The innate defense the enemy is using
        private string attackDescription;   //A description of how the enemy attacks the player

        /// <summary>
        /// The constructor for Enemy, takes variables for all the fields as well as those of the Character class and assigns them appropriately
        /// </summary>
        /// <param name="name">The name of the enemy</param>
        /// <param name="hitPoints">The initial hit points of the enemy</param>
        /// <param name="attackBonus">The attack bonus of the enemy</param>
        /// <param name="weapon">The weapon the enemy is using</param>
        /// <param name="defense">The defense value of the enemy</param>
        /// <param name="attackDescription">The description of the enemy's attack</param>
        public Enemy(string name, int hitPoints, int attackBonus, Weapon weapon, int defense, string attackDescription) : base(name, hitPoints)
        {
            this.attackBonus = attackBonus;
            this.weapon = weapon;
            this.defense = defense;
            this.attackDescription = attackDescription;
        }

        /// <summary>
        /// Overrides the RollAttack of the Character class.
        /// Uses pseudo-random number generation to simulate the rolling of a 20-sided dice.
        /// Rolling the maximum (20) on the dice counts the attack as a critical hit.
        /// This is defined by the isCrit bool
        /// </summary>
        /// <returns>A tuple which contains:
        /// - The dice result plus attackBonus of the enemy, and that of it's weapon
        /// - The isCrit bool
        /// </returns>
        public override (int, bool) RollAttack()
        {
            int diceResult = Random.Next(1, 20 + 1);
            bool isCrit = false;

            if (diceResult == 20)
                isCrit = true;

            return (diceResult + attackBonus + weapon.AttackBonus, isCrit);
        }
        /// <summary>
        /// Method which simulates rolling the damage of the Weapon of the enemy.
        /// Based on the damage values of the Weapon itself
        /// </summary>
        /// <returns></returns>
        public override int RollDamage()
        {
            return weapon.CalcDamage(Random);
        }
        /// <summary>
        /// Getter for the defense
        /// </summary>
        public int Defense
        {
            get { return defense; }
        }
        /// <summary>
        /// Getter for the attackDescription
        /// </summary>
        public string AttackDescription
        {
            get { return attackDescription; }
        }
    }
}