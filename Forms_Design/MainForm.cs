using DungeonCrawler.Forms_Design;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DungeonCrawler
{
    /// <summary>
    /// Class which handles the main GUI for the game
    /// </summary>
    public partial class MainForm : Form
    {
        private CharGenForm charGenForm;               //Instance of the character generation form
        private GameManager gameMngr;                  //Instance of the GameManager, which handles the game logic
        private Dictionary<int, Button> choiceButtons; //Defines the choiceButtons corresponding to the choices the Player can make in the Rooms.
        private bool gameOver = false;                 //True if the game is over, such as if the player dies or wins the game.

        /// <summary>
        /// Constructor for MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Initializes the GUI with some preset options.
        /// Also initializes the gameMngr
        /// </summary>
        private void InitializeGUI()
        {
            gameMngr = new GameManager(this);

            btnStartGame.Enabled = false;
            txtGameWindow.Hide();
            lblYourLocationtxtBox.Hide();
            txtChoiceBox.Hide();
            lblActiontxtBox.Hide() ;

            btnMoveNorth.Enabled = false;
            btnMoveSouth.Enabled = false;
            btnMoveWest.Enabled = false;
            btnMoveEast.Enabled = false;

            //Dictionary of each Choice Button
            choiceButtons = new Dictionary<int, Button>()
            {
                { 0, btnChoiceAttack },
                { 1, btnChoiceTakeItem },
                { 2, btnChoiceSearch },
                { 3, btnChoiceEscape },
            };

            //Sets all choiceButtons to show and be disabled
            for (int i = 0; i < 4; i++)
            {
                choiceButtons[i].Show();
                choiceButtons[i].Enabled = false;
            }

            DoubleBuffered = true; // Aids in reducing flickering of the often updating Choice Buttons
        }
        /// <summary>
        /// Updates the GUI with the latest information, such as the description of the current room.
        /// </summary>
        private void UpdateGUI()
        {
            txtGameWindow.Text = gameMngr.GetCurrentRoomDescription();
            txtChoiceBox.Text = gameMngr.GetChoiceDescriptions();

            lboxInventory.Items.Clear();
            lboxInventory.Items.AddRange(gameMngr.Player.Inventory.ToStringArray());
            lblInventoryValue.Text = gameMngr.Player.Inventory.GetTotalValue().ToString();

            EnableDisableMovementButtons();

            UpdatePlayerLabels(gameMngr.Player);

            if (gameMngr.GetCurrentRoom().Escape != null)
                SetEscapeButtons();
            else
                EnableDisableChoiceButtons();
        }
        /// <summary>
        /// Updates the labels pertaining to the player, to keep things organised
        /// </summary>
        /// <param name="player">The player object with which to update the labels</param>
        private void UpdatePlayerLabels(Player player)
        {
            lblHP.Text = player.HitPoints.ToString();
            lblPlayerWeapon.Text = player.Weapon.Name;
            lblPlayerWepDmg.Text = $"({player.Weapon.MinDamage} - {player.Weapon.MaxDamage}) + {player.Strength}";
            lblPlayerArmour.Text = player.Armour.Name;
            lblPlayerAccessory.Text = player.Accessory.Name;
            lblSTR.Text = player.Strength.ToString();
            lblCON.Text = player.Constitution.ToString();
            lblPER.Text = player.Perception.ToString();
            lblHP.Text = player.HitPoints.ToString();
            lblPlayerName.Text = player.Name;
            lblHPMax.Text = $"/{player.MaxHitPoints}";
        }
        /// <summary>
        /// Enables or disables the choice buttons depending on meeting certain criteria, different for each choice and button.
        /// </summary>
        private void EnableDisableChoiceButtons()
        {
            Room room = gameMngr.GetCurrentRoom();

            btnChoiceEscape.Hide(); //Hides the Escape button, should only be shown when the player wins

            //List which links the choices in the room with a corresponding button.
            var choices = new List<(Choice choice, Button button)>
            {
                (room.Attack, btnChoiceAttack),
                (room.TakeItem, btnChoiceTakeItem),
                (room.Search, btnChoiceSearch)
            };

            foreach (var (choice, button) in choices)
            {
                if (choice != null)
                {
                    button.Show();
                    button.Enabled = true;
                    button.Text = choice.BtnText;

                    //Button is enabled if the room has an "Attack" Choice and the enemy is alive.
                    if (choice is Attack && room.Enemy.CheckIfDead())
                    {
                        button.Enabled = false;
                        button.Text = "Attack";
                    }

                    //Button is enabled if the room has a "TakeItem" Choice and the item is known to the player, but has not already been taken.
                    if (choice is TakeItem takeItem && (takeItem.ItemTaken || !takeItem.ItemFound))
                    {
                        button.Enabled = false;
                        button.Text = "Take";
                    }

                    //Button is enabled if the room has a "Search" Choice and the player has not yet searched the room.
                    if (choice is Search search && search.Searched)
                    {
                        button.Enabled = false;
                        button.Text = "Search";
                    }
                }
                else
                    button.Enabled = false;
            }
        }
        /// <summary>
        /// Enables or disables the movement buttons.
        /// The player cannot move a direction if that direction contains no room, or if there is an enemy alive in the room.
        /// </summary>
        private void EnableDisableMovementButtons()
        {
            Room currentRoom = gameMngr.GetCurrentRoom();
            bool enemyIsNullOrDead = currentRoom.Enemy?.CheckIfDead() != false;

            btnMoveNorth.Enabled = enemyIsNullOrDead && currentRoom.North != null;
            btnMoveEast.Enabled = enemyIsNullOrDead && currentRoom.East != null;
            btnMoveSouth.Enabled = enemyIsNullOrDead && currentRoom.South != null;
            btnMoveWest.Enabled = enemyIsNullOrDead && currentRoom.West != null;
        }
        /// <summary>
        /// Shows and enables the Escape button, and hides the other buttons. This allows the player to escape and win the game.
        /// </summary>
        private void SetEscapeButtons()
        {
            btnChoiceAttack.Hide();
            btnChoiceTakeItem.Hide();
            btnChoiceSearch.Hide();

            btnChoiceEscape.Show();
            btnChoiceEscape.Enabled = true;
        }
        /// <summary>
        /// Sets the GameManagers Player as the given Player and allows the user to press the "StartGame" button
        /// </summary>
        /// <param name="player">The Player object to set as the gameManagers player</param>
        private void CreatePlayer(Player player)
        {
            if (player != null)
            {
                gameMngr.Player = player;
                btnCreateCharacter.Hide();
                btnStartGame.Enabled = true;
                UpdatePlayerLabels(player);
            }
        }
        /// <summary>
        /// Calls the Character Generation Form with a given player object.
        /// </summary>
        /// <param name="player">The Player object to send to the form, will be null if creating a new character</param>
        /// <returns>The finished Player form the Character Generation Form</returns>
        private Player CharGenDialog(Player player)
        {
            charGenForm = new CharGenForm(player);

            DialogResult charGenDialog = charGenForm.ShowDialog();

            if (charGenDialog == DialogResult.OK)
                return charGenForm.Player;
            else
                return null;
        }
        /// <summary>
        /// Calls the method which creates the default dungeon for the game.
        /// </summary>
        private void DefaultDungeon()
        {
            gameMngr.Dungeon.AddDefaultDungeon();
            UpdateGUI();
        }
        /// <summary>
        /// Eventhhandler for the movement button moving North
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveNorth_Click(object sender, EventArgs e)
        {
            gameMngr.PlayerMove("North");
            UpdateGUI();
        }
        /// <summary>
        /// Eventhhandler for the movement button moving East
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveEast_Click(object sender, EventArgs e)
        {
            gameMngr.PlayerMove("East");
            UpdateGUI();
        }
        /// <summary>
        /// Eventhhandler for the movement button moving South
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveSouth_Click(object sender, EventArgs e)
        {
            gameMngr.PlayerMove("South");
            UpdateGUI();
        }
        /// <summary>
        /// Eventhhandler for the movement button moving West
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveWest_Click(object sender, EventArgs e)
        {
            gameMngr.PlayerMove("West");
            UpdateGUI();
        }
        /// <summary>
        /// Eventhandler for the Attack action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoiceAttack_Click(object sender, EventArgs e)
        {
            gameMngr.PickChoice("Attack");
            if (!gameOver)
                UpdateGUI();

            gameOver = false; // Resets gameOver to false, so the game can reset and continue like normal
        }
        /// <summary>
        /// Eventhandler for the Take Item action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoiceTakeItem_Click(object sender, EventArgs e)
        {
            gameMngr.PickChoice("TakeItem");
            UpdateGUI();
        }
        /// <summary>
        /// Eventhandler for the Search action
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoiceSearch_Click(object sender, EventArgs e)
        {
            gameMngr.PickChoice("Search");
            UpdateGUI();
        }
        /// <summary>
        /// Eventhandler for the Escape action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoiceEscape_Click(object sender, EventArgs e)
        {
            gameMngr.PickChoice("Escape");

            gameOver = false; // Sets gameOver to false, so if the player plays again, the game resets properly.
        }
        /// <summary>
        /// Eventhandler for the Create Character button.
        /// Calls the CharGenForm with null, because the player is creating a new character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            CreatePlayer(CharGenDialog(null));
        }
        /// <summary>
        /// Eventhandler for the StartGame button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (gameMngr.Player == null || gameMngr.Dungeon == null)
            {
                MessageBox.Show("Make sure a character is created!", "Failed to Start", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtGameWindow.Show();
                lblYourLocationtxtBox.Show();
                txtChoiceBox.Show();
                lblActiontxtBox.Show();
                btnStartGame.Hide();
                DefaultDungeon();
            }
        }
        /// <summary>
        /// Eventhandler for the EquipItem button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEquipItem_Click(object sender, EventArgs e)
        {
            if (lboxInventory.SelectedIndex != -1)
            {
                //Equips the item at the selected index in the list
                gameMngr.Player.EquipItem(lboxInventory.SelectedIndex);
                UpdateGUI();
            }
        }
        /// <summary>
        /// Eventhandler for the UseItem button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUseItem_Click(object sender, EventArgs e)
        {
            if (lboxInventory.SelectedIndex != -1)
            {
                //Uses the item at the selected index
                gameMngr.Player.UseItem(lboxInventory.SelectedIndex);
                UpdateGUI();
            }
        }
        /// <summary>
        /// Eventhandler for the About button under the Help menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
        /// <summary>
        /// Resets the form to be like it was at boot.
        /// For restarting the game.
        /// </summary>
        public void ResetForm()
        {
            gameOver = true;
            InitializeGUI();
            btnCreateCharacter.Show();
            btnStartGame.Show();
        }
        /// <summary>
        /// Exits the game
        /// </summary>
        public void ExitProgram()
        {
            gameOver = true;
            Application.Exit();
        }
        /// <summary>
        /// Eventhandler for the form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If gameOver, will skip the confirmation box, as the user was just asked whether they wanted to quit or restart
            if (!gameOver)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}