using System.Windows.Forms;

namespace DungeonCrawler
{
    /// <summary>
    /// A class defining the GameManager of the game.
    /// This class handles the logic of the game
    /// </summary>
    internal class GameManager
    {
        private Player player;                   //The player in the Dungeon
        private Dungeon dungeon = new Dungeon(); //The Dungeon, the playspace of the game
        private MainForm mainForm;               //Used for calling back to the mainForm to be able to quit the game on game over

        /// <summary>
        /// Simple Constructor, assigns the maniForm field.
        /// </summary>
        /// <param name="mainform">An instance of the mainForm, used to call back and quit the application</param>
        public GameManager(MainForm mainform)
        {
            this.mainForm = mainform;
        }
        /// <summary>
        /// Gets the currentRoom of the Dungeon
        /// </summary>
        /// <returns>A reference to the current Room</returns>
        public Room GetCurrentRoom()
        {
            return dungeon.CurrentRoom;
        }
        /// <summary>
        /// Gets the description of the current room
        /// </summary>
        /// <returns>The description of the current room, or an error message if the room is null</returns>
        public string GetCurrentRoomDescription()
        {
            if (GetCurrentRoom() != null)
                return GetCurrentRoom().Description;
            else
                return "ERROR: No room detected";
        }
        /// <summary>
        /// Gets a formatted string describing each of the choices currently available to the player
        /// </summary>
        /// <returns>The formatted string of choices, or a default error message if the room is null</returns>
        public string GetChoiceDescriptions()
        {
            if (GetCurrentRoom() != null)
                return GetCurrentRoom().ChoicesToString();
            else
                return "ERROR: No room detected"; //REMOVE BEFORE SHIPPING
        }
        /// <summary>
        /// Method which handles the players movement.
        /// Sets the current room of the dungeon to a reference in the previous current room, based on the given argument
        /// </summary>
        /// <param name="direction">String which describes which direction the player wishes to move</param>
        public void PlayerMove(string direction)
        {
            switch (direction)
            {
                case "North":
                    dungeon.CurrentRoom = GetCurrentRoom().North;
                    break;
                case "East":
                    dungeon.CurrentRoom = GetCurrentRoom().East;
                    break;
                case "South":
                    dungeon.CurrentRoom = GetCurrentRoom().South;
                    break;
                case "West":
                    dungeon.CurrentRoom = GetCurrentRoom().West;
                    break;
            }
        }
        /// <summary>
        /// Method which handles the logic behind the Choices contained in each Room
        /// </summary>
        /// <param name="choice">A string describing which type of Choice the player has chosen</param>
        public void PickChoice(string choice)
        {
            Room room = GetCurrentRoom();
            switch(choice)
            {
                case "Attack":
                    Attack attackChoice = room.Attack;
                    if (attackChoice.PerformAction(player, room.Enemy))
                    {
                        // Player wins
                        room.Description += $"\n\n{attackChoice.ResultText}";
                    }
                    else if (player.HitPoints <= 0)
                    {
                        //Player has died, game over
                        DialogResult diedResult = MessageBox.Show("You have died. Play again?", "Game over", MessageBoxButtons.YesNo);
                        RestartOrQuit(diedResult);
                    }
                    else
                    {
                        // Player has backed off, nothing happens
                    }
                    break;
                case "TakeItem":
                    TakeItem takeItemChoice = room.TakeItem;
                    takeItemChoice.PerformAction(player);
                    room.Description += $"\n\n{takeItemChoice.ResultText}";

                    break;
                case "Search":
                    Search searchChoice = room.Search;
                    if (searchChoice.PerformAction(player))
                    {
                        //The player succeeds their in search
                        room.TakeItem.ItemFound = true;
                        room.Description += "\n\n" + searchChoice.ResultText;
                    }
                    else
                    {
                        //The player fails their search
                        room.Description += "\n\nYou fail to find anything.";
                    }
                    break;
                case "Escape":
                    DialogResult winResult = MessageBox.Show("You escaped the dungeon! Congratulations!\n" +
                                                            $"The total value of all your items: {player.Inventory.GetTotalValue()}\n\n" +
                                                             "Would you like to play again?",
                                                             "Escaped!",MessageBoxButtons.YesNo);
                    RestartOrQuit(winResult);
                    break;
            }
        }
        /// <summary>
        /// Method which gets called on player death or victory.
        /// The player can choose to restart or quit the game.
        /// </summary>
        /// <param name="dialogResult">DialogResult about whether the player wants to quit or restart</param>
        public void RestartOrQuit(DialogResult dialogResult)
        {
            if (dialogResult == DialogResult.Yes)
            {
                //Restart the game
                mainForm.ResetForm();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Quit the game
                mainForm.ExitProgram();
            }
        }
        /// <summary>
        /// Getter for the dungeon
        /// </summary>
        public Dungeon Dungeon
        {
            get { return dungeon; }
        }
        /// <summary>
        /// Getter and setter for the player
        /// </summary>
        public Player Player
        {
            get { return player; }
            set { player = value; }
        }
    }
}