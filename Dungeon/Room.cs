namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines a Room in the dungeon. Contains many fields for what the Room itself can contain.
    /// Such as:
    /// - An enemy
    /// - A number of Choices
    /// - References to adjacent Room objects
    /// </summary>
    public class Room
    {
        private string description; // The description of the Room

        private Enemy enemy;        // The enemy of the Room

        private Attack attack;      //The Attack Choice of the Room
        private TakeItem takeItem;  //The TakeItem Choice of the Room
        private Search search;      //The Search Choice of the Room
        private Escape escape;      //The Escape Choice of the Room

        private Room north; //Reference to the adjacent Room to the North
        private Room east;  //Reference to the adjacent Room to the East
        private Room south; //Reference to the adjacent Room to the South
        private Room west;  //Reference to the adjacent Room to the West

        /// <summary>
        /// The constructor for Room, takes variables for all the fields and assigns them to the instance appropriately
        /// </summary>
        /// <param name="description">The description of the room</param>
        /// <param name="enemy">The enemy in the room</param>
        /// <param name="attack">The attack action for the player to use against the enemy</param>
        /// <param name="takeItem">The take item action for the player to use to pick up an item in the room</param>
        /// <param name="search">The search action for the player to use to search the room for items</param>
        /// <param name="escape">The escape action for the player to win the game in the final room</param>
        public Room(string description, Enemy enemy, Attack attack, TakeItem takeItem, Search search, Escape escape)
        {
            this.description = description;
            this.enemy = enemy;
            this.attack = attack;
            this.takeItem = takeItem;
            this.search = search;
            this.escape = escape;
        }
        /// <summary>
        /// A method which creates a string describing the choices currently available to the player
        /// </summary>
        /// <returns>A formatted string containing only the choices the player can currently take</returns>
        public string ChoicesToString()
        {
            string choices = "";

            //Checks if there is an Attack action, and that the enemy is still alive
            if (attack != null && enemy?.CheckIfDead() == false)
                choices += "- " + attack.Description + "\n";

            //Checks if there is a TakeItem action, and whether that item has been found
            if (takeItem?.ItemTaken == false && takeItem.ItemFound)
                choices += "- " + takeItem.Description + "\n";

            //Checks if there is a Search action, and if the room has been searched before
            if (search != null && !Search.Searched)
                choices += "- " + search.Description + "\n";

            return choices;
        }
        /// <summary>
        /// Getter for the Enemy
        /// </summary>
        public Enemy Enemy
        {
            get { return enemy; }
        }
        /// <summary>
        /// Getter and setter for the Room description
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// Getter for the Attack action
        /// </summary>
        public Attack Attack
        {
            get { return attack; }
        }
        /// <summary>
        /// Getter for the TakeItem action
        /// </summary>
        public TakeItem TakeItem
        {
            get { return takeItem; }
        }
        /// <summary>
        /// Getter for the escape action
        /// </summary>
        public Escape Escape
        {
            get { return escape; }
        }
        /// <summary>
        /// Getter for the Search action
        /// </summary>
        public Search Search
        {
            get { return search; }
        }
        /// <summary>
        /// Getter and setter for the adjacent North Room reference
        /// </summary>
        public Room North
        {
            get { return north; }
            set { north = value; }
        }
        /// <summary>
        /// Getter and setter for the adjacent East Room reference
        /// </summary>
        public Room East
        {
            get { return east; }
            set { east = value; }
        }
        /// <summary>
        /// Getter and setter for the adjacent South Room reference
        /// </summary>
        public Room South
        {
            get { return south; }
            set { south = value; }
        }
        /// <summary>
        /// Getter and setter for the adjacent West Room reference
        /// </summary>
        public Room West
        {
            get { return west; }
            set { west = value; }
        }
    }
}