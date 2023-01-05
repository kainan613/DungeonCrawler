namespace DungeonCrawler
{
    partial class CharGenForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCharGenName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnStrengthAdd = new System.Windows.Forms.Button();
            this.btnStrenghtSubtract = new System.Windows.Forms.Button();
            this.lblStrengthPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConstitutionAdd = new System.Windows.Forms.Button();
            this.btnConstitutionSubtract = new System.Windows.Forms.Button();
            this.lblConstitutionPoints = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPerceptionAdd = new System.Windows.Forms.Button();
            this.btnPerceptionSubtract = new System.Windows.Forms.Button();
            this.lblPerceptionPoints = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSkillPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTipCharGenForm = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(55, 396);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 32);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.toolTipCharGenForm.SetToolTip(this.btnConfirm, "Finish your character and start the game");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(169, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.toolTipCharGenForm.SetToolTip(this.btnCancel, "Cancel character creation");
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCharGenName
            // 
            this.txtCharGenName.Location = new System.Drawing.Point(47, 46);
            this.txtCharGenName.MaxLength = 14;
            this.txtCharGenName.Name = "txtCharGenName";
            this.txtCharGenName.Size = new System.Drawing.Size(185, 20);
            this.txtCharGenName.TabIndex = 18;
            this.toolTipCharGenForm.SetToolTip(this.txtCharGenName, "The name of your character.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Character Name";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(92, 140);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(91, 26);
            this.lbl2.TabIndex = 20;
            this.lbl2.Text = "Strength";
            this.toolTipCharGenForm.SetToolTip(this.lbl2, "Strength increases your chance to hit with attacks\r\nand how much damage you do.");
            // 
            // btnStrengthAdd
            // 
            this.btnStrengthAdd.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrengthAdd.Location = new System.Drawing.Point(189, 165);
            this.btnStrengthAdd.Name = "btnStrengthAdd";
            this.btnStrengthAdd.Size = new System.Drawing.Size(43, 28);
            this.btnStrengthAdd.TabIndex = 21;
            this.btnStrengthAdd.Text = "+";
            this.toolTipCharGenForm.SetToolTip(this.btnStrengthAdd, "Add one strength.\r\nWill cost you one skillpoint.\r\n");
            this.btnStrengthAdd.UseVisualStyleBackColor = true;
            this.btnStrengthAdd.Click += new System.EventHandler(this.btnStrengthAdd_Click);
            // 
            // btnStrenghtSubtract
            // 
            this.btnStrenghtSubtract.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrenghtSubtract.Location = new System.Drawing.Point(43, 164);
            this.btnStrenghtSubtract.Name = "btnStrenghtSubtract";
            this.btnStrenghtSubtract.Size = new System.Drawing.Size(43, 28);
            this.btnStrenghtSubtract.TabIndex = 22;
            this.btnStrenghtSubtract.Text = "-";
            this.toolTipCharGenForm.SetToolTip(this.btnStrenghtSubtract, "Subtract one strength.\r\nWill give you one skillpoint.\r\n");
            this.btnStrenghtSubtract.UseVisualStyleBackColor = true;
            this.btnStrenghtSubtract.Click += new System.EventHandler(this.btnStrenghtSubtract_Click);
            // 
            // lblStrengthPoints
            // 
            this.lblStrengthPoints.AutoSize = true;
            this.lblStrengthPoints.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrengthPoints.Location = new System.Drawing.Point(122, 167);
            this.lblStrengthPoints.Name = "lblStrengthPoints";
            this.lblStrengthPoints.Size = new System.Drawing.Size(22, 26);
            this.lblStrengthPoints.TabIndex = 24;
            this.lblStrengthPoints.Text = "3";
            this.toolTipCharGenForm.SetToolTip(this.lblStrengthPoints, "Your current amount of strength");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Constitution";
            this.toolTipCharGenForm.SetToolTip(this.label5, "Constitution determines your total amount of hitpoints.\r\nEvery point of constitut" +
        "ion gives you two hitpoints.\r\n");
            // 
            // btnConstitutionAdd
            // 
            this.btnConstitutionAdd.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstitutionAdd.Location = new System.Drawing.Point(189, 247);
            this.btnConstitutionAdd.Name = "btnConstitutionAdd";
            this.btnConstitutionAdd.Size = new System.Drawing.Size(43, 28);
            this.btnConstitutionAdd.TabIndex = 26;
            this.btnConstitutionAdd.Text = "+";
            this.toolTipCharGenForm.SetToolTip(this.btnConstitutionAdd, "Add one constitution.\r\nWill cost you one skillpoint.");
            this.btnConstitutionAdd.UseVisualStyleBackColor = true;
            this.btnConstitutionAdd.Click += new System.EventHandler(this.btnConstitutionAdd_Click);
            // 
            // btnConstitutionSubtract
            // 
            this.btnConstitutionSubtract.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstitutionSubtract.Location = new System.Drawing.Point(43, 246);
            this.btnConstitutionSubtract.Name = "btnConstitutionSubtract";
            this.btnConstitutionSubtract.Size = new System.Drawing.Size(43, 28);
            this.btnConstitutionSubtract.TabIndex = 27;
            this.btnConstitutionSubtract.Text = "-";
            this.toolTipCharGenForm.SetToolTip(this.btnConstitutionSubtract, "Subtract one constitution.\r\nWill give you one skillpoint.");
            this.btnConstitutionSubtract.UseVisualStyleBackColor = true;
            this.btnConstitutionSubtract.Click += new System.EventHandler(this.btnConstitutionSubtract_Click);
            // 
            // lblConstitutionPoints
            // 
            this.lblConstitutionPoints.AutoSize = true;
            this.lblConstitutionPoints.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstitutionPoints.Location = new System.Drawing.Point(122, 249);
            this.lblConstitutionPoints.Name = "lblConstitutionPoints";
            this.lblConstitutionPoints.Size = new System.Drawing.Size(22, 26);
            this.lblConstitutionPoints.TabIndex = 28;
            this.lblConstitutionPoints.Text = "3";
            this.toolTipCharGenForm.SetToolTip(this.lblConstitutionPoints, "Your current amount of constitution");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 26);
            this.label8.TabIndex = 29;
            this.label8.Text = "Perception";
            this.toolTipCharGenForm.SetToolTip(this.label8, "Perception influnces how good you are at finding hidden secrets.\r\n");
            // 
            // btnPerceptionAdd
            // 
            this.btnPerceptionAdd.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerceptionAdd.Location = new System.Drawing.Point(189, 321);
            this.btnPerceptionAdd.Name = "btnPerceptionAdd";
            this.btnPerceptionAdd.Size = new System.Drawing.Size(43, 28);
            this.btnPerceptionAdd.TabIndex = 30;
            this.btnPerceptionAdd.Text = "+";
            this.toolTipCharGenForm.SetToolTip(this.btnPerceptionAdd, "Add one perception.\r\nWill cost you one skillpoint.");
            this.btnPerceptionAdd.UseVisualStyleBackColor = true;
            this.btnPerceptionAdd.Click += new System.EventHandler(this.btnPerceptionAdd_Click);
            // 
            // btnPerceptionSubtract
            // 
            this.btnPerceptionSubtract.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerceptionSubtract.Location = new System.Drawing.Point(43, 320);
            this.btnPerceptionSubtract.Name = "btnPerceptionSubtract";
            this.btnPerceptionSubtract.Size = new System.Drawing.Size(43, 28);
            this.btnPerceptionSubtract.TabIndex = 31;
            this.btnPerceptionSubtract.Text = "-";
            this.toolTipCharGenForm.SetToolTip(this.btnPerceptionSubtract, "Subtract one perception.\r\nWill give you one skillpoint.");
            this.btnPerceptionSubtract.UseVisualStyleBackColor = true;
            this.btnPerceptionSubtract.Click += new System.EventHandler(this.btnPerceptionSubtract_Click);
            // 
            // lblPerceptionPoints
            // 
            this.lblPerceptionPoints.AutoSize = true;
            this.lblPerceptionPoints.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerceptionPoints.Location = new System.Drawing.Point(122, 323);
            this.lblPerceptionPoints.Name = "lblPerceptionPoints";
            this.lblPerceptionPoints.Size = new System.Drawing.Size(22, 26);
            this.lblPerceptionPoints.TabIndex = 32;
            this.lblPerceptionPoints.Text = "3";
            this.toolTipCharGenForm.SetToolTip(this.lblPerceptionPoints, "Your current amount of perception.");
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(62, 99);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(120, 26);
            this.lbl1.TabIndex = 33;
            this.lbl1.Text = "Skill Points:";
            this.toolTipCharGenForm.SetToolTip(this.lbl1, "You can spend skillpoints to increase your core stats");
            // 
            // lblSkillPoints
            // 
            this.lblSkillPoints.AutoSize = true;
            this.lblSkillPoints.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillPoints.Location = new System.Drawing.Point(182, 99);
            this.lblSkillPoints.Name = "lblSkillPoints";
            this.lblSkillPoints.Size = new System.Drawing.Size(22, 26);
            this.lblSkillPoints.TabIndex = 34;
            this.lblSkillPoints.Text = "5";
            this.toolTipCharGenForm.SetToolTip(this.lblSkillPoints, "The amount of skillpoints you have to spend");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Hit Points:";
            this.toolTipCharGenForm.SetToolTip(this.label1, "Hitpoints defineshow much damage you can take before dying.\r\nThis is based on you" +
        "r constitution.\r\n");
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitPoints.Location = new System.Drawing.Point(178, 69);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(32, 26);
            this.lblHitPoints.TabIndex = 36;
            this.lblHitPoints.Text = "16";
            this.toolTipCharGenForm.SetToolTip(this.lblHitPoints, "Your current number of hitpoints, based on your constitution.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHitPoints);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSkillPoints);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lblPerceptionPoints);
            this.groupBox1.Controls.Add(this.btnPerceptionSubtract);
            this.groupBox1.Controls.Add(this.btnPerceptionAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblConstitutionPoints);
            this.groupBox1.Controls.Add(this.btnConstitutionSubtract);
            this.groupBox1.Controls.Add(this.btnConstitutionAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblStrengthPoints);
            this.groupBox1.Controls.Add(this.btnStrenghtSubtract);
            this.groupBox1.Controls.Add(this.btnStrengthAdd);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCharGenName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 378);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Creation";
            // 
            // CharGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 440);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharGenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Your Character";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CharGenForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtCharGenName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnStrengthAdd;
        private System.Windows.Forms.Button btnStrenghtSubtract;
        private System.Windows.Forms.Label lblStrengthPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConstitutionAdd;
        private System.Windows.Forms.Button btnConstitutionSubtract;
        private System.Windows.Forms.Label lblConstitutionPoints;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPerceptionAdd;
        private System.Windows.Forms.Button btnPerceptionSubtract;
        private System.Windows.Forms.Label lblPerceptionPoints;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSkillPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTipCharGenForm;
    }
}