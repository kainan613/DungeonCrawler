using System;
using System.Windows.Forms;

namespace DungeonCrawler
{
    /// <summary>
    /// Class which defines a Form that handles combat
    /// </summary>
    public partial class CombatForm : Form
    {
        private Player player;      //The player engaged in combat
        private Enemy enemy;        //The enemy engaged in combat
        private int turnNumber = 1; //The current turn number. Increments when each turn is taken.

        /// <summary>
        /// The constructor for the CombatForm.
        /// The arguments are the player and the enemy engaged in combat
        /// </summary>
        /// <param name="player">The player in the combat</param>
        /// <param name="enemy">The enemy in the combat</param>
        public CombatForm(Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;

            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Initializes the GUI to prepare for combat
        /// </summary>
        private void InitializeGUI()
        {
            lblPlayerName.Text = player.Name;
            lblPlayerHP.Text = player.HitPoints.ToString();
            lblPlayerWeapon.Text = player.Weapon.Name;
            lblPlayerArmour.Text = player.Armour.Name;
            lblPlayerDefense.Text = (player.Constitution + player.Armour.ArmourValue + 10).ToString();

            lblEnemyName.Text = enemy.Name;
            lblEnemyHP.Text = enemy.HitPoints.ToString();

            btnEndCombat.Hide();
        }
        /// <summary>
        /// Updates the GUI
        /// </summary>
        private void UpdateGUI()
        {
            lblPlayerHP.Text = player.HitPoints.ToString();
            lblEnemyHP.Text = enemy.HitPoints.ToString();
        }
        /// <summary>
        /// Defines the actions taken by the enemy during their turn
        /// </summary>
        private void EnemyTurn()
        {
            Attack(enemy, player);
        }
        /// <summary>
        /// Perform an attack on the target enemy by the attacker player.
        /// </summary>
        /// <param name="attacker">The player performing the attack</param>
        /// <param name="target">The enemy being attacked</param>
        private void Attack(Player attacker, Enemy target)
        {
            txtCombatWindow.Text += $"Turn: {turnNumber}\n";

            (int attackRoll, bool isCrit) = attacker.RollAttack();

            txtCombatWindow.Text += $"You roll {attackRoll} to attack\n";

            if (attackRoll > target.Defense) //Attacker hits
            {
                txtCombatWindow.Text += $"You hit the {target.Name} with your {attacker.Weapon.Name}!\n";

                int damage = attacker.RollDamage();

                if (isCrit)
                {
                    txtCombatWindow.Text += "Critical hit! Double damage!";
                    damage *= 2;
                }

                target.HitPoints -= damage;

                txtCombatWindow.Text += $"You deal {damage} damage to the {target.Name}\n\n";
            }
            else //Attacker misses
                txtCombatWindow.Text += "Miss!\n\n";

            if (target.CheckIfDead())
                EndCombat();
        }
        /// <summary>
        /// Perform an attack on the target player by the attacker enemy.
        /// </summary>
        /// <param name="attacker">The player performing the attack</param>
        /// <param name="target">The enemy being attacked</param>
        private void Attack(Enemy attacker, Player target)
        {
            (int attackRoll, bool isCrit) = attacker.RollAttack();
            txtCombatWindow.Text += $"The {enemy.Name} rolls {attackRoll} to attack\n";

            if (attackRoll > target.CalcDefense()) //Attacker hits
            {
                txtCombatWindow.Text += $"{attacker.AttackDescription}\n\n";

                int damage = attacker.RollDamage();

                if (isCrit)
                {
                    damage *= 2;
                    txtCombatWindow.Text += "Critical hit! Double damage!\n";
                }

                target.HitPoints -= damage;

                txtCombatWindow.Text += $"The {enemy.Name} deals {damage} damage to you!";
            }
            else //Attacker misses
                txtCombatWindow.Text += "Miss!\n\n";

            if (target.CheckIfDead())
                EndCombat();
        }
        /// <summary>
        /// Method which is called when the combat is over and stops further action.
        /// Allows the player to leave the combat, alive or dead
        /// </summary>
        private void EndCombat()
        {
            txtCombatWindow.Text += "\n\nCOMBAT IS OVER";

            btnAttack.Enabled = false;
            btnBackOff.Enabled = false;

            btnEndCombat.Show();
        }
        /// <summary>
        /// Eventhandler for the Attack button.
        /// Attacks the enemy and then checks if they are dead or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttack_Click(object sender, EventArgs e)
        {
            Attack(player, enemy);

            if(!enemy.CheckIfDead())
                EnemyTurn();

            UpdateGUI();
            turnNumber++;
        }
    }
}