namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines the Search sublass of Choice
    /// </summary>
    public class TakeItem : Choice
    {
        private Item item;              //The Item the player can take
        private bool itemTaken = false; //Bool which defines if the item has already been taken
        private bool itemFound = false; //Bool which defines if the item has been found

        /// <summary>
        /// Constructor for the TakeItem instance
        /// </summary>
        /// <param name="description">The description to be displayed to the user</param>
        /// <param name="btnText">The text to be displayed on the button corresponding to this choice</param>
        /// <param name="resultText">The result text to be displayed after taking the item</param>
        /// <param name="item">The item the player is taking</param>
        /// <param name="itemFound">A bool indicating if the item is found or not</param>
        public TakeItem(string description,string btnText, string resultText, Item item, bool itemFound): base(description, btnText, resultText)
        {
            this.item = item;
            this.itemFound = itemFound;
        }
        /// <summary>
        /// The method which is called when the player picks this Choice
        /// </summary>
        /// <param name="player">The player performing the action</param>
        public void PerformAction(Player player)
        {
            itemTaken = true;
            player.Inventory.AddItem(item);
        }
        /// <summary>
        /// Getter for the itemTaken bool
        /// </summary>
        public bool ItemTaken
        {
            get { return itemTaken; }
        }
        /// <summary>
        /// Getter for the itemFound bool
        /// </summary>
        public bool ItemFound
        {
            get {return itemFound; }
            set { itemFound = value; }
        }
    }
}