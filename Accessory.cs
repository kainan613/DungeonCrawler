namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines an equippable item. A magical accessory for the player boosting their core stats
    /// </summary>
    public class Accessory : Item
    {
        private int strengthBonus;      //The bonus strength added by the Accessory
        private int constitutionBonus;  //The bonus constitution added by the Accessory
        private int perceptionBonus;    //The bonus perception added by the Accessory

        /// <summary>
        /// Simple constructor taking all the arguments and assigning them to the appropriate fields, including the parent class Item
        /// </summary>
        /// <param name="name">The name of the accessory.</param>
        /// <param name="value">The value of the accessory.</param>
        /// <param name="strengthBonus">The strength bonus provided by this accessory when equipped.</param>
        /// <param name="constitutionBonus">The constitution bonus provided by this accessory when equipped.</param>
        /// <param name="perceptionBonus">The perception bonus provided by this accessory when equipped.</param>
        public Accessory(string name, int value, int strengthBonus, int constitutionBonus, int perceptionBonus) : base(name, value)
        {
            this.strengthBonus = strengthBonus;
            this.constitutionBonus = constitutionBonus;
            this.perceptionBonus = perceptionBonus;
        }
        /// <summary>
        /// Getter for the strengthBonus
        /// </summary>
        public int StrengthBonus
        {
            get { return strengthBonus; }
        }
        /// <summary>
        /// Getter for the constitutionBonus
        /// </summary>
        public int ConstitutionBonus
        {
            get { return constitutionBonus; }
        }
        /// <summary>
        /// Getter for the perceptionBonus
        /// </summary>
        public int PerceptionBonus
        {
            get { return perceptionBonus; }
        }
    }
}