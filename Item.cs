namespace DungeonCrawler
{
    public class Item
    {
        private string name; //The name of the item
        private int value;   //The value of the item

        /// <summary>
        /// Simple constructor for the Item class
        /// </summary>
        /// <param name="name">The name of the item</param>
        /// <param name="value">The value of the item</param>
        public Item(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
        /// <summary>
        /// Getter for the Item Name
        /// </summary>
        public string Name
        {
            get { return name; }
        }
        /// <summary>
        /// Getter for the Item Value
        /// </summary>
        public int Value
        {
            get { return value; }
        }
    }
}