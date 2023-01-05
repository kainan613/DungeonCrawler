namespace DungeonCrawler
{
    partial class MainForm
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
            this.btnMoveNorth = new System.Windows.Forms.Button();
            this.btnMoveEast = new System.Windows.Forms.Button();
            this.btnMoveWest = new System.Windows.Forms.Button();
            this.btnMoveSouth = new System.Windows.Forms.Button();
            this.lboxInventory = new System.Windows.Forms.ListBox();
            this.txtGameWindow = new System.Windows.Forms.RichTextBox();
            this.btnChoiceSearch = new System.Windows.Forms.Button();
            this.btnChoiceTakeItem = new System.Windows.Forms.Button();
            this.btnChoiceAttack = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.txtChoiceBox = new System.Windows.Forms.RichTextBox();
            this.lblActiontxtBox = new System.Windows.Forms.Label();
            this.lblYourLocationtxtBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChoiceEscape = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblCON = new System.Windows.Forms.Label();
            this.lblPlayerWeapon = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSTR = new System.Windows.Forms.Label();
            this.lblHPMax = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.btnEquipItem = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblPlayerArmour = new System.Windows.Forms.Label();
            this.lblPER = new System.Windows.Forms.Label();
            this.lblPlayerWepDmg = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblPlayerAccessory = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInventoryValue = new System.Windows.Forms.Label();
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoveNorth
            // 
            this.btnMoveNorth.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveNorth.Location = new System.Drawing.Point(116, 32);
            this.btnMoveNorth.Name = "btnMoveNorth";
            this.btnMoveNorth.Size = new System.Drawing.Size(91, 38);
            this.btnMoveNorth.TabIndex = 0;
            this.btnMoveNorth.Text = "North";
            this.toolTipMainForm.SetToolTip(this.btnMoveNorth, "Move to the northern adjacent room.");
            this.btnMoveNorth.UseVisualStyleBackColor = true;
            this.btnMoveNorth.Click += new System.EventHandler(this.btnMoveNorth_Click);
            // 
            // btnMoveEast
            // 
            this.btnMoveEast.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveEast.Location = new System.Drawing.Point(213, 76);
            this.btnMoveEast.Name = "btnMoveEast";
            this.btnMoveEast.Size = new System.Drawing.Size(91, 38);
            this.btnMoveEast.TabIndex = 1;
            this.btnMoveEast.Text = "East";
            this.toolTipMainForm.SetToolTip(this.btnMoveEast, "Move to the eastern adjacent room.");
            this.btnMoveEast.UseVisualStyleBackColor = true;
            this.btnMoveEast.Click += new System.EventHandler(this.btnMoveEast_Click);
            // 
            // btnMoveWest
            // 
            this.btnMoveWest.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveWest.Location = new System.Drawing.Point(19, 76);
            this.btnMoveWest.Name = "btnMoveWest";
            this.btnMoveWest.Size = new System.Drawing.Size(91, 38);
            this.btnMoveWest.TabIndex = 2;
            this.btnMoveWest.Text = "West";
            this.toolTipMainForm.SetToolTip(this.btnMoveWest, "Move to the western adjacent room.");
            this.btnMoveWest.UseVisualStyleBackColor = true;
            this.btnMoveWest.Click += new System.EventHandler(this.btnMoveWest_Click);
            // 
            // btnMoveSouth
            // 
            this.btnMoveSouth.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveSouth.Location = new System.Drawing.Point(116, 120);
            this.btnMoveSouth.Name = "btnMoveSouth";
            this.btnMoveSouth.Size = new System.Drawing.Size(91, 38);
            this.btnMoveSouth.TabIndex = 3;
            this.btnMoveSouth.Text = "South";
            this.toolTipMainForm.SetToolTip(this.btnMoveSouth, "Move to the southern adjacent room.");
            this.btnMoveSouth.UseVisualStyleBackColor = true;
            this.btnMoveSouth.Click += new System.EventHandler(this.btnMoveSouth_Click);
            // 
            // lboxInventory
            // 
            this.lboxInventory.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxInventory.FormattingEnabled = true;
            this.lboxInventory.ItemHeight = 22;
            this.lboxInventory.Location = new System.Drawing.Point(17, 338);
            this.lboxInventory.Name = "lboxInventory";
            this.lboxInventory.Size = new System.Drawing.Size(193, 334);
            this.lboxInventory.TabIndex = 6;
            this.toolTipMainForm.SetToolTip(this.lboxInventory, "Your inventory, everything you are carrying");
            // 
            // txtGameWindow
            // 
            this.txtGameWindow.BackColor = System.Drawing.Color.White;
            this.txtGameWindow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtGameWindow.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameWindow.Location = new System.Drawing.Point(272, 48);
            this.txtGameWindow.Name = "txtGameWindow";
            this.txtGameWindow.ReadOnly = true;
            this.txtGameWindow.Size = new System.Drawing.Size(827, 332);
            this.txtGameWindow.TabIndex = 7;
            this.txtGameWindow.Text = "";
            // 
            // btnChoiceSearch
            // 
            this.btnChoiceSearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceSearch.Location = new System.Drawing.Point(53, 82);
            this.btnChoiceSearch.Name = "btnChoiceSearch";
            this.btnChoiceSearch.Size = new System.Drawing.Size(203, 46);
            this.btnChoiceSearch.TabIndex = 9;
            this.btnChoiceSearch.Text = "Search";
            this.toolTipMainForm.SetToolTip(this.btnChoiceSearch, "Search the room.");
            this.btnChoiceSearch.UseVisualStyleBackColor = true;
            this.btnChoiceSearch.Click += new System.EventHandler(this.btnChoiceSearch_Click);
            // 
            // btnChoiceTakeItem
            // 
            this.btnChoiceTakeItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceTakeItem.Location = new System.Drawing.Point(54, 132);
            this.btnChoiceTakeItem.Name = "btnChoiceTakeItem";
            this.btnChoiceTakeItem.Size = new System.Drawing.Size(203, 46);
            this.btnChoiceTakeItem.TabIndex = 11;
            this.btnChoiceTakeItem.Text = "Take";
            this.toolTipMainForm.SetToolTip(this.btnChoiceTakeItem, "Take an item.");
            this.btnChoiceTakeItem.UseVisualStyleBackColor = true;
            this.btnChoiceTakeItem.Click += new System.EventHandler(this.btnChoiceTakeItem_Click);
            // 
            // btnChoiceAttack
            // 
            this.btnChoiceAttack.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceAttack.Location = new System.Drawing.Point(53, 32);
            this.btnChoiceAttack.Name = "btnChoiceAttack";
            this.btnChoiceAttack.Size = new System.Drawing.Size(203, 46);
            this.btnChoiceAttack.TabIndex = 12;
            this.btnChoiceAttack.Text = "Attack";
            this.toolTipMainForm.SetToolTip(this.btnChoiceAttack, "Attack an enemy.");
            this.btnChoiceAttack.UseVisualStyleBackColor = true;
            this.btnChoiceAttack.Click += new System.EventHandler(this.btnChoiceAttack_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCharacter.Location = new System.Drawing.Point(569, 314);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(189, 59);
            this.btnCreateCharacter.TabIndex = 15;
            this.btnCreateCharacter.Text = "Create Character";
            this.toolTipMainForm.SetToolTip(this.btnCreateCharacter, "Create your character.");
            this.btnCreateCharacter.UseVisualStyleBackColor = true;
            this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // txtChoiceBox
            // 
            this.txtChoiceBox.BackColor = System.Drawing.Color.White;
            this.txtChoiceBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChoiceBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceBox.Location = new System.Drawing.Point(272, 412);
            this.txtChoiceBox.Name = "txtChoiceBox";
            this.txtChoiceBox.ReadOnly = true;
            this.txtChoiceBox.Size = new System.Drawing.Size(827, 183);
            this.txtChoiceBox.TabIndex = 19;
            this.txtChoiceBox.Text = "";
            // 
            // lblActiontxtBox
            // 
            this.lblActiontxtBox.AutoSize = true;
            this.lblActiontxtBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiontxtBox.Location = new System.Drawing.Point(267, 383);
            this.lblActiontxtBox.Name = "lblActiontxtBox";
            this.lblActiontxtBox.Size = new System.Drawing.Size(79, 26);
            this.lblActiontxtBox.TabIndex = 23;
            this.lblActiontxtBox.Text = "Actions";
            // 
            // lblYourLocationtxtBox
            // 
            this.lblYourLocationtxtBox.AutoSize = true;
            this.lblYourLocationtxtBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourLocationtxtBox.Location = new System.Drawing.Point(267, 19);
            this.lblYourLocationtxtBox.Name = "lblYourLocationtxtBox";
            this.lblYourLocationtxtBox.Size = new System.Drawing.Size(130, 26);
            this.lblYourLocationtxtBox.TabIndex = 24;
            this.lblYourLocationtxtBox.Text = "Your location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Inventory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoveEast);
            this.groupBox1.Controls.Add(this.btnMoveNorth);
            this.groupBox1.Controls.Add(this.btnMoveWest);
            this.groupBox1.Controls.Add(this.btnMoveSouth);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(321, 601);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 190);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traversal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChoiceSearch);
            this.groupBox2.Controls.Add(this.btnChoiceEscape);
            this.groupBox2.Controls.Add(this.btnChoiceAttack);
            this.groupBox2.Controls.Add(this.btnChoiceTakeItem);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(707, 601);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 190);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnChoiceEscape
            // 
            this.btnChoiceEscape.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceEscape.Location = new System.Drawing.Point(53, 82);
            this.btnChoiceEscape.Name = "btnChoiceEscape";
            this.btnChoiceEscape.Size = new System.Drawing.Size(203, 46);
            this.btnChoiceEscape.TabIndex = 52;
            this.btnChoiceEscape.Text = "Escape";
            this.btnChoiceEscape.UseVisualStyleBackColor = true;
            this.btnChoiceEscape.Click += new System.EventHandler(this.btnChoiceEscape_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(67, 36);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(177, 22);
            this.lblPlayerName.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "STR:";
            this.toolTipMainForm.SetToolTip(this.label4, "Your current strength.\r\nStrength affects your chance to hit with attacks as well " +
        "as the damage you deal.\r\n");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "CON:";
            this.toolTipMainForm.SetToolTip(this.label5, "Your current constitution.\r\nConstitution determines your total maximum hitpoints." +
        "\r\n");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "PER:";
            this.toolTipMainForm.SetToolTip(this.label6, "Your current perception.\r\nPerception determines how good you are at finding hidde" +
        "n secrets.\r\n");
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(58, 73);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(0, 26);
            this.lblHP.TabIndex = 34;
            // 
            // lblCON
            // 
            this.lblCON.AutoSize = true;
            this.lblCON.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCON.Location = new System.Drawing.Point(66, 133);
            this.lblCON.Name = "lblCON";
            this.lblCON.Size = new System.Drawing.Size(0, 22);
            this.lblCON.TabIndex = 35;
            // 
            // lblPlayerWeapon
            // 
            this.lblPlayerWeapon.AutoSize = true;
            this.lblPlayerWeapon.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWeapon.Location = new System.Drawing.Point(90, 191);
            this.lblPlayerWeapon.Name = "lblPlayerWeapon";
            this.lblPlayerWeapon.Size = new System.Drawing.Size(0, 22);
            this.lblPlayerWeapon.TabIndex = 36;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(13, 73);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(45, 26);
            this.lbl1.TabIndex = 37;
            this.lbl1.Text = "HP:";
            this.toolTipMainForm.SetToolTip(this.lbl1, "Your current and maximum hitpoints.");
            // 
            // lblSTR
            // 
            this.lblSTR.AutoSize = true;
            this.lblSTR.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTR.Location = new System.Drawing.Point(66, 111);
            this.lblSTR.Name = "lblSTR";
            this.lblSTR.Size = new System.Drawing.Size(0, 22);
            this.lblSTR.TabIndex = 38;
            // 
            // lblHPMax
            // 
            this.lblHPMax.AutoSize = true;
            this.lblHPMax.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPMax.Location = new System.Drawing.Point(83, 73);
            this.lblHPMax.Name = "lblHPMax";
            this.lblHPMax.Size = new System.Drawing.Size(0, 22);
            this.lblHPMax.TabIndex = 39;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(569, 255);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(189, 53);
            this.btnStartGame.TabIndex = 40;
            this.btnStartGame.Text = "Delve into the Dungeon";
            this.toolTipMainForm.SetToolTip(this.btnStartGame, "Enter the Dungeon and start the game.");
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnUseItem
            // 
            this.btnUseItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseItem.Location = new System.Drawing.Point(17, 725);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(91, 66);
            this.btnUseItem.TabIndex = 4;
            this.btnUseItem.Text = "Use Item";
            this.toolTipMainForm.SetToolTip(this.btnUseItem, "Use a selected item in the list.\r\nSuch as a healing potion.\r\n");
            this.btnUseItem.UseVisualStyleBackColor = true;
            this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);
            // 
            // btnEquipItem
            // 
            this.btnEquipItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipItem.Location = new System.Drawing.Point(119, 725);
            this.btnEquipItem.Name = "btnEquipItem";
            this.btnEquipItem.Size = new System.Drawing.Size(91, 66);
            this.btnEquipItem.TabIndex = 41;
            this.btnEquipItem.Text = "Equip a selected item in the list.\r\nSuch as a weapon or accessory.";
            this.btnEquipItem.UseVisualStyleBackColor = true;
            this.btnEquipItem.Click += new System.EventHandler(this.btnEquipItem_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(14, 190);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(74, 22);
            this.lbl3.TabIndex = 42;
            this.lbl3.Text = "Weapon:";
            this.toolTipMainForm.SetToolTip(this.lbl3, "Your currently equipped weapon");
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(14, 246);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(74, 22);
            this.lbl4.TabIndex = 43;
            this.lbl4.Text = "Armour:";
            this.toolTipMainForm.SetToolTip(this.lbl4, "The armour you are currently wearing");
            // 
            // lblPlayerArmour
            // 
            this.lblPlayerArmour.AutoSize = true;
            this.lblPlayerArmour.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerArmour.Location = new System.Drawing.Point(90, 247);
            this.lblPlayerArmour.Name = "lblPlayerArmour";
            this.lblPlayerArmour.Size = new System.Drawing.Size(0, 22);
            this.lblPlayerArmour.TabIndex = 44;
            // 
            // lblPER
            // 
            this.lblPER.AutoSize = true;
            this.lblPER.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPER.Location = new System.Drawing.Point(67, 155);
            this.lblPER.Name = "lblPER";
            this.lblPER.Size = new System.Drawing.Size(0, 22);
            this.lblPER.TabIndex = 45;
            // 
            // lblPlayerWepDmg
            // 
            this.lblPlayerWepDmg.AutoSize = true;
            this.lblPlayerWepDmg.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWepDmg.Location = new System.Drawing.Point(90, 219);
            this.lblPlayerWepDmg.Name = "lblPlayerWepDmg";
            this.lblPlayerWepDmg.Size = new System.Drawing.Size(0, 22);
            this.lblPlayerWepDmg.TabIndex = 46;
            this.lblPlayerWepDmg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(14, 218);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(75, 22);
            this.lbl5.TabIndex = 47;
            this.lbl5.Text = "Damage:";
            this.toolTipMainForm.SetToolTip(this.lbl5, "The range of damage you can currently deal");
            // 
            // lblPlayerAccessory
            // 
            this.lblPlayerAccessory.AutoSize = true;
            this.lblPlayerAccessory.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAccessory.Location = new System.Drawing.Point(100, 275);
            this.lblPlayerAccessory.Name = "lblPlayerAccessory";
            this.lblPlayerAccessory.Size = new System.Drawing.Size(0, 22);
            this.lblPlayerAccessory.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 48;
            this.label7.Text = "Accessory:";
            this.toolTipMainForm.SetToolTip(this.label7, "The accessory you currently have equipped");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 696);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Total Value:";
            // 
            // lblInventoryValue
            // 
            this.lblInventoryValue.AutoSize = true;
            this.lblInventoryValue.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryValue.Location = new System.Drawing.Point(113, 696);
            this.lblInventoryValue.Name = "lblInventoryValue";
            this.lblInventoryValue.Size = new System.Drawing.Size(0, 22);
            this.lblInventoryValue.TabIndex = 51;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 803);
            this.Controls.Add(this.lblInventoryValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerAccessory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblPlayerWepDmg);
            this.Controls.Add(this.lblPER);
            this.Controls.Add(this.lblPlayerArmour);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnEquipItem);
            this.Controls.Add(this.btnUseItem);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblHPMax);
            this.Controls.Add(this.lblSTR);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblPlayerWeapon);
            this.Controls.Add(this.lblCON);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblYourLocationtxtBox);
            this.Controls.Add(this.lblActiontxtBox);
            this.Controls.Add(this.txtChoiceBox);
            this.Controls.Add(this.btnCreateCharacter);
            this.Controls.Add(this.txtGameWindow);
            this.Controls.Add(this.lboxInventory);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeon Crawler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveNorth;
        private System.Windows.Forms.Button btnMoveEast;
        private System.Windows.Forms.Button btnMoveWest;
        private System.Windows.Forms.Button btnMoveSouth;
        private System.Windows.Forms.ListBox lboxInventory;
        private System.Windows.Forms.RichTextBox txtGameWindow;
        private System.Windows.Forms.Button btnChoiceSearch;
        private System.Windows.Forms.Button btnChoiceTakeItem;
        private System.Windows.Forms.Button btnChoiceAttack;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateCharacter;
        private System.Windows.Forms.RichTextBox txtChoiceBox;
        private System.Windows.Forms.Label lblActiontxtBox;
        private System.Windows.Forms.Label lblYourLocationtxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblCON;
        private System.Windows.Forms.Label lblPlayerWeapon;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSTR;
        private System.Windows.Forms.Label lblHPMax;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.Button btnEquipItem;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblPlayerArmour;
        private System.Windows.Forms.Label lblPER;
        private System.Windows.Forms.Label lblPlayerWepDmg;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblPlayerAccessory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInventoryValue;
        private System.Windows.Forms.Button btnChoiceEscape;
        private System.Windows.Forms.ToolTip toolTipMainForm;
    }
}

