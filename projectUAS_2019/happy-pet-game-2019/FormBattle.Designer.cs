
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelBattleResult = new System.Windows.Forms.Label();
            this.labelTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDebuff = new System.Windows.Forms.Label();
            this.labelBuff = new System.Windows.Forms.Label();
            this.labelBattleNumber = new System.Windows.Forms.Label();
            this.labelSkillPoint = new System.Windows.Forms.Label();
            this.groupBoxPetAction = new System.Windows.Forms.GroupBox();
            this.buttonBasicAttack = new System.Windows.Forms.Button();
            this.buttonSkill = new System.Windows.Forms.Button();
            this.buttonUlti = new System.Windows.Forms.Button();
            this.panelAfterBattle = new System.Windows.Forms.Panel();
            this.groupBoxChooseEnemy = new System.Windows.Forms.GroupBox();
            this.Door2 = new System.Windows.Forms.ListBox();
            this.Door1 = new System.Windows.Forms.ListBox();
            this.radioButtonDoor2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDoor1 = new System.Windows.Forms.RadioButton();
            this.buttonGo = new System.Windows.Forms.Button();
            this.groupBoxPetStat = new System.Windows.Forms.GroupBox();
            this.labelExpReward = new System.Windows.Forms.Label();
            this.labelCoinsReward = new System.Windows.Forms.Label();
            this.listBoxLevelUp = new System.Windows.Forms.ListBox();
            this.labelLevelPoint = new System.Windows.Forms.Label();
            this.radioButtonMaxHealth = new System.Windows.Forms.RadioButton();
            this.radioButtonEnergy = new System.Windows.Forms.RadioButton();
            this.radioButtonDefense = new System.Windows.Forms.RadioButton();
            this.radioButtonHappinessGain = new System.Windows.Forms.RadioButton();
            this.radioButtonAtkSpeed = new System.Windows.Forms.RadioButton();
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.pictureBoxPetDisplay = new System.Windows.Forms.PictureBox();
            this.pictureBoxProgress = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyHealth = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.pictureBoxBattle = new System.Windows.Forms.PictureBox();
            this.pictureBoxPetHealth = new System.Windows.Forms.PictureBox();
            this.panelBattle.SuspendLayout();
            this.groupBoxPetAction.SuspendLayout();
            this.panelAfterBattle.SuspendLayout();
            this.groupBoxChooseEnemy.SuspendLayout();
            this.groupBoxPetStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetHealth)).BeginInit();
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
            this.panelBattle.Controls.Add(this.buttonExit);
            this.panelBattle.Controls.Add(this.listBox2);
            this.panelBattle.Controls.Add(this.listBox1);
            this.panelBattle.Controls.Add(this.labelBattleResult);
            this.panelBattle.Controls.Add(this.pictureBoxEnemyHealth);
            this.panelBattle.Controls.Add(this.labelTurn);
            this.panelBattle.Controls.Add(this.label1);
            this.panelBattle.Controls.Add(this.pictureBoxEnemy);
            this.panelBattle.Controls.Add(this.pictureBoxPet);
            this.panelBattle.Controls.Add(this.pictureBoxBattle);
            this.panelBattle.Controls.Add(this.pictureBoxPetHealth);
            this.panelBattle.Controls.Add(this.labelDebuff);
            this.panelBattle.Controls.Add(this.labelBuff);
            this.panelBattle.Controls.Add(this.labelBattleNumber);
            this.panelBattle.Controls.Add(this.labelSkillPoint);
            this.panelBattle.Controls.Add(this.groupBoxPetAction);
            this.panelBattle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBattle.Location = new System.Drawing.Point(0, 0);
            this.panelBattle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBattle.Name = "panelBattle";
            this.panelBattle.Size = new System.Drawing.Size(1500, 769);
            this.panelBattle.TabIndex = 26;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1331, 30);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 65);
            this.buttonExit.TabIndex = 34;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(1145, 161);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(248, 224);
            this.listBox2.TabIndex = 33;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(121, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 224);
            this.listBox1.TabIndex = 32;
            // 
            // labelBattleResult
            // 
            this.labelBattleResult.AutoSize = true;
            this.labelBattleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelBattleResult.Location = new System.Drawing.Point(480, 316);
            this.labelBattleResult.Name = "labelBattleResult";
            this.labelBattleResult.Size = new System.Drawing.Size(583, 69);
            this.labelBattleResult.TabIndex = 31;
            this.labelBattleResult.Text = "(GAME OVER/ WIN)";
            this.labelBattleResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelTurn.Location = new System.Drawing.Point(637, 215);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(277, 46);
            this.labelTurn.TabIndex = 29;
            this.labelTurn.Text = "(PET/ENEMY)";
            this.labelTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(693, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 46);
            this.label1.TabIndex = 28;
            this.label1.Text = "TURN :";
            // 
            // labelDebuff
            // 
            this.labelDebuff.AutoSize = true;
            this.labelDebuff.Location = new System.Drawing.Point(630, 75);
            this.labelDebuff.Name = "labelDebuff";
            this.labelDebuff.Size = new System.Drawing.Size(92, 20);
            this.labelDebuff.TabIndex = 23;
            this.labelDebuff.Text = "label debuff";
            // 
            // labelBuff
            // 
            this.labelBuff.AutoSize = true;
            this.labelBuff.Location = new System.Drawing.Point(488, 75);
            this.labelBuff.Name = "labelBuff";
            this.labelBuff.Size = new System.Drawing.Size(74, 20);
            this.labelBuff.TabIndex = 22;
            this.labelBuff.Text = "label buff";
            // 
            // labelBattleNumber
            // 
            this.labelBattleNumber.AutoSize = true;
            this.labelBattleNumber.Location = new System.Drawing.Point(94, 75);
            this.labelBattleNumber.Name = "labelBattleNumber";
            this.labelBattleNumber.Size = new System.Drawing.Size(144, 20);
            this.labelBattleNumber.TabIndex = 19;
            this.labelBattleNumber.Text = "label battle number";
            // 
            // labelSkillPoint
            // 
            this.labelSkillPoint.AutoSize = true;
            this.labelSkillPoint.Location = new System.Drawing.Point(303, 75);
            this.labelSkillPoint.Name = "labelSkillPoint";
            this.labelSkillPoint.Size = new System.Drawing.Size(105, 20);
            this.labelSkillPoint.TabIndex = 21;
            this.labelSkillPoint.Text = "label skill poin";
            // 
            // groupBoxPetAction
            // 
            this.groupBoxPetAction.Controls.Add(this.buttonBasicAttack);
            this.groupBoxPetAction.Controls.Add(this.buttonSkill);
            this.groupBoxPetAction.Controls.Add(this.buttonUlti);
            this.groupBoxPetAction.Location = new System.Drawing.Point(86, 591);
            this.groupBoxPetAction.Name = "groupBoxPetAction";
            this.groupBoxPetAction.Size = new System.Drawing.Size(1334, 126);
            this.groupBoxPetAction.TabIndex = 20;
            this.groupBoxPetAction.TabStop = false;
            this.groupBoxPetAction.Text = "pet attack";
            // 
            // buttonBasicAttack
            // 
            this.buttonBasicAttack.Location = new System.Drawing.Point(12, 25);
            this.buttonBasicAttack.Name = "buttonBasicAttack";
            this.buttonBasicAttack.Size = new System.Drawing.Size(420, 95);
            this.buttonBasicAttack.TabIndex = 15;
            this.buttonBasicAttack.Text = "Basic Attack";
            this.buttonBasicAttack.UseVisualStyleBackColor = true;
            this.buttonBasicAttack.Click += new System.EventHandler(this.buttonBasicAttack_Click);
            // 
            // buttonSkill
            // 
            this.buttonSkill.Location = new System.Drawing.Point(466, 25);
            this.buttonSkill.Name = "buttonSkill";
            this.buttonSkill.Size = new System.Drawing.Size(420, 95);
            this.buttonSkill.TabIndex = 14;
            this.buttonSkill.Text = "Skill";
            this.buttonSkill.UseVisualStyleBackColor = true;
            this.buttonSkill.Click += new System.EventHandler(this.buttonSkill_Click);
            // 
            // buttonUlti
            // 
            this.buttonUlti.Location = new System.Drawing.Point(908, 25);
            this.buttonUlti.Name = "buttonUlti";
            this.buttonUlti.Size = new System.Drawing.Size(420, 95);
            this.buttonUlti.TabIndex = 13;
            this.buttonUlti.Text = "Ulti";
            this.buttonUlti.UseVisualStyleBackColor = true;
            this.buttonUlti.Click += new System.EventHandler(this.buttonUlti_Click);
            // 
            // panelAfterBattle
            // 
            this.panelAfterBattle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelAfterBattle.Controls.Add(this.groupBoxChooseEnemy);
            this.panelAfterBattle.Controls.Add(this.groupBoxPetStat);
            this.panelAfterBattle.Controls.Add(this.buttonExit2);
            this.panelAfterBattle.Controls.Add(this.pictureBoxProgress);
            this.panelAfterBattle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAfterBattle.Location = new System.Drawing.Point(1500, 0);
            this.panelAfterBattle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAfterBattle.Name = "panelAfterBattle";
            this.panelAfterBattle.Size = new System.Drawing.Size(0, 769);
            this.panelAfterBattle.TabIndex = 26;
            // 
            // groupBoxChooseEnemy
            // 
            this.groupBoxChooseEnemy.Controls.Add(this.Door2);
            this.groupBoxChooseEnemy.Controls.Add(this.Door1);
            this.groupBoxChooseEnemy.Controls.Add(this.radioButtonDoor2);
            this.groupBoxChooseEnemy.Controls.Add(this.radioButtonDoor1);
            this.groupBoxChooseEnemy.Controls.Add(this.buttonGo);
            this.groupBoxChooseEnemy.Location = new System.Drawing.Point(728, 169);
            this.groupBoxChooseEnemy.Name = "groupBoxChooseEnemy";
            this.groupBoxChooseEnemy.Size = new System.Drawing.Size(641, 570);
            this.groupBoxChooseEnemy.TabIndex = 35;
            this.groupBoxChooseEnemy.TabStop = false;
            this.groupBoxChooseEnemy.Text = "Choose next enemy";
            // 
            // Door2
            // 
            this.Door2.FormattingEnabled = true;
            this.Door2.ItemHeight = 20;
            this.Door2.Location = new System.Drawing.Point(317, 53);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(300, 404);
            this.Door2.TabIndex = 38;
            // 
            // Door1
            // 
            this.Door1.FormattingEnabled = true;
            this.Door1.ItemHeight = 20;
            this.Door1.Location = new System.Drawing.Point(11, 53);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(300, 404);
            this.Door1.TabIndex = 37;
            // 
            // radioButtonDoor2
            // 
            this.radioButtonDoor2.AutoSize = true;
            this.radioButtonDoor2.Location = new System.Drawing.Point(317, 23);
            this.radioButtonDoor2.Name = "radioButtonDoor2";
            this.radioButtonDoor2.Size = new System.Drawing.Size(82, 24);
            this.radioButtonDoor2.TabIndex = 36;
            this.radioButtonDoor2.TabStop = true;
            this.radioButtonDoor2.Text = "Door 2";
            this.radioButtonDoor2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoor1
            // 
            this.radioButtonDoor1.AutoSize = true;
            this.radioButtonDoor1.Location = new System.Drawing.Point(11, 23);
            this.radioButtonDoor1.Name = "radioButtonDoor1";
            this.radioButtonDoor1.Size = new System.Drawing.Size(82, 24);
            this.radioButtonDoor1.TabIndex = 35;
            this.radioButtonDoor1.TabStop = true;
            this.radioButtonDoor1.Text = "Door 1";
            this.radioButtonDoor1.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(11, 463);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(606, 98);
            this.buttonGo.TabIndex = 39;
            this.buttonGo.Text = "GO !";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // groupBoxPetStat
            // 
            this.groupBoxPetStat.Controls.Add(this.labelExpReward);
            this.groupBoxPetStat.Controls.Add(this.labelCoinsReward);
            this.groupBoxPetStat.Controls.Add(this.listBoxLevelUp);
            this.groupBoxPetStat.Controls.Add(this.labelLevelPoint);
            this.groupBoxPetStat.Controls.Add(this.radioButtonMaxHealth);
            this.groupBoxPetStat.Controls.Add(this.radioButtonEnergy);
            this.groupBoxPetStat.Controls.Add(this.radioButtonDefense);
            this.groupBoxPetStat.Controls.Add(this.radioButtonHappinessGain);
            this.groupBoxPetStat.Controls.Add(this.radioButtonAtkSpeed);
            this.groupBoxPetStat.Controls.Add(this.buttonUpgrade);
            this.groupBoxPetStat.Controls.Add(this.pictureBoxPetDisplay);
            this.groupBoxPetStat.Location = new System.Drawing.Point(62, 160);
            this.groupBoxPetStat.Name = "groupBoxPetStat";
            this.groupBoxPetStat.Size = new System.Drawing.Size(660, 579);
            this.groupBoxPetStat.TabIndex = 42;
            this.groupBoxPetStat.TabStop = false;
            this.groupBoxPetStat.Text = "pet stat";
            // 
            // labelExpReward
            // 
            this.labelExpReward.AutoSize = true;
            this.labelExpReward.Location = new System.Drawing.Point(257, 32);
            this.labelExpReward.Name = "labelExpReward";
            this.labelExpReward.Size = new System.Drawing.Size(103, 20);
            this.labelExpReward.TabIndex = 36;
            this.labelExpReward.Text = "Exp Reward :";
            // 
            // labelCoinsReward
            // 
            this.labelCoinsReward.AutoSize = true;
            this.labelCoinsReward.Location = new System.Drawing.Point(38, 32);
            this.labelCoinsReward.Name = "labelCoinsReward";
            this.labelCoinsReward.Size = new System.Drawing.Size(116, 20);
            this.labelCoinsReward.TabIndex = 35;
            this.labelCoinsReward.Text = "Coins Reward :";
            // 
            // listBoxLevelUp
            // 
            this.listBoxLevelUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxLevelUp.FormattingEnabled = true;
            this.listBoxLevelUp.ItemHeight = 20;
            this.listBoxLevelUp.Location = new System.Drawing.Point(294, 329);
            this.listBoxLevelUp.Name = "listBoxLevelUp";
            this.listBoxLevelUp.Size = new System.Drawing.Size(331, 244);
            this.listBoxLevelUp.TabIndex = 33;
            // 
            // labelLevelPoint
            // 
            this.labelLevelPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLevelPoint.AutoSize = true;
            this.labelLevelPoint.Location = new System.Drawing.Point(34, 336);
            this.labelLevelPoint.Name = "labelLevelPoint";
            this.labelLevelPoint.Size = new System.Drawing.Size(116, 20);
            this.labelLevelPoint.TabIndex = 26;
            this.labelLevelPoint.Text = "label level point";
            // 
            // radioButtonMaxHealth
            // 
            this.radioButtonMaxHealth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMaxHealth.AutoSize = true;
            this.radioButtonMaxHealth.Location = new System.Drawing.Point(38, 369);
            this.radioButtonMaxHealth.Name = "radioButtonMaxHealth";
            this.radioButtonMaxHealth.Size = new System.Drawing.Size(150, 24);
            this.radioButtonMaxHealth.TabIndex = 27;
            this.radioButtonMaxHealth.TabStop = true;
            this.radioButtonMaxHealth.Text = "MaxHealth +250";
            this.radioButtonMaxHealth.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnergy
            // 
            this.radioButtonEnergy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonEnergy.AutoSize = true;
            this.radioButtonEnergy.Location = new System.Drawing.Point(38, 399);
            this.radioButtonEnergy.Name = "radioButtonEnergy";
            this.radioButtonEnergy.Size = new System.Drawing.Size(115, 24);
            this.radioButtonEnergy.TabIndex = 28;
            this.radioButtonEnergy.TabStop = true;
            this.radioButtonEnergy.Text = "Energy +25";
            this.radioButtonEnergy.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefense
            // 
            this.radioButtonDefense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonDefense.AutoSize = true;
            this.radioButtonDefense.Location = new System.Drawing.Point(38, 425);
            this.radioButtonDefense.Name = "radioButtonDefense";
            this.radioButtonDefense.Size = new System.Drawing.Size(126, 24);
            this.radioButtonDefense.TabIndex = 29;
            this.radioButtonDefense.TabStop = true;
            this.radioButtonDefense.Text = "Defense +50";
            this.radioButtonDefense.UseVisualStyleBackColor = true;
            // 
            // radioButtonHappinessGain
            // 
            this.radioButtonHappinessGain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHappinessGain.AutoSize = true;
            this.radioButtonHappinessGain.Location = new System.Drawing.Point(38, 453);
            this.radioButtonHappinessGain.Name = "radioButtonHappinessGain";
            this.radioButtonHappinessGain.Size = new System.Drawing.Size(166, 24);
            this.radioButtonHappinessGain.TabIndex = 30;
            this.radioButtonHappinessGain.TabStop = true;
            this.radioButtonHappinessGain.Text = "HappinessGain +2";
            this.radioButtonHappinessGain.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtkSpeed
            // 
            this.radioButtonAtkSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAtkSpeed.AutoSize = true;
            this.radioButtonAtkSpeed.Location = new System.Drawing.Point(38, 482);
            this.radioButtonAtkSpeed.Name = "radioButtonAtkSpeed";
            this.radioButtonAtkSpeed.Size = new System.Drawing.Size(140, 24);
            this.radioButtonAtkSpeed.TabIndex = 31;
            this.radioButtonAtkSpeed.TabStop = true;
            this.radioButtonAtkSpeed.Text = "AtkSpeed +0.1";
            this.radioButtonAtkSpeed.UseVisualStyleBackColor = true;
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpgrade.Location = new System.Drawing.Point(38, 513);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(200, 57);
            this.buttonUpgrade.TabIndex = 32;
            this.buttonUpgrade.Text = "upgrade";
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // buttonExit2
            // 
            this.buttonExit2.Location = new System.Drawing.Point(1406, 30);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(75, 65);
            this.buttonExit2.TabIndex = 41;
            this.buttonExit2.Text = "Exit";
            this.buttonExit2.UseVisualStyleBackColor = true;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit2_Click);
            // 
            // pictureBoxPetDisplay
            // 
            this.pictureBoxPetDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBoxPetDisplay.Image = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxPetDisplay.Location = new System.Drawing.Point(38, 62);
            this.pictureBoxPetDisplay.Name = "pictureBoxPetDisplay";
            this.pictureBoxPetDisplay.Size = new System.Drawing.Size(587, 261);
            this.pictureBoxPetDisplay.TabIndex = 34;
            this.pictureBoxPetDisplay.TabStop = false;
            // 
            // pictureBoxProgress
            // 
            this.pictureBoxProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxProgress.Location = new System.Drawing.Point(62, 30);
            this.pictureBoxProgress.Name = "pictureBoxProgress";
            this.pictureBoxProgress.Size = new System.Drawing.Size(1307, 114);
            this.pictureBoxProgress.TabIndex = 40;
            this.pictureBoxProgress.TabStop = false;
            // 
            // pictureBoxEnemyHealth
            // 
            this.pictureBoxEnemyHealth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyHealth.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyHealth.Image")));
            this.pictureBoxEnemyHealth.Location = new System.Drawing.Point(1262, 117);
            this.pictureBoxEnemyHealth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxEnemyHealth.Name = "pictureBoxEnemyHealth";
            this.pictureBoxEnemyHealth.Size = new System.Drawing.Size(158, 24);
            this.pictureBoxEnemyHealth.TabIndex = 30;
            this.pictureBoxEnemyHealth.TabStop = false;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.ErrorImage = null;
            this.pictureBoxEnemy.Image = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(1211, 389);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(182, 150);
            this.pictureBoxEnemy.TabIndex = 27;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.ErrorImage = null;
            this.pictureBoxPet.Image = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxPet.InitialImage = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxPet.Location = new System.Drawing.Point(121, 389);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(182, 150);
            this.pictureBoxPet.TabIndex = 26;
            this.pictureBoxPet.TabStop = false;
            // 
            // pictureBoxBattle
            // 
            this.pictureBoxBattle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBoxBattle.Location = new System.Drawing.Point(86, 149);
            this.pictureBoxBattle.Name = "pictureBoxBattle";
            this.pictureBoxBattle.Size = new System.Drawing.Size(1334, 416);
            this.pictureBoxBattle.TabIndex = 25;
            this.pictureBoxBattle.TabStop = false;
            // 
            // pictureBoxPetHealth
            // 
            this.pictureBoxPetHealth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPetHealth.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPetHealth.Image")));
            this.pictureBoxPetHealth.Location = new System.Drawing.Point(86, 117);
            this.pictureBoxPetHealth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPetHealth.Name = "pictureBoxPetHealth";
            this.pictureBoxPetHealth.Size = new System.Drawing.Size(158, 24);
            this.pictureBoxPetHealth.TabIndex = 24;
            this.pictureBoxPetHealth.TabStop = false;
            // 
            // FormBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 769);
            this.Controls.Add(this.panelAfterBattle);
            this.Controls.Add(this.panelBattle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBattle";
            this.Text = "Form Battle";
            this.Load += new System.EventHandler(this.FormBattle_Load);
            this.panelBattle.ResumeLayout(false);
            this.panelBattle.PerformLayout();
            this.groupBoxPetAction.ResumeLayout(false);
            this.panelAfterBattle.ResumeLayout(false);
            this.groupBoxChooseEnemy.ResumeLayout(false);
            this.groupBoxChooseEnemy.PerformLayout();
            this.groupBoxPetStat.ResumeLayout(false);
            this.groupBoxPetStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetHealth)).EndInit();
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
        private System.Windows.Forms.Panel panelAfterBattle;
        private System.Windows.Forms.ListBox listBoxLevelUp;
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.RadioButton radioButtonAtkSpeed;
        private System.Windows.Forms.RadioButton radioButtonHappinessGain;
        private System.Windows.Forms.RadioButton radioButtonDefense;
        private System.Windows.Forms.RadioButton radioButtonEnergy;
        private System.Windows.Forms.RadioButton radioButtonMaxHealth;
        private System.Windows.Forms.Label labelLevelPoint;
        private System.Windows.Forms.PictureBox pictureBoxPetHealth;
        private System.Windows.Forms.PictureBox pictureBoxPetDisplay;
        private System.Windows.Forms.ListBox Door2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RadioButton radioButtonDoor1;
        private System.Windows.Forms.RadioButton radioButtonDoor2;
        private System.Windows.Forms.ListBox Door1;
        private System.Windows.Forms.PictureBox pictureBoxBattle;
        private System.Windows.Forms.PictureBox pictureBoxEnemyHealth;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.PictureBox pictureBoxProgress;
        private System.Windows.Forms.Label labelBattleResult;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonExit2;
        private System.Windows.Forms.GroupBox groupBoxChooseEnemy;
        private System.Windows.Forms.GroupBox groupBoxPetStat;
        private System.Windows.Forms.Label labelExpReward;
        private System.Windows.Forms.Label labelCoinsReward;
    }
}

