
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelBattleResult = new System.Windows.Forms.Label();
            this.pictureBoxEnemyHealth = new System.Windows.Forms.PictureBox();
            this.labelTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
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
            this.panelAfterBattle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.pictureBoxPetDisplay = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelProgressBattle = new System.Windows.Forms.Panel();
            this.panelMainBattle = new System.Windows.Forms.Panel();
            this.panelBattle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetHealth)).BeginInit();
            this.groupBoxPetAction.SuspendLayout();
            this.panelAfterBattle.SuspendLayout();
            this.groupBoxChooseEnemy.SuspendLayout();
            this.groupBoxPetStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetDisplay)).BeginInit();
            this.panelMainBattle.SuspendLayout();
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
            this.panelBattle.Name = "panelBattle";
            this.panelBattle.Size = new System.Drawing.Size(1000, 600);
            this.panelBattle.TabIndex = 26;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Pixeloid Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(769, 65);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(167, 147);
            this.listBox2.TabIndex = 33;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Pixeloid Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(87, 64);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 147);
            this.listBox1.TabIndex = 32;
            // 
            // labelBattleResult
            // 
            this.labelBattleResult.AutoSize = true;
            this.labelBattleResult.Font = new System.Drawing.Font("Press Start 2P", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattleResult.Location = new System.Drawing.Point(280, 154);
            this.labelBattleResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBattleResult.Name = "labelBattleResult";
            this.labelBattleResult.Size = new System.Drawing.Size(460, 27);
            this.labelBattleResult.TabIndex = 31;
            this.labelBattleResult.Text = "(GAME OVER/ WIN)";
            this.labelBattleResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEnemyHealth
            // 
            this.pictureBoxEnemyHealth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyHealth.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyHealth.Image")));
            this.pictureBoxEnemyHealth.Location = new System.Drawing.Point(847, 36);
            this.pictureBoxEnemyHealth.Name = "pictureBoxEnemyHealth";
            this.pictureBoxEnemyHealth.Size = new System.Drawing.Size(105, 16);
            this.pictureBoxEnemyHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnemyHealth.TabIndex = 30;
            this.pictureBoxEnemyHealth.TabStop = false;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Press Start 2P", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.Location = new System.Drawing.Point(357, 114);
            this.labelTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(252, 21);
            this.labelTurn.TabIndex = 29;
            this.labelTurn.Text = "(PET/ENEMY)";
            this.labelTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Press Start 2P", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "TURN :";
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.ErrorImage = null;
            this.pictureBoxEnemy.Image = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(813, 213);
            this.pictureBoxEnemy.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(121, 97);
            this.pictureBoxEnemy.TabIndex = 27;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.ErrorImage = null;
            this.pictureBoxPet.Image = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxPet.InitialImage = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxPet.Location = new System.Drawing.Point(87, 213);
            this.pictureBoxPet.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(121, 97);
            this.pictureBoxPet.TabIndex = 26;
            this.pictureBoxPet.TabStop = false;
            // 
            // pictureBoxBattle
            // 
            this.pictureBoxBattle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBoxBattle.Location = new System.Drawing.Point(63, 57);
            this.pictureBoxBattle.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBattle.Name = "pictureBoxBattle";
            this.pictureBoxBattle.Size = new System.Drawing.Size(889, 270);
            this.pictureBoxBattle.TabIndex = 25;
            this.pictureBoxBattle.TabStop = false;
            // 
            // pictureBoxPetHealth
            // 
            this.pictureBoxPetHealth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPetHealth.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPetHealth.Image")));
            this.pictureBoxPetHealth.Location = new System.Drawing.Point(63, 36);
            this.pictureBoxPetHealth.Name = "pictureBoxPetHealth";
            this.pictureBoxPetHealth.Size = new System.Drawing.Size(105, 16);
            this.pictureBoxPetHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPetHealth.TabIndex = 24;
            this.pictureBoxPetHealth.TabStop = false;
            // 
            // labelDebuff
            // 
            this.labelDebuff.AutoSize = true;
            this.labelDebuff.Font = new System.Drawing.Font("Pixeloid Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebuff.Location = new System.Drawing.Point(734, 9);
            this.labelDebuff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDebuff.Name = "labelDebuff";
            this.labelDebuff.Size = new System.Drawing.Size(116, 16);
            this.labelDebuff.TabIndex = 23;
            this.labelDebuff.Text = "label debuff";
            // 
            // labelBuff
            // 
            this.labelBuff.AutoSize = true;
            this.labelBuff.Font = new System.Drawing.Font("Pixeloid Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuff.Location = new System.Drawing.Point(528, 9);
            this.labelBuff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuff.Name = "labelBuff";
            this.labelBuff.Size = new System.Drawing.Size(98, 16);
            this.labelBuff.TabIndex = 22;
            this.labelBuff.Text = "label buff";
            // 
            // labelBattleNumber
            // 
            this.labelBattleNumber.AutoSize = true;
            this.labelBattleNumber.Font = new System.Drawing.Font("Pixeloid Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattleNumber.Location = new System.Drawing.Point(69, 9);
            this.labelBattleNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBattleNumber.Name = "labelBattleNumber";
            this.labelBattleNumber.Size = new System.Drawing.Size(179, 16);
            this.labelBattleNumber.TabIndex = 19;
            this.labelBattleNumber.Text = "label battle number";
            // 
            // labelSkillPoint
            // 
            this.labelSkillPoint.AutoSize = true;
            this.labelSkillPoint.Font = new System.Drawing.Font("Pixeloid Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkillPoint.Location = new System.Drawing.Point(304, 9);
            this.labelSkillPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSkillPoint.Name = "labelSkillPoint";
            this.labelSkillPoint.Size = new System.Drawing.Size(152, 16);
            this.labelSkillPoint.TabIndex = 21;
            this.labelSkillPoint.Text = "label skill poin";
            // 
            // groupBoxPetAction
            // 
            this.groupBoxPetAction.Controls.Add(this.buttonBasicAttack);
            this.groupBoxPetAction.Controls.Add(this.buttonSkill);
            this.groupBoxPetAction.Controls.Add(this.buttonUlti);
            this.groupBoxPetAction.Font = new System.Drawing.Font("Pixeloid Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPetAction.Location = new System.Drawing.Point(63, 344);
            this.groupBoxPetAction.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPetAction.Name = "groupBoxPetAction";
            this.groupBoxPetAction.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPetAction.Size = new System.Drawing.Size(889, 82);
            this.groupBoxPetAction.TabIndex = 20;
            this.groupBoxPetAction.TabStop = false;
            this.groupBoxPetAction.Text = "pet attack";
            // 
            // buttonBasicAttack
            // 
            this.buttonBasicAttack.Font = new System.Drawing.Font("Pixeloid Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBasicAttack.Location = new System.Drawing.Point(8, 16);
            this.buttonBasicAttack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBasicAttack.Name = "buttonBasicAttack";
            this.buttonBasicAttack.Size = new System.Drawing.Size(280, 62);
            this.buttonBasicAttack.TabIndex = 15;
            this.buttonBasicAttack.Text = "Basic Attack";
            this.buttonBasicAttack.UseVisualStyleBackColor = true;
            this.buttonBasicAttack.Click += new System.EventHandler(this.buttonBasicAttack_Click);
            // 
            // buttonSkill
            // 
            this.buttonSkill.Font = new System.Drawing.Font("Pixeloid Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkill.Location = new System.Drawing.Point(311, 16);
            this.buttonSkill.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSkill.Name = "buttonSkill";
            this.buttonSkill.Size = new System.Drawing.Size(280, 62);
            this.buttonSkill.TabIndex = 14;
            this.buttonSkill.Text = "Skill";
            this.buttonSkill.UseVisualStyleBackColor = true;
            this.buttonSkill.Click += new System.EventHandler(this.buttonSkill_Click);
            // 
            // buttonUlti
            // 
            this.buttonUlti.Font = new System.Drawing.Font("Pixeloid Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUlti.Location = new System.Drawing.Point(605, 16);
            this.buttonUlti.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUlti.Name = "buttonUlti";
            this.buttonUlti.Size = new System.Drawing.Size(280, 62);
            this.buttonUlti.TabIndex = 13;
            this.buttonUlti.Text = "Ulti";
            this.buttonUlti.UseVisualStyleBackColor = true;
            this.buttonUlti.Click += new System.EventHandler(this.buttonUlti_Click);
            // 
            // panelAfterBattle
            // 
            this.panelAfterBattle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAfterBattle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelAfterBattle.Controls.Add(this.label2);
            this.panelAfterBattle.Controls.Add(this.groupBoxChooseEnemy);
            this.panelAfterBattle.Controls.Add(this.groupBoxPetStat);
            this.panelAfterBattle.Location = new System.Drawing.Point(245, 153);
            this.panelAfterBattle.Name = "panelAfterBattle";
            this.panelAfterBattle.Size = new System.Drawing.Size(0, 200);
            this.panelAfterBattle.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Pixeloid Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(60, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Current Position";
            // 
            // groupBoxChooseEnemy
            // 
            this.groupBoxChooseEnemy.Controls.Add(this.Door2);
            this.groupBoxChooseEnemy.Controls.Add(this.Door1);
            this.groupBoxChooseEnemy.Controls.Add(this.radioButtonDoor2);
            this.groupBoxChooseEnemy.Controls.Add(this.radioButtonDoor1);
            this.groupBoxChooseEnemy.Controls.Add(this.buttonGo);
            this.groupBoxChooseEnemy.Location = new System.Drawing.Point(485, 110);
            this.groupBoxChooseEnemy.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxChooseEnemy.Name = "groupBoxChooseEnemy";
            this.groupBoxChooseEnemy.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxChooseEnemy.Size = new System.Drawing.Size(427, 370);
            this.groupBoxChooseEnemy.TabIndex = 35;
            this.groupBoxChooseEnemy.TabStop = false;
            this.groupBoxChooseEnemy.Text = "Choose next enemy";
            // 
            // Door2
            // 
            this.Door2.FormattingEnabled = true;
            this.Door2.Location = new System.Drawing.Point(211, 34);
            this.Door2.Margin = new System.Windows.Forms.Padding(2);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(201, 264);
            this.Door2.TabIndex = 38;
            // 
            // Door1
            // 
            this.Door1.FormattingEnabled = true;
            this.Door1.Location = new System.Drawing.Point(7, 34);
            this.Door1.Margin = new System.Windows.Forms.Padding(2);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(201, 264);
            this.Door1.TabIndex = 37;
            // 
            // radioButtonDoor2
            // 
            this.radioButtonDoor2.AutoSize = true;
            this.radioButtonDoor2.Location = new System.Drawing.Point(211, 15);
            this.radioButtonDoor2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDoor2.Name = "radioButtonDoor2";
            this.radioButtonDoor2.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDoor2.TabIndex = 36;
            this.radioButtonDoor2.TabStop = true;
            this.radioButtonDoor2.Text = "Door 2";
            this.radioButtonDoor2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoor1
            // 
            this.radioButtonDoor1.AutoSize = true;
            this.radioButtonDoor1.Location = new System.Drawing.Point(7, 15);
            this.radioButtonDoor1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDoor1.Name = "radioButtonDoor1";
            this.radioButtonDoor1.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDoor1.TabIndex = 35;
            this.radioButtonDoor1.TabStop = true;
            this.radioButtonDoor1.Text = "Door 1";
            this.radioButtonDoor1.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(7, 301);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(404, 64);
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
            this.groupBoxPetStat.Location = new System.Drawing.Point(41, 104);
            this.groupBoxPetStat.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPetStat.Name = "groupBoxPetStat";
            this.groupBoxPetStat.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPetStat.Size = new System.Drawing.Size(440, 376);
            this.groupBoxPetStat.TabIndex = 42;
            this.groupBoxPetStat.TabStop = false;
            this.groupBoxPetStat.Text = "pet stat";
            // 
            // labelExpReward
            // 
            this.labelExpReward.AutoSize = true;
            this.labelExpReward.Location = new System.Drawing.Point(171, 21);
            this.labelExpReward.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpReward.Name = "labelExpReward";
            this.labelExpReward.Size = new System.Drawing.Size(71, 13);
            this.labelExpReward.TabIndex = 36;
            this.labelExpReward.Text = "Exp Reward :";
            // 
            // labelCoinsReward
            // 
            this.labelCoinsReward.AutoSize = true;
            this.labelCoinsReward.Location = new System.Drawing.Point(25, 21);
            this.labelCoinsReward.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoinsReward.Name = "labelCoinsReward";
            this.labelCoinsReward.Size = new System.Drawing.Size(79, 13);
            this.labelCoinsReward.TabIndex = 35;
            this.labelCoinsReward.Text = "Coins Reward :";
            // 
            // listBoxLevelUp
            // 
            this.listBoxLevelUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxLevelUp.FormattingEnabled = true;
            this.listBoxLevelUp.Location = new System.Drawing.Point(196, 214);
            this.listBoxLevelUp.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLevelUp.Name = "listBoxLevelUp";
            this.listBoxLevelUp.Size = new System.Drawing.Size(222, 160);
            this.listBoxLevelUp.TabIndex = 33;
            // 
            // labelLevelPoint
            // 
            this.labelLevelPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLevelPoint.AutoSize = true;
            this.labelLevelPoint.Location = new System.Drawing.Point(23, 218);
            this.labelLevelPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevelPoint.Name = "labelLevelPoint";
            this.labelLevelPoint.Size = new System.Drawing.Size(80, 13);
            this.labelLevelPoint.TabIndex = 26;
            this.labelLevelPoint.Text = "label level point";
            // 
            // radioButtonMaxHealth
            // 
            this.radioButtonMaxHealth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMaxHealth.AutoSize = true;
            this.radioButtonMaxHealth.Location = new System.Drawing.Point(25, 240);
            this.radioButtonMaxHealth.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMaxHealth.Name = "radioButtonMaxHealth";
            this.radioButtonMaxHealth.Size = new System.Drawing.Size(103, 17);
            this.radioButtonMaxHealth.TabIndex = 27;
            this.radioButtonMaxHealth.TabStop = true;
            this.radioButtonMaxHealth.Text = "MaxHealth +250";
            this.radioButtonMaxHealth.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnergy
            // 
            this.radioButtonEnergy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonEnergy.AutoSize = true;
            this.radioButtonEnergy.Location = new System.Drawing.Point(25, 259);
            this.radioButtonEnergy.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEnergy.Name = "radioButtonEnergy";
            this.radioButtonEnergy.Size = new System.Drawing.Size(79, 17);
            this.radioButtonEnergy.TabIndex = 28;
            this.radioButtonEnergy.TabStop = true;
            this.radioButtonEnergy.Text = "Energy +25";
            this.radioButtonEnergy.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefense
            // 
            this.radioButtonDefense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonDefense.AutoSize = true;
            this.radioButtonDefense.Location = new System.Drawing.Point(25, 276);
            this.radioButtonDefense.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDefense.Name = "radioButtonDefense";
            this.radioButtonDefense.Size = new System.Drawing.Size(86, 17);
            this.radioButtonDefense.TabIndex = 29;
            this.radioButtonDefense.TabStop = true;
            this.radioButtonDefense.Text = "Defense +50";
            this.radioButtonDefense.UseVisualStyleBackColor = true;
            // 
            // radioButtonHappinessGain
            // 
            this.radioButtonHappinessGain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHappinessGain.AutoSize = true;
            this.radioButtonHappinessGain.Location = new System.Drawing.Point(25, 294);
            this.radioButtonHappinessGain.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHappinessGain.Name = "radioButtonHappinessGain";
            this.radioButtonHappinessGain.Size = new System.Drawing.Size(112, 17);
            this.radioButtonHappinessGain.TabIndex = 30;
            this.radioButtonHappinessGain.TabStop = true;
            this.radioButtonHappinessGain.Text = "HappinessGain +2";
            this.radioButtonHappinessGain.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtkSpeed
            // 
            this.radioButtonAtkSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAtkSpeed.AutoSize = true;
            this.radioButtonAtkSpeed.Location = new System.Drawing.Point(25, 313);
            this.radioButtonAtkSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAtkSpeed.Name = "radioButtonAtkSpeed";
            this.radioButtonAtkSpeed.Size = new System.Drawing.Size(96, 17);
            this.radioButtonAtkSpeed.TabIndex = 31;
            this.radioButtonAtkSpeed.TabStop = true;
            this.radioButtonAtkSpeed.Text = "AtkSpeed +0.1";
            this.radioButtonAtkSpeed.UseVisualStyleBackColor = true;
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpgrade.Location = new System.Drawing.Point(25, 333);
            this.buttonUpgrade.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(133, 37);
            this.buttonUpgrade.TabIndex = 32;
            this.buttonUpgrade.Text = "upgrade";
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // pictureBoxPetDisplay
            // 
            this.pictureBoxPetDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBoxPetDisplay.Image = global::happy_pet_game_2019.Properties.Resources.cat;
            this.pictureBoxPetDisplay.Location = new System.Drawing.Point(25, 40);
            this.pictureBoxPetDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPetDisplay.Name = "pictureBoxPetDisplay";
            this.pictureBoxPetDisplay.Size = new System.Drawing.Size(391, 170);
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
            this.buttonExit.Font = new System.Drawing.Font("Pixeloid Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.buttonExit.Location = new System.Drawing.Point(1058, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(34, 33);
            this.buttonExit.TabIndex = 48;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // panelProgressBattle
            // 
            this.panelProgressBattle.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.progress;
            this.panelProgressBattle.Location = new System.Drawing.Point(50, 50);
            this.panelProgressBattle.Name = "panelProgressBattle";
            this.panelProgressBattle.Size = new System.Drawing.Size(1000, 100);
            this.panelProgressBattle.TabIndex = 49;
            // 
            // panelMainBattle
            // 
            this.panelMainBattle.Controls.Add(this.panelBattle);
            this.panelMainBattle.Controls.Add(this.panelAfterBattle);
            this.panelMainBattle.Location = new System.Drawing.Point(50, 150);
            this.panelMainBattle.Name = "panelMainBattle";
            this.panelMainBattle.Size = new System.Drawing.Size(1000, 600);
            this.panelMainBattle.TabIndex = 50;
            // 
            // FormBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::happy_pet_game_2019.Properties.Resources.battleBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelProgressBattle);
            this.Controls.Add(this.panelMainBattle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Battle";
            this.Load += new System.EventHandler(this.FormBattle_Load);
            this.panelBattle.ResumeLayout(false);
            this.panelBattle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetHealth)).EndInit();
            this.groupBoxPetAction.ResumeLayout(false);
            this.panelAfterBattle.ResumeLayout(false);
            this.panelAfterBattle.PerformLayout();
            this.groupBoxChooseEnemy.ResumeLayout(false);
            this.groupBoxChooseEnemy.PerformLayout();
            this.groupBoxPetStat.ResumeLayout(false);
            this.groupBoxPetStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetDisplay)).EndInit();
            this.panelMainBattle.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelBattleResult;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxChooseEnemy;
        private System.Windows.Forms.GroupBox groupBoxPetStat;
        private System.Windows.Forms.Label labelExpReward;
        private System.Windows.Forms.Label labelCoinsReward;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelProgressBattle;
        private System.Windows.Forms.Panel panelMainBattle;
    }
}

