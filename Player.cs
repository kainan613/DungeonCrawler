using DungeonCrawler.Forms_Design;
using System;

namespace DungeonCrawler
{
    /// <summary>
    /// Player class which defines the Player character in the game.
    /// Inherits the Character class
    /// </summary>
    public class Player : Character
    {
        private int strength;       //The strength value of the Player
        private int constitution;   //The constitution value of the Player
        private int perception;     //The perception value of the Player

        private Weapon weapon = new Weapon("Fists", 0, 1, 1, 0);         //The current Weapon of the player, with a default weapon
        private Armour armour = new Armour("No armour", 0, 0);           //The current Armour of the player, with a default armour
        private Accessory accessory = new Accessory("None", 0, 0, 0, 0); //The current Accessory of the player, with a default accessory
        private Inventory inventory = new Inventory();                   //The Inventory of the Player

        private int skillPoints; //The amount of skillpoints the player has to spend in character creation

        /// <summary>
        /// Constructor for the player. Takes arguments for some of it's fields and the base class of Character and assigns them.
        /// </summary>
        /// <param name="name">The name of the player</param>
        /// <param name="hitPoints">The number of hit points the player has</param>
        /// <param name="strength">The player's strength</param>
        /// <param name="constitution">The player's constitution</param>
        /// <param name="perception">The player's perception</param>
        /// <param name="skillPoints">The number of skill points the player has</param>
        public Player(string name, int hitPoints, int strength, int constitution, int perception, int skillPoints) : base(name, hitPoints)
        {
            this.strength = strength;
            this.constitution = constitution;
            this.perception = perception;
            this.skillPoints = skillPoints;
        }
        /// <summary>
        /// Simulates rolling a 20-sided dice to attempt a perception challenge.
        /// Adds the players perception skill to the result.
        /// </summary>
        /// <returns>The result of the dice + the perception skil of the player</returns>
        public int RollPerception()
        {
            return Random.Next(1, 20 + 1) + perception;
        }
        /// <summary>
        /// Simulates rolling a 20-sided dice to attempt to hit an enemy with an attack.
        /// Adds the player's strength skill and the attackbonus of their weapon to the result.
        /// </summary>
        /// <returns>A tuple containing the result of the attack roll and a bool indicating whether the attack is a critical hit.</returns>
        public override (int, bool) RollAttack()
        {
            int diceResult = Random.Next(1, 20 + 1);
            bool isCrit = false;

            if (diceResult == 20)
                isCrit = true;

            return (diceResult +  strength + weapon.AttackBonus, isCrit);
        }
        /// <summary>
        /// Simulates a dice roll to calculate how much damage the player deals with an attack.
        /// Calls the CalcDamage method of the players weapon, which produces a result between the weapons minimum and maximum damage
        /// The result is the damage dealt by the player's weapon, plus their strength attribute.
        /// </summary>
        /// <returns>The amount of damage dealt by the player</returns>
        public override int RollDamage()
        {
            return weapon.CalcDamage(Random) + strength;
        }
        /// <summary>
        /// Calculates the defense value of the player.
        /// The result is 10 plus the player's constitution skill and the armour value of their armour.
        /// </summary>
        /// <returns>The player's defense value.</returns>
        public int CalcDefense()
        {
            return 10 + constitution + Armour.ArmourValue;
        }
        /// <summary>
        /// Uses an item from the player's inventory. If the item is a potion, it will be consumed and the player's hit points will be restored.
        /// If the item is a weapon, armour, or accessory, it will be equipped by the player.
        /// </summary>
        /// <param name="index">The index of the item in the player's inventory.</param>
        public void UseItem(int index)
        {
            Item item = inventory.GetItemAt(index);

            if (item is Potion potion && DrinkPotion(potion))
                inventory.RemoveItem(item);
        }
        /// <summary>
        /// Equips an item from the player's inventory.
        /// Checks what type of item it is, and equips it in the appropriate slot.
        /// If the given index contains no item of the defined types, nothing happens.
        /// </summary>
        /// <param name="index">The index of the item in the player's inventory.</param>
        public void EquipItem(int index)
        {
            Item item = inventory.GetItemAt(index);

            if (item is Weapon weapon)
                this.weapon = weapon;

            if (item is Armour armour)
                this.armour = armour;

            if (item is Accessory accessory)
                EquipAccessory(accessory);
        }
        /// <summary>
        /// Consumes a potion and restores the player's hit points.
        /// </summary>
        /// <param name="potion">The potion to be consumed.</param>
        /// <returns>True if the potion was consumed, false if the player was already at maximum hit points.</returns>
        public bool DrinkPotion(Potion potion)
        {
            if (HitPoints != MaxHitPoints) //Checks if the player is already at max hitPoints
            {
                int healedAmount = potion.RollHeal(Random);

                if (healedAmount + HitPoints >= MaxHitPoints)
                {
                    HitPoints = MaxHitPoints;
                    return true;
                }
                else
                {
                    HitPoints += healedAmount;
                    return true;
                }
            }
            else //Player is at max hitPoints, no healing needed
                return false;
        }
        /// <summary>
        /// Equips the player with the specified accessory.
        /// </summary>
        /// <param name="accessory">The accessory to equip</param>
        public void EquipAccessory(Accessory accessory)
        {
            int oldConstitution = constitution;


            // If the player is already wearing an accessory, remove the stat bonuses from it
            if (this.accessory.Name != "None")
            {
                strength -= this.accessory.StrengthBonus;
                constitution -= this.accessory.ConstitutionBonus;
                perception -= this.accessory.PerceptionBonus;
            }

            // Set the new accessory and add its stat bonuses
            this.accessory = accessory;
            strength += accessory.StrengthBonus;
            constitution += accessory.ConstitutionBonus;
            perception += accessory.PerceptionBonus;

            // If the player's constitution has changed, update their hit points and max hit points accordingly
            if (constitution != oldConstitution)
            {
                int constitutionDifference = constitution - oldConstitution;
                HitPoints += 2 * constitutionDifference;
                MaxHitPoints += 2 * constitutionDifference;
            }
        }
        /// <summary>
        /// Gets or sets the skill points of the player.
        /// </summary>
        public int SkillPoints
        {
            get { return skillPoints; }
            set { skillPoints = value; }
        }
        /// <summary>
        /// Gets or sets the strength of the player.
        /// </summary>
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        /// <summary>
        /// Gets or sets the constitution of the player.
        /// </summary>
        public int Constitution
        {
            get { return constitution; }
            set { constitution = value; }
        }
        /// <summary>
        /// Gets or sets the perception of the player.
        /// </summary>
        public int Perception
        {
            get { return perception; }
            set { perception = value; }
        }
        /// <summary>
        /// Gets the weapon of the player.
        /// </summary>
        public Weapon Weapon
        {
            get { return weapon; }
        }
        /// <summary>
        /// Gets the armour of the player.
        /// </summary>
        public Armour Armour
        {
            get { return armour; }
        }
        /// <summary>
        /// Gets the inventory of the player.
        /// </summary>
        public Inventory Inventory
        {
            get { return inventory; }
        }
        /// <summary>
        /// Gets the accessory of the player.
        /// </summary>
        public Accessory Accessory
        {
            get { return accessory; }
        }
    }
}