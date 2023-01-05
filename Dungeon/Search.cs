namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines the Search sublass of Choice
    /// </summary>
    public class Search : Choice
    {
        private int searchDifficulty;   //The difficulty of succeding in the search
        private bool searched = false;  //Bool defining if the the action has already been performed.

        /// <summary>
        /// Constructor for the Search instance
        /// </summary>
        /// <param name="description">The description to be displayed to the user</param>
        /// <param name="btnText">The text to be displayed on the button corresponding to this choice</param>
        /// <param name="resultText">The result text to be displayed if the search is successful</param>
        /// <param name="searchDifficulty">The difficulty of the search</param>
        public Search(string description, string btnText, string resultText, int searchDifficulty) : base(description, btnText, resultText)
        {
            this.searchDifficulty = searchDifficulty;
        }
        /// <summary>
        /// Method which is called when the player picks this Choice
        /// </summary>
        /// <param name="player">The Player performing the action</param>
        /// <returns>true if the player succeeds in their roll, false if failed</returns>
        public bool PerformAction(Player player)
        {
            searched = true;

            if (player.RollPerception() >= searchDifficulty)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Getter for the searched bool
        /// </summary>
        public bool Searched
        {
            get { return searched; }
        }
    }
}