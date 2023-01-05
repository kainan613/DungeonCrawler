namespace DungeonCrawler
{
    /// <summary>
    /// Class which describes a Choice the player can make.
    /// Subclasses define more specific choices
    /// </summary>
    public class Choice
    {
        private string description; //Description of the Choice in the main text box of the game.
        private string btnText;     //A shortened text on the button tied to the choice
        private string resultText;  //Message that shows after completed action. i.e: "You found a key on the body"

        /// <summary>
        /// Constructor for Choice, takes three ordered strings and assigns them to the appropriate field
        /// </summary>
        /// <param name="description">The text displayed to the player describing the choice they are making</param>
        /// <param name="btnText">The text displayed on the button representing the choice</param>
        /// <param name="resultText">The text displayed to the player after they have made the choice, describing the outcome of the choice</param>
        public Choice(string description, string btnText, string resultText)
        {
            this.description = description;
            this.btnText = btnText;
            this.resultText = resultText;
        }
        /// <summary>
        /// Getter for the description
        /// </summary>
        public string Description
        {
            get { return description; }
        }
        /// <summary>
        /// Getter for the btnText
        /// </summary>
        public string BtnText
        {
            get { return btnText; }
        }
        /// <summary>
        /// Getter for the resultText
        /// </summary>
        public string ResultText
        {
            get { return resultText; }
        }
    }
}