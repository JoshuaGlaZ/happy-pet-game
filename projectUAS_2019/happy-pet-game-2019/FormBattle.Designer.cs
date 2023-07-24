
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
            this.panelAfterBattle = new System.Windows.Forms.Panel();
            this.groupBoxConsume = new System.Windows.Forms.GroupBox();
            this.buttonConsume = new System.Windows.Forms.Button();
            this.listBoxConsumableInfo = new System.Windows.Forms.ListBox();
            this.pictureBoxConsumable = new System.Windows.Forms.PictureBox();
            this.comboBoxConsumable = new System.Windows.Forms.ComboBox();
            this.groupBoxChooseEnemy = new System.Windows.Forms.GroupBox();
            this.Door2 = new System.Windows.Forms.ListBox();
            this.Door1 = new System.Windows.Forms.ListBox();
            this.radioButtonDoor2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDoor1 = new System.Windows.Forms.RadioButton();
            this.buttonGo = new System.Windows.Forms.Button();
            this.groupBoxPetStat = new System.Windows.Forms.GroupBox();
            this.buttonEquip = new System.Windows.Forms.Button();
            this.listBoxToyInfo = new System.Windows.Forms.ListBox();
            this.pictureBoxToy = new System.Windows.Forms.PictureBox();
            this.comboBoxToy = new System.Windows.Forms.ComboBox();
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
            this.pictureBoxPetDisplay = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelBattle = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelBattleResult = new System.Windows.Forms.Label();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyHealth = new System.Windows.Forms.PictureBox();
            this.labelTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.pictureBoxBattle = new System.Windows.Forms.PictureBox();
            this.pictureBoxPetHealth = new System.Windows.Forms.PictureBox();
            this.labelDebuff = new System.Windows.Forms.Label();
            this.labelBuff = new System.Windows.Forms.Label();
            this.labelBattleNumber = new System.Windows.Forms.Label();
            this.labelSkillPoint = new System.Windows.Forms.Label();
            this.groupBoxPetAction = new System.Windows.Forms.GroupBox();
            this.buttonBasicAttack = new System.Windows.Forms.Button();
            this.buttonSkill = new System.Windows.Forms.Button();
            this.buttonUlti = new System.Windows.Forms.Button();
            this.panelMainBattle = new System.Windows.Forms.Panel();
            this.panelAfterBattle.SuspendLayout();
            this.groupBoxConsume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsumable)).BeginInit();
            this.groupBoxChooseEnemy.SuspendLayout();
            this.groupBoxPetStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetDisplay)).BeginInit();
            this.panelBattle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetHealth)).BeginInit();
            this.groupBoxPetAction.SuspendLayout();
            this.panelMainBattle.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerBattle
            // 
            this.timerBattle.Interval = 1;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // panelAfterBattle
            // 
            this.panelAfterBattle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAfterBattle.BackColor = System.Drawing.Color.OldLace;
            this.panelAfterBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAfterBattle.Controls.Add(this.groupBoxConsume);
            this.panelAfterBattle.Controls.Add(this.groupBoxChooseEnemy);
            this.panelAfterBattle.Controls.Add(this.groupBoxPetStat);
            this.panelAfterBattle.Location = new System.Drawing.Point(2, 0);
            this.panelAfterBattle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAfterBattle.Name = "panelAfterBattle";
            this.panelAfterBattle.Size = new System.Drawing.Size(0, 600);
            this.panelAfterBattle.TabIndex = 26;
            // 
            // groupBoxConsume
            // 
            this.groupBoxConsume.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.battleBorder;
            this.groupBoxConsume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxConsume.Controls.Add(this.buttonConsume);
            this.groupBoxConsume.Controls.Add(this.listBoxConsumableInfo);
            this.groupBoxConsume.Controls.Add(this.pictureBoxConsumable);
            this.groupBoxConsume.Controls.Add(this.comboBoxConsumable);
            this.groupBoxConsume.Location = new System.Drawing.Point(596, 12);
            this.groupBoxConsume.Name = "groupBoxConsume";
            this.groupBoxConsume.Size = new System.Drawing.Size(490, 177);
            this.groupBoxConsume.TabIndex = 43;
            this.groupBoxConsume.TabStop = false;
            this.groupBoxConsume.Text = "Consumable";
            // 
            // buttonConsume
            // 
            this.buttonConsume.Location = new System.Drawing.Point(295, 25);
            this.buttonConsume.Name = "buttonConsume";
            this.buttonConsume.Size = new System.Drawing.Size(189, 139);
            this.buttonConsume.TabIndex = 42;
            this.buttonConsume.Text = "Eat";
            this.buttonConsume.UseVisualStyleBackColor = true;
            this.buttonConsume.Click += new System.EventHandler(this.buttonConsume_Click);
            // 
            // listBoxConsumableInfo
            // 
            this.listBoxConsumableInfo.FormattingEnabled = true;
            this.listBoxConsumableInfo.ItemHeight = 20;
            this.listBoxConsumableInfo.Location = new System.Drawing.Point(135, 60);
            this.listBoxConsumableInfo.Name = "listBoxConsumableInfo";
            this.listBoxConsumableInfo.Size = new System.Drawing.Size(154, 104);
            this.listBoxConsumableInfo.TabIndex = 43;
            // 
            // pictureBoxConsumable
            // 
            this.pictureBoxConsumable.Location = new System.Drawing.Point(13, 59);
            this.pictureBoxConsumable.Name = "pictureBoxConsumable";
            this.pictureBoxConsumable.Size = new System.Drawing.Size(115, 105);
            this.pictureBoxConsumable.TabIndex = 42;
            this.pictureBoxConsumable.TabStop = false;
            // 
            // comboBoxConsumable
            // 
            this.comboBoxConsumable.FormattingEnabled = true;
            this.comboBoxConsumable.Location = new System.Drawing.Point(13, 25);
            this.comboBoxConsumable.Name = "comboBoxConsumable";
            this.comboBoxConsumable.Size = new System.Drawing.Size(276, 28);
            this.comboBoxConsumable.TabIndex = 41;
            this.comboBoxConsumable.SelectedIndexChanged += new System.EventHandler(this.comboBoxConsumable_SelectedIndexChanged);
            // 
            // groupBoxChooseEnemy
            // 
            this.groupBoxChooseEnemy.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.battleBorder;
            this.groupBoxChooseEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxChooseEnemy.Controls.Add(this.Door2);
            this.groupBoxChooseEnemy.Controls.Add(this.Door1);
            this.groupBoxChooseEnemy.Controls.Add(this.radioButtonDoor2);
            this.groupBoxChooseEnemy.Controls.Add(this.radioButtonDoor1);
            this.groupBoxChooseEnemy.Controls.Add(this.buttonGo);
            this.groupBoxChooseEnemy.Location = new System.Drawing.Point(596, 195);
            this.groupBoxChooseEnemy.Name = "groupBoxChooseEnemy";
            this.groupBoxChooseEnemy.Size = new System.Drawing.Size(490, 386);
            this.groupBoxChooseEnemy.TabIndex = 35;
            this.groupBoxChooseEnemy.TabStop = false;
            this.groupBoxChooseEnemy.Text = "Choose next enemy";
            // 
            // Door2
            // 
            this.Door2.FormattingEnabled = true;
            this.Door2.ItemHeight = 20;
            this.Door2.Location = new System.Drawing.Point(248, 55);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(236, 244);
            this.Door2.TabIndex = 38;
            // 
            // Door1
            // 
            this.Door1.FormattingEnabled = true;
            this.Door1.ItemHeight = 20;
            this.Door1.Location = new System.Drawing.Point(13, 55);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(229, 244);
            this.Door1.TabIndex = 37;
            // 
            // radioButtonDoor2
            // 
            this.radioButtonDoor2.AutoSize = true;
            this.radioButtonDoor2.Location = new System.Drawing.Point(248, 25);
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
            this.radioButtonDoor1.Location = new System.Drawing.Point(13, 26);
            this.radioButtonDoor1.Name = "radioButtonDoor1";
            this.radioButtonDoor1.Size = new System.Drawing.Size(82, 24);
            this.radioButtonDoor1.TabIndex = 35;
            this.radioButtonDoor1.TabStop = true;
            this.radioButtonDoor1.Text = "Door 1";
            this.radioButtonDoor1.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(13, 306);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(471, 60);
            this.buttonGo.TabIndex = 39;
            this.buttonGo.Text = "GO !";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // groupBoxPetStat
            // 
            this.groupBoxPetStat.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPetStat.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.battleBorder;
            this.groupBoxPetStat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxPetStat.Controls.Add(this.buttonEquip);
            this.groupBoxPetStat.Controls.Add(this.listBoxToyInfo);
            this.groupBoxPetStat.Controls.Add(this.pictureBoxToy);
            this.groupBoxPetStat.Controls.Add(this.comboBoxToy);
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
            this.groupBoxPetStat.Location = new System.Drawing.Point(10, 12);
            this.groupBoxPetStat.Name = "groupBoxPetStat";
            this.groupBoxPetStat.Size = new System.Drawing.Size(567, 569);
            this.groupBoxPetStat.TabIndex = 42;
            this.groupBoxPetStat.TabStop = false;
            this.groupBoxPetStat.Text = "pet stat";
            // 
            // buttonEquip
            // 
            this.buttonEquip.Location = new System.Drawing.Point(260, 227);
            this.buttonEquip.Name = "buttonEquip";
            this.buttonEquip.Size = new System.Drawing.Size(259, 84);
            this.buttonEquip.TabIndex = 41;
            this.buttonEquip.Text = "Equip";
            this.buttonEquip.UseVisualStyleBackColor = true;
            this.buttonEquip.Click += new System.EventHandler(this.buttonEquip_Click);
            // 
            // listBoxToyInfo
            // 
            this.listBoxToyInfo.FormattingEnabled = true;
            this.listBoxToyInfo.ItemHeight = 20;
            this.listBoxToyInfo.Location = new System.Drawing.Point(382, 97);
            this.listBoxToyInfo.Name = "listBoxToyInfo";
            this.listBoxToyInfo.Size = new System.Drawing.Size(137, 124);
            this.listBoxToyInfo.TabIndex = 40;
            // 
            // pictureBoxToy
            // 
            this.pictureBoxToy.Location = new System.Drawing.Point(260, 96);
            this.pictureBoxToy.Name = "pictureBoxToy";
            this.pictureBoxToy.Size = new System.Drawing.Size(115, 125);
            this.pictureBoxToy.TabIndex = 39;
            this.pictureBoxToy.TabStop = false;
            // 
            // comboBoxToy
            // 
            this.comboBoxToy.FormattingEnabled = true;
            this.comboBoxToy.Location = new System.Drawing.Point(260, 62);
            this.comboBoxToy.Name = "comboBoxToy";
            this.comboBoxToy.Size = new System.Drawing.Size(259, 28);
            this.comboBoxToy.TabIndex = 38;
            this.comboBoxToy.SelectedIndexChanged += new System.EventHandler(this.comboBoxToy_SelectedIndexChanged);
            // 
            // labelExpReward
            // 
            this.labelExpReward.AutoSize = true;
            this.labelExpReward.Location = new System.Drawing.Point(256, 40);
            this.labelExpReward.Name = "labelExpReward";
            this.labelExpReward.Size = new System.Drawing.Size(103, 20);
            this.labelExpReward.TabIndex = 36;
            this.labelExpReward.Text = "Exp Reward :";
            // 
            // labelCoinsReward
            // 
            this.labelCoinsReward.AutoSize = true;
            this.labelCoinsReward.Location = new System.Drawing.Point(37, 40);
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
            this.listBoxLevelUp.Location = new System.Drawing.Point(247, 325);
            this.listBoxLevelUp.Name = "listBoxLevelUp";
            this.listBoxLevelUp.Size = new System.Drawing.Size(272, 204);
            this.listBoxLevelUp.TabIndex = 33;
            // 
            // labelLevelPoint
            // 
            this.labelLevelPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLevelPoint.AutoSize = true;
            this.labelLevelPoint.Location = new System.Drawing.Point(37, 317);
            this.labelLevelPoint.Name = "labelLevelPoint";
            this.labelLevelPoint.Size = new System.Drawing.Size(116, 20);
            this.labelLevelPoint.TabIndex = 26;
            this.labelLevelPoint.Text = "label level point";
            // 
            // radioButtonMaxHealth
            // 
            this.radioButtonMaxHealth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMaxHealth.AutoSize = true;
            this.radioButtonMaxHealth.Location = new System.Drawing.Point(38, 345);
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
            this.radioButtonEnergy.Location = new System.Drawing.Point(38, 374);
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
            this.radioButtonDefense.Location = new System.Drawing.Point(38, 401);
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
            this.radioButtonHappinessGain.Location = new System.Drawing.Point(38, 428);
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
            this.radioButtonAtkSpeed.Location = new System.Drawing.Point(38, 458);
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
            this.buttonUpgrade.Location = new System.Drawing.Point(38, 488);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(200, 41);
            this.buttonUpgrade.TabIndex = 32;
            this.buttonUpgrade.Text = "upgrade";
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // pictureBoxPetDisplay
            // 
            this.pictureBoxPetDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBoxPetDisplay.Image = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxPetDisplay.Location = new System.Drawing.Point(38, 62);
            this.pictureBoxPetDisplay.Name = "pictureBoxPetDisplay";
            this.pictureBoxPetDisplay.Size = new System.Drawing.Size(208, 249);
            this.pictureBoxPetDisplay.TabIndex = 34;
            this.pictureBoxPetDisplay.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(111)))), ((int)(((byte)(80)))));
            this.buttonExit.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.Exit_normal;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.buttonExit.Location = new System.Drawing.Point(1312, -149);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(51, 51);
            this.buttonExit.TabIndex = 48;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // panelBattle
            // 
            this.panelBattle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelBattle.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.battleBorder;
            this.panelBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBattle.Controls.Add(this.listBox2);
            this.panelBattle.Controls.Add(this.listBox1);
            this.panelBattle.Controls.Add(this.labelBattleResult);
            this.panelBattle.Controls.Add(this.pictureBoxEnemy);
            this.panelBattle.Controls.Add(this.pictureBoxEnemyHealth);
            this.panelBattle.Controls.Add(this.labelTurn);
            this.panelBattle.Controls.Add(this.label1);
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
            this.panelBattle.Size = new System.Drawing.Size(1100, 600);
            this.panelBattle.TabIndex = 26;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(770, 109);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(248, 264);
            this.listBox2.TabIndex = 33;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(109, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 264);
            this.listBox1.TabIndex = 32;
            // 
            // labelBattleResult
            // 
            this.labelBattleResult.AutoSize = true;
            this.labelBattleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattleResult.Location = new System.Drawing.Point(433, 276);
            this.labelBattleResult.Name = "labelBattleResult";
            this.labelBattleResult.Size = new System.Drawing.Size(413, 47);
            this.labelBattleResult.TabIndex = 31;
            this.labelBattleResult.Text = "(GAME OVER/ WIN)";
            this.labelBattleResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemy.ErrorImage = null;
            this.pictureBoxEnemy.Image = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(901, 384);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(117, 110);
            this.pictureBoxEnemy.TabIndex = 27;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // pictureBoxEnemyHealth
            // 
            this.pictureBoxEnemyHealth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyHealth.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyHealth.Image")));
            this.pictureBoxEnemyHealth.Location = new System.Drawing.Point(875, 55);
            this.pictureBoxEnemyHealth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxEnemyHealth.Name = "pictureBoxEnemyHealth";
            this.pictureBoxEnemyHealth.Size = new System.Drawing.Size(158, 25);
            this.pictureBoxEnemyHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnemyHealth.TabIndex = 30;
            this.pictureBoxEnemyHealth.TabStop = false;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.Location = new System.Drawing.Point(485, 168);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(235, 37);
            this.labelTurn.TabIndex = 29;
            this.labelTurn.Text = "(PET/ENEMY)";
            this.labelTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "TURN :";
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.ErrorImage = null;
            this.pictureBoxPet.Image = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxPet.InitialImage = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxPet.Location = new System.Drawing.Point(109, 384);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(117, 109);
            this.pictureBoxPet.TabIndex = 26;
            this.pictureBoxPet.TabStop = false;
            // 
            // pictureBoxBattle
            // 
            this.pictureBoxBattle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBoxBattle.Location = new System.Drawing.Point(94, 88);
            this.pictureBoxBattle.Name = "pictureBoxBattle";
            this.pictureBoxBattle.Size = new System.Drawing.Size(939, 415);
            this.pictureBoxBattle.TabIndex = 25;
            this.pictureBoxBattle.TabStop = false;
            // 
            // pictureBoxPetHealth
            // 
            this.pictureBoxPetHealth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPetHealth.Image = global::happy_pet_game_2019.Properties.Resources.health_100;
            this.pictureBoxPetHealth.Location = new System.Drawing.Point(94, 55);
            this.pictureBoxPetHealth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPetHealth.Name = "pictureBoxPetHealth";
            this.pictureBoxPetHealth.Size = new System.Drawing.Size(158, 25);
            this.pictureBoxPetHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPetHealth.TabIndex = 24;
            this.pictureBoxPetHealth.TabStop = false;
            // 
            // labelDebuff
            // 
            this.labelDebuff.AutoSize = true;
            this.labelDebuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebuff.Location = new System.Drawing.Point(921, 14);
            this.labelDebuff.Name = "labelDebuff";
            this.labelDebuff.Size = new System.Drawing.Size(112, 25);
            this.labelDebuff.TabIndex = 23;
            this.labelDebuff.Text = "label debuff";
            // 
            // labelBuff
            // 
            this.labelBuff.AutoSize = true;
            this.labelBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuff.Location = new System.Drawing.Point(677, 14);
            this.labelBuff.Name = "labelBuff";
            this.labelBuff.Size = new System.Drawing.Size(90, 25);
            this.labelBuff.TabIndex = 22;
            this.labelBuff.Text = "label buff";
            // 
            // labelBattleNumber
            // 
            this.labelBattleNumber.AutoSize = true;
            this.labelBattleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattleNumber.Location = new System.Drawing.Point(104, 14);
            this.labelBattleNumber.Name = "labelBattleNumber";
            this.labelBattleNumber.Size = new System.Drawing.Size(176, 25);
            this.labelBattleNumber.TabIndex = 19;
            this.labelBattleNumber.Text = "label battle number";
            // 
            // labelSkillPoint
            // 
            this.labelSkillPoint.AutoSize = true;
            this.labelSkillPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkillPoint.Location = new System.Drawing.Point(360, 14);
            this.labelSkillPoint.Name = "labelSkillPoint";
            this.labelSkillPoint.Size = new System.Drawing.Size(132, 25);
            this.labelSkillPoint.TabIndex = 21;
            this.labelSkillPoint.Text = "label skill poin";
            // 
            // groupBoxPetAction
            // 
            this.groupBoxPetAction.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.battleBorder;
            this.groupBoxPetAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxPetAction.Controls.Add(this.buttonBasicAttack);
            this.groupBoxPetAction.Controls.Add(this.buttonSkill);
            this.groupBoxPetAction.Controls.Add(this.buttonUlti);
            this.groupBoxPetAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPetAction.Location = new System.Drawing.Point(94, 509);
            this.groupBoxPetAction.Name = "groupBoxPetAction";
            this.groupBoxPetAction.Size = new System.Drawing.Size(939, 88);
            this.groupBoxPetAction.TabIndex = 20;
            this.groupBoxPetAction.TabStop = false;
            this.groupBoxPetAction.Text = "pet attack";
            // 
            // buttonBasicAttack
            // 
            this.buttonBasicAttack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBasicAttack.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.border_wide;
            this.buttonBasicAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBasicAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBasicAttack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBasicAttack.Location = new System.Drawing.Point(15, 25);
            this.buttonBasicAttack.Name = "buttonBasicAttack";
            this.buttonBasicAttack.Size = new System.Drawing.Size(300, 54);
            this.buttonBasicAttack.TabIndex = 15;
            this.buttonBasicAttack.Text = "Basic Attack";
            this.buttonBasicAttack.UseVisualStyleBackColor = false;
            this.buttonBasicAttack.Click += new System.EventHandler(this.buttonBasicAttack_Click);
            // 
            // buttonSkill
            // 
            this.buttonSkill.BackColor = System.Drawing.Color.Transparent;
            this.buttonSkill.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.border_wide;
            this.buttonSkill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSkill.Location = new System.Drawing.Point(327, 25);
            this.buttonSkill.Name = "buttonSkill";
            this.buttonSkill.Size = new System.Drawing.Size(300, 54);
            this.buttonSkill.TabIndex = 14;
            this.buttonSkill.Text = "Skill";
            this.buttonSkill.UseVisualStyleBackColor = false;
            this.buttonSkill.Click += new System.EventHandler(this.buttonSkill_Click);
            // 
            // buttonUlti
            // 
            this.buttonUlti.BackColor = System.Drawing.Color.Transparent;
            this.buttonUlti.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.border_wide;
            this.buttonUlti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUlti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUlti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUlti.Location = new System.Drawing.Point(633, 25);
            this.buttonUlti.Name = "buttonUlti";
            this.buttonUlti.Size = new System.Drawing.Size(300, 54);
            this.buttonUlti.TabIndex = 13;
            this.buttonUlti.Text = "Ulti";
            this.buttonUlti.UseVisualStyleBackColor = false;
            this.buttonUlti.Click += new System.EventHandler(this.buttonUlti_Click);
            // 
            // panelMainBattle
            // 
            this.panelMainBattle.Controls.Add(this.panelBattle);
            this.panelMainBattle.Location = new System.Drawing.Point(6, 0);
            this.panelMainBattle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMainBattle.Name = "panelMainBattle";
            this.panelMainBattle.Size = new System.Drawing.Size(1100, 600);
            this.panelMainBattle.TabIndex = 50;
            // 
            // FormBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.battleBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelAfterBattle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelMainBattle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Battle";
            this.Load += new System.EventHandler(this.FormBattle_Load);
            this.panelAfterBattle.ResumeLayout(false);
            this.groupBoxConsume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsumable)).EndInit();
            this.groupBoxChooseEnemy.ResumeLayout(false);
            this.groupBoxChooseEnemy.PerformLayout();
            this.groupBoxPetStat.ResumeLayout(false);
            this.groupBoxPetStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetDisplay)).EndInit();
            this.panelBattle.ResumeLayout(false);
            this.panelBattle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetHealth)).EndInit();
            this.groupBoxPetAction.ResumeLayout(false);
            this.panelMainBattle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerBattle;
        private System.Windows.Forms.Panel panelAfterBattle;
        private System.Windows.Forms.ListBox listBoxLevelUp;
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.RadioButton radioButtonAtkSpeed;
        private System.Windows.Forms.RadioButton radioButtonHappinessGain;
        private System.Windows.Forms.RadioButton radioButtonDefense;
        private System.Windows.Forms.RadioButton radioButtonEnergy;
        private System.Windows.Forms.RadioButton radioButtonMaxHealth;
        private System.Windows.Forms.Label labelLevelPoint;
        private System.Windows.Forms.PictureBox pictureBoxPetDisplay;
        private System.Windows.Forms.ListBox Door2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RadioButton radioButtonDoor1;
        private System.Windows.Forms.RadioButton radioButtonDoor2;
        private System.Windows.Forms.ListBox Door1;
        private System.Windows.Forms.GroupBox groupBoxChooseEnemy;
        private System.Windows.Forms.GroupBox groupBoxPetStat;
        private System.Windows.Forms.Label labelExpReward;
        private System.Windows.Forms.Label labelCoinsReward;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEquip;
        private System.Windows.Forms.ListBox listBoxToyInfo;
        private System.Windows.Forms.PictureBox pictureBoxToy;
        private System.Windows.Forms.ComboBox comboBoxToy;
        private System.Windows.Forms.GroupBox groupBoxConsume;
        private System.Windows.Forms.Button buttonConsume;
        private System.Windows.Forms.ListBox listBoxConsumableInfo;
        private System.Windows.Forms.PictureBox pictureBoxConsumable;
        private System.Windows.Forms.ComboBox comboBoxConsumable;
        private System.Windows.Forms.Panel panelBattle;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelBattleResult;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.PictureBox pictureBoxEnemyHealth;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.PictureBox pictureBoxBattle;
        private System.Windows.Forms.PictureBox pictureBoxPetHealth;
        private System.Windows.Forms.Label labelDebuff;
        private System.Windows.Forms.Label labelBuff;
        private System.Windows.Forms.Label labelBattleNumber;
        private System.Windows.Forms.Label labelSkillPoint;
        private System.Windows.Forms.GroupBox groupBoxPetAction;
        private System.Windows.Forms.Button buttonBasicAttack;
        private System.Windows.Forms.Button buttonSkill;
        private System.Windows.Forms.Button buttonUlti;
        private System.Windows.Forms.Panel panelMainBattle;
    }
}

