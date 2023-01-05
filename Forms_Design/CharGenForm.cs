using System;
using System.Windows.Forms;

namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines a form to allow the user to create their player character
    /// </summary>
    internal partial class CharGenForm : Form
    {
        private Player player;     //The Player the user is creating

        private int skillPoints;   //The skillpoints of the player, the user spends these to increase their core stats

        private int hitPoints;     //The hitpoints of the player
        private int strength;      //The strength of the player
        private int constitution;  //The constitution of the player
        private int perception;    //The perception of the player

        bool finished = false;     //Bool which defines if the user if finished with their character creation or not

        /// <summary>
        /// Constructor for the form, takes a player object to allow the possibility of editing an existing player
        /// </summary>
        /// <param name="player">A player object to edit</param>
        public CharGenForm(Player player)
        {
            this.player = player;

            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Initializes the GUI
        /// </summary>
        private void InitializeGUI()
        {
            //The user is creating a new Player
            if (player == null)
            {
                hitPoints = 16;
                skillPoints = 5;
                strength = 3;
                constitution = 3;
                perception = 3;
            }
            //The user if updating or editing an existing Player
            else
            {
                hitPoints = player.HitPoints;
                skillPoints = player.SkillPoints;
                strength = player.Strength;
                constitution = player.Constitution;
                perception = player.Perception;

                UpdateGUI();
            }
        }
        /// <summary>
        /// Updates the GUI with the current fields
        /// </summary>
        private void UpdateGUI()
        {
            lblHitPoints.Text = hitPoints.ToString();
            lblSkillPoints.Text = skillPoints.ToString();
            lblStrengthPoints.Text = strength.ToString();
            lblConstitutionPoints.Text = constitution.ToString();
            lblPerceptionPoints.Text = perception.ToString();
        }
        /// <summary>
        /// Saves the character data to the player object. If the player object is null, a new character is created.
        /// Otherwise, the existing character is updated with the new data.
        /// </summary>
        private void SaveDataToPlayer()
        {
            if(player == null) // Create a new character
            {
                player = new Player(SaveName(), hitPoints, strength, constitution, perception, skillPoints);
            }
            else // Update existing character
            {
                player.Name = SaveName();
                player.HitPoints = hitPoints;
                player.Strength = strength;
                player.Constitution = constitution;
                player.Perception = perception;
                player.SkillPoints = skillPoints;
            }
        }
        /// <summary>
        /// Method which gets the entered player character name, or the default "Adventurer" otherwise
        /// </summary>
        /// <returns>The name entered in the text box, or "Adventurer" if no name was entered.</returns>
        private string SaveName()
        {
            if (!string.IsNullOrEmpty(txtCharGenName.Text.Trim()))
                return txtCharGenName.Text.Trim();
            else
                return "Adventurer";
        }
        /// <summary>
        /// Calculates the player's hit points based on their constitution.
        /// </summary>
        private void CalcHitPoints()
        {
            hitPoints = 10 + (constitution * 2);
        }
        /// <summary>
        /// Eventhandler for the confirm button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SaveDataToPlayer();
            finished = true;
        }
        /// <summary>
        /// Eventhandler for the button to add strength
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStrengthAdd_Click(object sender, EventArgs e)
        {
            if (skillPoints != 0 && strength < 6)
            {
                strength++;
                skillPoints--;
                UpdateGUI();
            }
        }
        /// <summary>
        /// Eventhandler for the button to subtract strength
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStrenghtSubtract_Click(object sender, EventArgs e)
        {
            if (strength > 1)
            {
                strength--;
                skillPoints++;
                UpdateGUI();
            }
        }
        /// <summary>
        /// Eventhandler for the button to add constitution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConstitutionAdd_Click(object sender, EventArgs e)
        {
            if (skillPoints != 0 && constitution < 6)
            {
                constitution++;
                skillPoints--;
                CalcHitPoints();
                UpdateGUI();
            }
        }
        /// <summary>
        /// Eventhandler for the button to subtract constitution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConstitutionSubtract_Click(object sender, EventArgs e)
        {
            if (constitution > 1)
            {
                constitution--;
                skillPoints++;
                CalcHitPoints();
                UpdateGUI();
            }
        }
        /// <summary>
        /// Eventhandler for the button to add perception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPerceptionAdd_Click(object sender, EventArgs e)
        {
            if (skillPoints != 0 && perception < 6)
            {
                perception++;
                skillPoints--;
                UpdateGUI();
            }
        }
        /// <summary>
        /// Eventhandler for the button to subtract perception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPerceptionSubtract_Click(object sender, EventArgs e)
        {
            if (perception > 1)
            {
                perception--;
                skillPoints++;
                UpdateGUI();
            }
        }
        /// <summary>
        /// Eventhandler for when the form closes.
        /// If the user has not confirmed they are done, a confirmation box will pop up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharGenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!finished)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        /// <summary>
        /// Gets the Player
        /// </summary>
        public Player Player
        {
            get { return player; }
        }
    }
}