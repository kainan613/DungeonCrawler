namespace DungeonCrawler
{
    /// <summary>
    /// A simple class to mark an action as Escape. This is how the player can win the game.
    /// Only available in the final room
    /// </summary>
    public class Escape : Choice
    {
        /// <summary>
        /// Constructor for the Escape choice.
        /// </summary>
        /// <param name="description">The description of the escape choice to be displayed to the player</param>
        /// <param name="btnText">The text to be displayed on the button for the escape choice</param>
        /// <param name="resultText">The text to be displayed to the player after the escape choice has been made</param>
        public Escape(string description, string btnText, string resultText) : base(description, btnText, resultText)
        {
        }
    }
}