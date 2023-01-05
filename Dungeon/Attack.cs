using System.Windows.Forms;

namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines the Attack sublass of Choice
    /// </summary>
    public class Attack : Choice
    {
        /// <summary>
        /// Constructor for the Attack instance
        /// </summary>
        /// <param name="description">A description of the attack</param>
        /// <param name="btnText">The text to display on the attack button</param>
        /// <param name="resultText">The text to display as the result of an attack</param>
        public Attack(string description, string btnText, string resultText) : base(description, btnText, resultText)
        {
        }

        /// <summary>
        /// The method called when the player picks this Choice.
        /// Calls the CombatForm and initiates combat with the player and enemy
        /// </summary>
        /// <param name="player">The player in the combat</param>
        /// <param name="enemy">The enemy in the combat</param>
        /// <returns>True if the player wins, false otherwise</returns>
        public bool PerformAction(Player player, Enemy enemy)
        {
            CombatForm combatForm = new CombatForm(player, enemy);

            DialogResult combatDialog = combatForm.ShowDialog();

            if (combatDialog == DialogResult.OK)
            {
                //Combat has ended. This happens when player or enemy is dead. Returns true if enemy is dead, false if player is dead
                return enemy.HitPoints <= 0;
            }
            else if (combatDialog == DialogResult.Abort)
            {
                //Player flees
                return false;
            }
            else // Player presses the X button
            {
                MessageBox.Show("You have backed off", "Exit Combat",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }
    }
}