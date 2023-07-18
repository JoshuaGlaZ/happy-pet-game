
namespace happy_pet_game_2019
{
    partial class FormBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBattle));
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            this.panelBattle = new System.Windows.Forms.Panel();
            this.labelDebuff = new System.Windows.Forms.Label();
            this.labelBuff = new System.Windows.Forms.Label();
            this.labelBattleNumber = new System.Windows.Forms.Label();
            this.labelSkillPoint = new System.Windows.Forms.Label();
            this.groupBoxPetAction = new System.Windows.Forms.GroupBox();
            this.buttonBasicAttack = new System.Windows.Forms.Button();
            this.buttonSkill = new System.Windows.Forms.Button();
            this.buttonUlti = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelSelectEnemy = new System.Windows.Forms.Panel();
            this.Door2 = new System.Windows.Forms.ListBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.radioButtonDoor1 = new System.Windows.Forms.RadioButton();
            this.radioButtonDoor2 = new System.Windows.Forms.RadioButton();
            this.Door1 = new System.Windows.Forms.ListBox();
            this.panelStat = new System.Windows.Forms.Panel();
            this.listBoxLevelUp = new System.Windows.Forms.ListBox();
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.radioButtonAtkSpeed = new System.Windows.Forms.RadioButton();
            this.radioButtonHappinessGain = new System.Windows.Forms.RadioButton();
            this.radioButtonDefense = new System.Windows.Forms.RadioButton();
            this.radioButtonEnergy = new System.Windows.Forms.RadioButton();
            this.radioButtonMaxHealth = new System.Windows.Forms.RadioButton();
            this.labelLevelPoint = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBattle.SuspendLayout();
            this.groupBoxPetAction.SuspendLayout();
            this.panelSelectEnemy.SuspendLayout();
            this.panelStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBattle
            // 
            this.timerBattle.Interval = 1;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // panelBattle
            // 
            this.panelBattle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelBattle.Controls.Add(this.pictureBox1);
            this.panelBattle.Controls.Add(this.labelDebuff);
            this.panelBattle.Controls.Add(this.labelBuff);
            this.panelBattle.Controls.Add(this.labelBattleNumber);
            this.panelBattle.Controls.Add(this.labelSkillPoint);
            this.panelBattle.Controls.Add(this.groupBoxPetAction);
            this.panelBattle.Controls.Add(this.listBox1);
            this.panelBattle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBattle.Location = new System.Drawing.Point(0, 0);
            this.panelBattle.Name = "panelBattle";
            this.panelBattle.Size = new System.Drawing.Size(0, 500);
            this.panelBattle.TabIndex = 26;
            // 
            // labelDebuff
            // 
            this.labelDebuff.AutoSize = true;
            this.labelDebuff.Location = new System.Drawing.Point(488, 30);
            this.labelDebuff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDebuff.Name = "labelDebuff";
            this.labelDebuff.Size = new System.Drawing.Size(62, 13);
            this.labelDebuff.TabIndex = 23;
            this.labelDebuff.Text = "label debuff";
            // 
            // labelBuff
            // 
            this.labelBuff.AutoSize = true;
            this.labelBuff.Location = new System.Drawing.Point(393, 30);
            this.labelBuff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuff.Name = "labelBuff";
            this.labelBuff.Size = new System.Drawing.Size(50, 13);
            this.labelBuff.TabIndex = 22;
            this.labelBuff.Text = "label buff";
            // 
            // labelBattleNumber
            // 
            this.labelBattleNumber.AutoSize = true;
            this.labelBattleNumber.Location = new System.Drawing.Point(123, 30);
            this.labelBattleNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBattleNumber.Name = "labelBattleNumber";
            this.labelBattleNumber.Size = new System.Drawing.Size(96, 13);
            this.labelBattleNumber.TabIndex = 19;
            this.labelBattleNumber.Text = "label battle number";
            // 
            // labelSkillPoint
            // 
            this.labelSkillPoint.AutoSize = true;
            this.labelSkillPoint.Location = new System.Drawing.Point(270, 30);
            this.labelSkillPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSkillPoint.Name = "labelSkillPoint";
            this.labelSkillPoint.Size = new System.Drawing.Size(72, 13);
            this.labelSkillPoint.TabIndex = 21;
            this.labelSkillPoint.Text = "label skill poin";
            // 
            // groupBoxPetAction
            // 
            this.groupBoxPetAction.Controls.Add(this.buttonBasicAttack);
            this.groupBoxPetAction.Controls.Add(this.buttonSkill);
            this.groupBoxPetAction.Controls.Add(this.buttonUlti);
            this.groupBoxPetAction.Location = new System.Drawing.Point(126, 268);
            this.groupBoxPetAction.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPetAction.Name = "groupBoxPetAction";
            this.groupBoxPetAction.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPetAction.Size = new System.Drawing.Size(479, 82);
            this.groupBoxPetAction.TabIndex = 20;
            this.groupBoxPetAction.TabStop = false;
            this.groupBoxPetAction.Text = "pet attack";
            // 
            // buttonBasicAttack
            // 
            this.buttonBasicAttack.Location = new System.Drawing.Point(53, 16);
            this.buttonBasicAttack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBasicAttack.Name = "buttonBasicAttack";
            this.buttonBasicAttack.Size = new System.Drawing.Size(122, 62);
            this.buttonBasicAttack.TabIndex = 15;
            this.buttonBasicAttack.Text = "Basic Attack";
            this.buttonBasicAttack.UseVisualStyleBackColor = true;
            // 
            // buttonSkill
            // 
            this.buttonSkill.Location = new System.Drawing.Point(179, 16);
            this.buttonSkill.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSkill.Name = "buttonSkill";
            this.buttonSkill.Size = new System.Drawing.Size(122, 62);
            this.buttonSkill.TabIndex = 14;
            this.buttonSkill.Text = "Skill";
            this.buttonSkill.UseVisualStyleBackColor = true;
            // 
            // buttonUlti
            // 
            this.buttonUlti.Location = new System.Drawing.Point(305, 16);
            this.buttonUlti.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUlti.Name = "buttonUlti";
            this.buttonUlti.Size = new System.Drawing.Size(122, 62);
            this.buttonUlti.TabIndex = 13;
            this.buttonUlti.Text = "Ulti";
            this.buttonUlti.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(126, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(481, 212);
            this.listBox1.TabIndex = 18;
            // 
            // panelSelectEnemy
            // 
            this.panelSelectEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelSelectEnemy.Controls.Add(this.Door2);
            this.panelSelectEnemy.Controls.Add(this.buttonGo);
            this.panelSelectEnemy.Controls.Add(this.radioButtonDoor1);
            this.panelSelectEnemy.Controls.Add(this.radioButtonDoor2);
            this.panelSelectEnemy.Controls.Add(this.Door1);
            this.panelSelectEnemy.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelectEnemy.Location = new System.Drawing.Point(0, 0);
            this.panelSelectEnemy.Name = "panelSelectEnemy";
            this.panelSelectEnemy.Size = new System.Drawing.Size(0, 500);
            this.panelSelectEnemy.TabIndex = 24;
            // 
            // Door2
            // 
            this.Door2.FormattingEnabled = true;
            this.Door2.Location = new System.Drawing.Point(709, 57);
            this.Door2.Margin = new System.Windows.Forms.Padding(2);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(120, 212);
            this.Door2.TabIndex = 13;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(576, 273);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(252, 82);
            this.buttonGo.TabIndex = 14;
            this.buttonGo.Text = "GO !";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoor1
            // 
            this.radioButtonDoor1.AutoSize = true;
            this.radioButtonDoor1.Location = new System.Drawing.Point(602, 35);
            this.radioButtonDoor1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDoor1.Name = "radioButtonDoor1";
            this.radioButtonDoor1.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDoor1.TabIndex = 10;
            this.radioButtonDoor1.TabStop = true;
            this.radioButtonDoor1.Text = "Door 1";
            this.radioButtonDoor1.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoor2
            // 
            this.radioButtonDoor2.AutoSize = true;
            this.radioButtonDoor2.Location = new System.Drawing.Point(733, 35);
            this.radioButtonDoor2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDoor2.Name = "radioButtonDoor2";
            this.radioButtonDoor2.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDoor2.TabIndex = 11;
            this.radioButtonDoor2.TabStop = true;
            this.radioButtonDoor2.Text = "Door 2";
            this.radioButtonDoor2.UseVisualStyleBackColor = true;
            // 
            // Door1
            // 
            this.Door1.FormattingEnabled = true;
            this.Door1.Location = new System.Drawing.Point(576, 57);
            this.Door1.Margin = new System.Windows.Forms.Padding(2);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(120, 212);
            this.Door1.TabIndex = 12;
            // 
            // panelStat
            // 
            this.panelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelStat.Controls.Add(this.listBoxLevelUp);
            this.panelStat.Controls.Add(this.buttonUpgrade);
            this.panelStat.Controls.Add(this.radioButtonAtkSpeed);
            this.panelStat.Controls.Add(this.radioButtonHappinessGain);
            this.panelStat.Controls.Add(this.radioButtonDefense);
            this.panelStat.Controls.Add(this.radioButtonEnergy);
            this.panelStat.Controls.Add(this.radioButtonMaxHealth);
            this.panelStat.Controls.Add(this.labelLevelPoint);
            this.panelStat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat.Location = new System.Drawing.Point(0, 0);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(1000, 500);
            this.panelStat.TabIndex = 26;
            // 
            // listBoxLevelUp
            // 
            this.listBoxLevelUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxLevelUp.FormattingEnabled = true;
            this.listBoxLevelUp.Location = new System.Drawing.Point(421, 83);
            this.listBoxLevelUp.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLevelUp.Name = "listBoxLevelUp";
            this.listBoxLevelUp.Size = new System.Drawing.Size(224, 186);
            this.listBoxLevelUp.TabIndex = 33;
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpgrade.Location = new System.Drawing.Point(251, 209);
            this.buttonUpgrade.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(166, 57);
            this.buttonUpgrade.TabIndex = 32;
            this.buttonUpgrade.Text = "upgrade";
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtkSpeed
            // 
            this.radioButtonAtkSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAtkSpeed.AutoSize = true;
            this.radioButtonAtkSpeed.Location = new System.Drawing.Point(251, 189);
            this.radioButtonAtkSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAtkSpeed.Name = "radioButtonAtkSpeed";
            this.radioButtonAtkSpeed.Size = new System.Drawing.Size(96, 17);
            this.radioButtonAtkSpeed.TabIndex = 31;
            this.radioButtonAtkSpeed.TabStop = true;
            this.radioButtonAtkSpeed.Text = "AtkSpeed +0.1";
            this.radioButtonAtkSpeed.UseVisualStyleBackColor = true;
            // 
            // radioButtonHappinessGain
            // 
            this.radioButtonHappinessGain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHappinessGain.AutoSize = true;
            this.radioButtonHappinessGain.Location = new System.Drawing.Point(251, 170);
            this.radioButtonHappinessGain.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHappinessGain.Name = "radioButtonHappinessGain";
            this.radioButtonHappinessGain.Size = new System.Drawing.Size(112, 17);
            this.radioButtonHappinessGain.TabIndex = 30;
            this.radioButtonHappinessGain.TabStop = true;
            this.radioButtonHappinessGain.Text = "HappinessGain +2";
            this.radioButtonHappinessGain.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefense
            // 
            this.radioButtonDefense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonDefense.AutoSize = true;
            this.radioButtonDefense.Location = new System.Drawing.Point(251, 152);
            this.radioButtonDefense.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDefense.Name = "radioButtonDefense";
            this.radioButtonDefense.Size = new System.Drawing.Size(86, 17);
            this.radioButtonDefense.TabIndex = 29;
            this.radioButtonDefense.TabStop = true;
            this.radioButtonDefense.Text = "Defense +50";
            this.radioButtonDefense.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnergy
            // 
            this.radioButtonEnergy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonEnergy.AutoSize = true;
            this.radioButtonEnergy.Location = new System.Drawing.Point(251, 135);
            this.radioButtonEnergy.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEnergy.Name = "radioButtonEnergy";
            this.radioButtonEnergy.Size = new System.Drawing.Size(79, 17);
            this.radioButtonEnergy.TabIndex = 28;
            this.radioButtonEnergy.TabStop = true;
            this.radioButtonEnergy.Text = "Energy +25";
            this.radioButtonEnergy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaxHealth
            // 
            this.radioButtonMaxHealth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMaxHealth.AutoSize = true;
            this.radioButtonMaxHealth.Location = new System.Drawing.Point(251, 116);
            this.radioButtonMaxHealth.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMaxHealth.Name = "radioButtonMaxHealth";
            this.radioButtonMaxHealth.Size = new System.Drawing.Size(103, 17);
            this.radioButtonMaxHealth.TabIndex = 27;
            this.radioButtonMaxHealth.TabStop = true;
            this.radioButtonMaxHealth.Text = "MaxHealth +250";
            this.radioButtonMaxHealth.UseVisualStyleBackColor = true;
            // 
            // labelLevelPoint
            // 
            this.labelLevelPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLevelPoint.AutoSize = true;
            this.labelLevelPoint.Location = new System.Drawing.Point(248, 94);
            this.labelLevelPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevelPoint.Name = "labelLevelPoint";
            this.labelLevelPoint.Size = new System.Drawing.Size(80, 13);
            this.labelLevelPoint.TabIndex = 26;
            this.labelLevelPoint.Text = "label level point";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(650, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 24);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FormBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelStat);
            this.Controls.Add(this.panelSelectEnemy);
            this.Controls.Add(this.panelBattle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBattle";
            this.Text = "Form Battle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBattle_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBattle.ResumeLayout(false);
            this.panelBattle.PerformLayout();
            this.groupBoxPetAction.ResumeLayout(false);
            this.panelSelectEnemy.ResumeLayout(false);
            this.panelSelectEnemy.PerformLayout();
            this.panelStat.ResumeLayout(false);
            this.panelStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerBattle;
        private System.Windows.Forms.Panel panelBattle;
        private System.Windows.Forms.Label labelDebuff;
        private System.Windows.Forms.Label labelBuff;
        private System.Windows.Forms.Label labelBattleNumber;
        private System.Windows.Forms.Label labelSkillPoint;
        private System.Windows.Forms.GroupBox groupBoxPetAction;
        private System.Windows.Forms.Button buttonBasicAttack;
        private System.Windows.Forms.Button buttonSkill;
        private System.Windows.Forms.Button buttonUlti;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panelSelectEnemy;
        private System.Windows.Forms.ListBox Door2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RadioButton radioButtonDoor1;
        private System.Windows.Forms.RadioButton radioButtonDoor2;
        private System.Windows.Forms.ListBox Door1;
        private System.Windows.Forms.Panel panelStat;
        private System.Windows.Forms.ListBox listBoxLevelUp;
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.RadioButton radioButtonAtkSpeed;
        private System.Windows.Forms.RadioButton radioButtonHappinessGain;
        private System.Windows.Forms.RadioButton radioButtonDefense;
        private System.Windows.Forms.RadioButton radioButtonEnergy;
        private System.Windows.Forms.RadioButton radioButtonMaxHealth;
        private System.Windows.Forms.Label labelLevelPoint;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

