namespace DungeonCrawler
{
    partial class CombatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnBackOff = new System.Windows.Forms.Button();
            this.txtCombatWindow = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.btnEndCombat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerWeapon = new System.Windows.Forms.Label();
            this.lblPlayerArmour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayerDefense = new System.Windows.Forms.Label();
            this.toolTipCombatForm = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(12, 25);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(176, 26);
            this.lblPlayerName.TabIndex = 30;
            this.lblPlayerName.Text = "Player Name Here";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.Location = new System.Drawing.Point(13, 349);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(175, 26);
            this.lblEnemyName.TabIndex = 31;
            this.lblEnemyName.Text = "Enemy name here";
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(137, 266);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(95, 39);
            this.btnAttack.TabIndex = 32;
            this.btnAttack.Text = "Attack";
            this.toolTipCombatForm.SetToolTip(this.btnAttack, "Attack the enemy");
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnBackOff
            // 
            this.btnBackOff.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnBackOff.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOff.Location = new System.Drawing.Point(18, 266);
            this.btnBackOff.Name = "btnBackOff";
            this.btnBackOff.Size = new System.Drawing.Size(95, 39);
            this.btnBackOff.TabIndex = 33;
            this.btnBackOff.Text = "Back off";
            this.toolTipCombatForm.SetToolTip(this.btnBackOff, "Back off from the combat.\r\nYou cannot escape the room, but this may allow you eno" +
        "ugh time to drink a potion.");
            this.btnBackOff.UseVisualStyleBackColor = true;
            // 
            // txtCombatWindow
            // 
            this.txtCombatWindow.Location = new System.Drawing.Point(277, 12);
            this.txtCombatWindow.Name = "txtCombatWindow";
            this.txtCombatWindow.Size = new System.Drawing.Size(299, 555);
            this.txtCombatWindow.TabIndex = 34;
            this.txtCombatWindow.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "HP:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipCombatForm.SetToolTip(this.label1, "Your current hitpoints");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "HP:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.Location = new System.Drawing.Point(105, 67);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(32, 26);
            this.lblPlayerHP.TabIndex = 37;
            this.lblPlayerHP.Text = "12";
            this.lblPlayerHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.Location = new System.Drawing.Point(52, 375);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(32, 26);
            this.lblEnemyHP.TabIndex = 38;
            this.lblEnemyHP.Text = "12";
            this.lblEnemyHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipCombatForm.SetToolTip(this.lblEnemyHP, "The current hitpoints of the enemy");
            // 
            // btnEndCombat
            // 
            this.btnEndCombat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEndCombat.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndCombat.Location = new System.Drawing.Point(18, 445);
            this.btnEndCombat.Name = "btnEndCombat";
            this.btnEndCombat.Size = new System.Drawing.Size(139, 88);
            this.btnEndCombat.TabIndex = 40;
            this.btnEndCombat.Text = "End Combat";
            this.toolTipCombatForm.SetToolTip(this.btnEndCombat, "End the combat");
            this.btnEndCombat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 41;
            this.label3.Text = "Weapon:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipCombatForm.SetToolTip(this.label3, "Your currently equipped weapon");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "Armour:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipCombatForm.SetToolTip(this.label4, "The armour you are currently wearing");
            // 
            // lblPlayerWeapon
            // 
            this.lblPlayerWeapon.AutoSize = true;
            this.lblPlayerWeapon.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWeapon.Location = new System.Drawing.Point(105, 110);
            this.lblPlayerWeapon.Name = "lblPlayerWeapon";
            this.lblPlayerWeapon.Size = new System.Drawing.Size(83, 26);
            this.lblPlayerWeapon.TabIndex = 43;
            this.lblPlayerWeapon.Text = "weapon";
            this.lblPlayerWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerArmour
            // 
            this.lblPlayerArmour.AutoSize = true;
            this.lblPlayerArmour.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerArmour.Location = new System.Drawing.Point(105, 153);
            this.lblPlayerArmour.Name = "lblPlayerArmour";
            this.lblPlayerArmour.Size = new System.Drawing.Size(79, 26);
            this.lblPlayerArmour.TabIndex = 44;
            this.lblPlayerArmour.Text = "armour";
            this.lblPlayerArmour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 45;
            this.label5.Text = "Defense:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipCombatForm.SetToolTip(this.label5, "Your total defense.\r\nThe enemy needs to roll above this value to hit you.");
            // 
            // lblPlayerDefense
            // 
            this.lblPlayerDefense.AutoSize = true;
            this.lblPlayerDefense.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDefense.Location = new System.Drawing.Point(104, 196);
            this.lblPlayerDefense.Name = "lblPlayerDefense";
            this.lblPlayerDefense.Size = new System.Drawing.Size(142, 26);
            this.lblPlayerDefense.TabIndex = 46;
            this.lblPlayerDefense.Text = "playerDefense";
            this.lblPlayerDefense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CombatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 579);
            this.Controls.Add(this.lblPlayerDefense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayerArmour);
            this.Controls.Add(this.lblPlayerWeapon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEndCombat);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCombatWindow);
            this.Controls.Add(this.btnBackOff);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.lblPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CombatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Combat!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnBackOff;
        private System.Windows.Forms.RichTextBox txtCombatWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Button btnEndCombat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerWeapon;
        private System.Windows.Forms.Label lblPlayerArmour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlayerDefense;
        private System.Windows.Forms.ToolTip toolTipCombatForm;
    }
}