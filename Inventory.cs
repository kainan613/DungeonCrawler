using System.Collections.Generic;

namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines an inventory. Containing a List of Item objects.
    /// </summary>
    public class Inventory
    {
        private List<Item> itemList = new List<Item>(); //The list of items within the inventory

        /// <summary>
        /// Methods which adds an Item to the itemList
        /// </summary>
        /// <param name="item">The Item to add</param>
        public void AddItem(Item item)
        {
            itemList.Add(item);
        }
        /// <summary>
        /// Removes an Item form the itemList
        /// </summary>
        /// <param name="item">The Item to remove</param>
        public void RemoveItem(Item item)
        {
            itemList.Remove(item);
        }
        /// <summary>
        /// Gets an Item from the List at the given index
        /// </summary>
        /// <param name="index">The index to get the Item from</param>
        /// <returns>The Item at the given index</returns>
        public Item GetItemAt(int index)
        {
            return itemList[index];
        }
        /// <summary>
        /// Calculates and returns the total value of all the Items in the List
        /// </summary>
        /// <returns>The total value of all items in the List</returns>
        public int GetTotalValue()
        {
            int value = 0;

            foreach (Item item in itemList)
            {
                value += item.Value;
            }

            return value;
        }
        /// <summary>
        /// Writes an array of strings of each Item.Name in the List
        /// </summary>
        /// <returns>The string array of Item names</returns>
        public string[] ToStringArray()
        {
            string[] inventoryArray = new string[itemList.Count];

            for (int i = 0; i < inventoryArray.Length; i++)
            {
                inventoryArray[i] = itemList[i].Name;
            }
            return inventoryArray;
        }
    }
}