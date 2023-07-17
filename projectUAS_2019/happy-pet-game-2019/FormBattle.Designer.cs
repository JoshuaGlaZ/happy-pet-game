
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
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            this.buttonGo = new System.Windows.Forms.Button();
            this.Door2 = new System.Windows.Forms.ListBox();
            this.Door1 = new System.Windows.Forms.ListBox();
            this.radioButtonDoor2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDoor1 = new System.Windows.Forms.RadioButton();
            this.groupBoxChooseEnemy = new System.Windows.Forms.GroupBox();
            this.groupBoxBattle = new System.Windows.Forms.GroupBox();
            this.labelDebuff = new System.Windows.Forms.Label();
            this.labelBuff = new System.Windows.Forms.Label();
            this.labelBattleNumber = new System.Windows.Forms.Label();
            this.labelSkillPoint = new System.Windows.Forms.Label();
            this.groupBoxPetAction = new System.Windows.Forms.GroupBox();
            this.buttonBasicAttack = new System.Windows.Forms.Button();
            this.buttonSkill = new System.Windows.Forms.Button();
            this.buttonUlti = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxChoosePet = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listBoxPet = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFish = new System.Windows.Forms.RadioButton();
            this.radioButtonChameleon = new System.Windows.Forms.RadioButton();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.groupBoxLvUp = new System.Windows.Forms.GroupBox();
            this.listBoxLevelUp = new System.Windows.Forms.ListBox();
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.radioButtonAtkSpeed = new System.Windows.Forms.RadioButton();
            this.radioButtonHappinessGain = new System.Windows.Forms.RadioButton();
            this.radioButtonDefense = new System.Windows.Forms.RadioButton();
            this.radioButtonEnergy = new System.Windows.Forms.RadioButton();
            this.radioButtonMaxHealth = new System.Windows.Forms.RadioButton();
            this.labelLevelPoint = new System.Windows.Forms.Label();
            this.groupBoxShop = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDoneShop = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonChageColor = new System.Windows.Forms.Button();
            this.buttonChameleonSleep = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFishClean = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonVaccinate = new System.Windows.Forms.Button();
            this.buttonCatBath = new System.Windows.Forms.Button();
            this.buttonCatSleep = new System.Windows.Forms.Button();
            this.buttonCatPlay = new System.Windows.Forms.Button();
            this.labelCoins = new System.Windows.Forms.Label();
            this.groupBoxChooseEnemy.SuspendLayout();
            this.groupBoxBattle.SuspendLayout();
            this.groupBoxPetAction.SuspendLayout();
            this.groupBoxChoosePet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxLvUp.SuspendLayout();
            this.groupBoxShop.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerBattle
            // 
            this.timerBattle.Interval = 1;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(28, 408);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(378, 126);
            this.buttonGo.TabIndex = 9;
            this.buttonGo.Text = "GO !";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Door2
            // 
            this.Door2.FormattingEnabled = true;
            this.Door2.ItemHeight = 20;
            this.Door2.Location = new System.Drawing.Point(228, 75);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(178, 324);
            this.Door2.TabIndex = 8;
            // 
            // Door1
            // 
            this.Door1.FormattingEnabled = true;
            this.Door1.ItemHeight = 20;
            this.Door1.Location = new System.Drawing.Point(28, 75);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(178, 324);
            this.Door1.TabIndex = 7;
            // 
            // radioButtonDoor2
            // 
            this.radioButtonDoor2.AutoSize = true;
            this.radioButtonDoor2.Location = new System.Drawing.Point(264, 42);
            this.radioButtonDoor2.Name = "radioButtonDoor2";
            this.radioButtonDoor2.Size = new System.Drawing.Size(82, 24);
            this.radioButtonDoor2.TabIndex = 6;
            this.radioButtonDoor2.TabStop = true;
            this.radioButtonDoor2.Text = "Door 2";
            this.radioButtonDoor2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoor1
            // 
            this.radioButtonDoor1.AutoSize = true;
            this.radioButtonDoor1.Location = new System.Drawing.Point(68, 42);
            this.radioButtonDoor1.Name = "radioButtonDoor1";
            this.radioButtonDoor1.Size = new System.Drawing.Size(82, 24);
            this.radioButtonDoor1.TabIndex = 5;
            this.radioButtonDoor1.TabStop = true;
            this.radioButtonDoor1.Text = "Door 1";
            this.radioButtonDoor1.UseVisualStyleBackColor = true;
            // 
            // groupBoxChooseEnemy
            // 
            this.groupBoxChooseEnemy.Controls.Add(this.Door2);
            this.groupBoxChooseEnemy.Controls.Add(this.buttonGo);
            this.groupBoxChooseEnemy.Controls.Add(this.radioButtonDoor1);
            this.groupBoxChooseEnemy.Controls.Add(this.radioButtonDoor2);
            this.groupBoxChooseEnemy.Controls.Add(this.Door1);
            this.groupBoxChooseEnemy.Location = new System.Drawing.Point(821, 356);
            this.groupBoxChooseEnemy.Name = "groupBoxChooseEnemy";
            this.groupBoxChooseEnemy.Size = new System.Drawing.Size(432, 540);
            this.groupBoxChooseEnemy.TabIndex = 10;
            this.groupBoxChooseEnemy.TabStop = false;
            this.groupBoxChooseEnemy.Text = "Choose Enemy";
            // 
            // groupBoxBattle
            // 
            this.groupBoxBattle.Controls.Add(this.labelDebuff);
            this.groupBoxBattle.Controls.Add(this.labelBuff);
            this.groupBoxBattle.Controls.Add(this.labelBattleNumber);
            this.groupBoxBattle.Controls.Add(this.labelSkillPoint);
            this.groupBoxBattle.Controls.Add(this.groupBoxPetAction);
            this.groupBoxBattle.Controls.Add(this.listBox1);
            this.groupBoxBattle.Location = new System.Drawing.Point(20, 356);
            this.groupBoxBattle.Name = "groupBoxBattle";
            this.groupBoxBattle.Size = new System.Drawing.Size(795, 540);
            this.groupBoxBattle.TabIndex = 11;
            this.groupBoxBattle.TabStop = false;
            this.groupBoxBattle.Text = "Battle";
            // 
            // labelDebuff
            // 
            this.labelDebuff.AutoSize = true;
            this.labelDebuff.Location = new System.Drawing.Point(580, 42);
            this.labelDebuff.Name = "labelDebuff";
            this.labelDebuff.Size = new System.Drawing.Size(92, 20);
            this.labelDebuff.TabIndex = 17;
            this.labelDebuff.Text = "label debuff";
            // 
            // labelBuff
            // 
            this.labelBuff.AutoSize = true;
            this.labelBuff.Location = new System.Drawing.Point(438, 42);
            this.labelBuff.Name = "labelBuff";
            this.labelBuff.Size = new System.Drawing.Size(74, 20);
            this.labelBuff.TabIndex = 16;
            this.labelBuff.Text = "label buff";
            // 
            // labelBattleNumber
            // 
            this.labelBattleNumber.AutoSize = true;
            this.labelBattleNumber.Location = new System.Drawing.Point(33, 42);
            this.labelBattleNumber.Name = "labelBattleNumber";
            this.labelBattleNumber.Size = new System.Drawing.Size(144, 20);
            this.labelBattleNumber.TabIndex = 13;
            this.labelBattleNumber.Text = "label battle number";
            // 
            // labelSkillPoint
            // 
            this.labelSkillPoint.AutoSize = true;
            this.labelSkillPoint.Location = new System.Drawing.Point(254, 42);
            this.labelSkillPoint.Name = "labelSkillPoint";
            this.labelSkillPoint.Size = new System.Drawing.Size(105, 20);
            this.labelSkillPoint.TabIndex = 15;
            this.labelSkillPoint.Text = "label skill poin";
            // 
            // groupBoxPetAction
            // 
            this.groupBoxPetAction.Controls.Add(this.buttonBasicAttack);
            this.groupBoxPetAction.Controls.Add(this.buttonSkill);
            this.groupBoxPetAction.Controls.Add(this.buttonUlti);
            this.groupBoxPetAction.Location = new System.Drawing.Point(37, 408);
            this.groupBoxPetAction.Name = "groupBoxPetAction";
            this.groupBoxPetAction.Size = new System.Drawing.Size(719, 126);
            this.groupBoxPetAction.TabIndex = 14;
            this.groupBoxPetAction.TabStop = false;
            this.groupBoxPetAction.Text = "pet attack";
            // 
            // buttonBasicAttack
            // 
            this.buttonBasicAttack.Location = new System.Drawing.Point(79, 25);
            this.buttonBasicAttack.Name = "buttonBasicAttack";
            this.buttonBasicAttack.Size = new System.Drawing.Size(183, 95);
            this.buttonBasicAttack.TabIndex = 15;
            this.buttonBasicAttack.Text = "Basic Attack";
            this.buttonBasicAttack.UseVisualStyleBackColor = true;
            this.buttonBasicAttack.Click += new System.EventHandler(this.buttonBasicAttack_Click);
            // 
            // buttonSkill
            // 
            this.buttonSkill.Location = new System.Drawing.Point(268, 25);
            this.buttonSkill.Name = "buttonSkill";
            this.buttonSkill.Size = new System.Drawing.Size(183, 95);
            this.buttonSkill.TabIndex = 14;
            this.buttonSkill.Text = "Skill";
            this.buttonSkill.UseVisualStyleBackColor = true;
            this.buttonSkill.Click += new System.EventHandler(this.buttonSkill_Click);
            // 
            // buttonUlti
            // 
            this.buttonUlti.Location = new System.Drawing.Point(457, 25);
            this.buttonUlti.Name = "buttonUlti";
            this.buttonUlti.Size = new System.Drawing.Size(183, 95);
            this.buttonUlti.TabIndex = 13;
            this.buttonUlti.Text = "Ulti";
            this.buttonUlti.UseVisualStyleBackColor = true;
            this.buttonUlti.Click += new System.EventHandler(this.buttonUlti_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(37, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(719, 324);
            this.listBox1.TabIndex = 12;
            // 
            // groupBoxChoosePet
            // 
            this.groupBoxChoosePet.Controls.Add(this.buttonStart);
            this.groupBoxChoosePet.Controls.Add(this.listBoxPet);
            this.groupBoxChoosePet.Controls.Add(this.groupBox1);
            this.groupBoxChoosePet.Location = new System.Drawing.Point(20, 21);
            this.groupBoxChoosePet.Name = "groupBoxChoosePet";
            this.groupBoxChoosePet.Size = new System.Drawing.Size(1233, 329);
            this.groupBoxChoosePet.TabIndex = 12;
            this.groupBoxChoosePet.TabStop = false;
            this.groupBoxChoosePet.Text = "choose pet";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1029, 36);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(178, 264);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listBoxPet
            // 
            this.listBoxPet.FormattingEnabled = true;
            this.listBoxPet.ItemHeight = 20;
            this.listBoxPet.Location = new System.Drawing.Point(258, 36);
            this.listBoxPet.Name = "listBoxPet";
            this.listBoxPet.Size = new System.Drawing.Size(749, 264);
            this.listBoxPet.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFish);
            this.groupBox1.Controls.Add(this.radioButtonChameleon);
            this.groupBox1.Controls.Add(this.radioButtonCat);
            this.groupBox1.Location = new System.Drawing.Point(37, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pet";
            // 
            // radioButtonFish
            // 
            this.radioButtonFish.AutoSize = true;
            this.radioButtonFish.Location = new System.Drawing.Point(37, 129);
            this.radioButtonFish.Name = "radioButtonFish";
            this.radioButtonFish.Size = new System.Drawing.Size(64, 24);
            this.radioButtonFish.TabIndex = 2;
            this.radioButtonFish.TabStop = true;
            this.radioButtonFish.Text = "Fish";
            this.radioButtonFish.UseVisualStyleBackColor = true;
            this.radioButtonFish.CheckedChanged += new System.EventHandler(this.radioButtonFish_CheckedChanged);
            // 
            // radioButtonChameleon
            // 
            this.radioButtonChameleon.AutoSize = true;
            this.radioButtonChameleon.Location = new System.Drawing.Point(37, 199);
            this.radioButtonChameleon.Name = "radioButtonChameleon";
            this.radioButtonChameleon.Size = new System.Drawing.Size(115, 24);
            this.radioButtonChameleon.TabIndex = 1;
            this.radioButtonChameleon.TabStop = true;
            this.radioButtonChameleon.Text = "Chameleon";
            this.radioButtonChameleon.UseVisualStyleBackColor = true;
            this.radioButtonChameleon.CheckedChanged += new System.EventHandler(this.radioButtonChameleon_CheckedChanged);
            // 
            // radioButtonCat
            // 
            this.radioButtonCat.AutoSize = true;
            this.radioButtonCat.Location = new System.Drawing.Point(37, 50);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(59, 24);
            this.radioButtonCat.TabIndex = 0;
            this.radioButtonCat.TabStop = true;
            this.radioButtonCat.Text = "Cat";
            this.radioButtonCat.UseVisualStyleBackColor = true;
            this.radioButtonCat.CheckedChanged += new System.EventHandler(this.radioButtonCat_CheckedChanged);
            // 
            // groupBoxLvUp
            // 
            this.groupBoxLvUp.Controls.Add(this.listBoxLevelUp);
            this.groupBoxLvUp.Controls.Add(this.buttonUpgrade);
            this.groupBoxLvUp.Controls.Add(this.radioButtonAtkSpeed);
            this.groupBoxLvUp.Controls.Add(this.radioButtonHappinessGain);
            this.groupBoxLvUp.Controls.Add(this.radioButtonDefense);
            this.groupBoxLvUp.Controls.Add(this.radioButtonEnergy);
            this.groupBoxLvUp.Controls.Add(this.radioButtonMaxHealth);
            this.groupBoxLvUp.Controls.Add(this.labelLevelPoint);
            this.groupBoxLvUp.Location = new System.Drawing.Point(1271, 21);
            this.groupBoxLvUp.Name = "groupBoxLvUp";
            this.groupBoxLvUp.Size = new System.Drawing.Size(641, 329);
            this.groupBoxLvUp.TabIndex = 13;
            this.groupBoxLvUp.TabStop = false;
            this.groupBoxLvUp.Text = "level up menu";
            // 
            // listBoxLevelUp
            // 
            this.listBoxLevelUp.FormattingEnabled = true;
            this.listBoxLevelUp.ItemHeight = 20;
            this.listBoxLevelUp.Location = new System.Drawing.Point(276, 18);
            this.listBoxLevelUp.Name = "listBoxLevelUp";
            this.listBoxLevelUp.Size = new System.Drawing.Size(334, 284);
            this.listBoxLevelUp.TabIndex = 25;
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.Location = new System.Drawing.Point(21, 213);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(249, 87);
            this.buttonUpgrade.TabIndex = 24;
            this.buttonUpgrade.Text = "upgrade";
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // radioButtonAtkSpeed
            // 
            this.radioButtonAtkSpeed.AutoSize = true;
            this.radioButtonAtkSpeed.Location = new System.Drawing.Point(21, 182);
            this.radioButtonAtkSpeed.Name = "radioButtonAtkSpeed";
            this.radioButtonAtkSpeed.Size = new System.Drawing.Size(140, 24);
            this.radioButtonAtkSpeed.TabIndex = 23;
            this.radioButtonAtkSpeed.TabStop = true;
            this.radioButtonAtkSpeed.Text = "AtkSpeed +0.1";
            this.radioButtonAtkSpeed.UseVisualStyleBackColor = true;
            // 
            // radioButtonHappinessGain
            // 
            this.radioButtonHappinessGain.AutoSize = true;
            this.radioButtonHappinessGain.Location = new System.Drawing.Point(21, 152);
            this.radioButtonHappinessGain.Name = "radioButtonHappinessGain";
            this.radioButtonHappinessGain.Size = new System.Drawing.Size(166, 24);
            this.radioButtonHappinessGain.TabIndex = 22;
            this.radioButtonHappinessGain.TabStop = true;
            this.radioButtonHappinessGain.Text = "HappinessGain +2";
            this.radioButtonHappinessGain.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefense
            // 
            this.radioButtonDefense.AutoSize = true;
            this.radioButtonDefense.Location = new System.Drawing.Point(21, 124);
            this.radioButtonDefense.Name = "radioButtonDefense";
            this.radioButtonDefense.Size = new System.Drawing.Size(126, 24);
            this.radioButtonDefense.TabIndex = 21;
            this.radioButtonDefense.TabStop = true;
            this.radioButtonDefense.Text = "Defense +50";
            this.radioButtonDefense.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnergy
            // 
            this.radioButtonEnergy.AutoSize = true;
            this.radioButtonEnergy.Location = new System.Drawing.Point(21, 98);
            this.radioButtonEnergy.Name = "radioButtonEnergy";
            this.radioButtonEnergy.Size = new System.Drawing.Size(115, 24);
            this.radioButtonEnergy.TabIndex = 20;
            this.radioButtonEnergy.TabStop = true;
            this.radioButtonEnergy.Text = "Energy +25";
            this.radioButtonEnergy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaxHealth
            // 
            this.radioButtonMaxHealth.AutoSize = true;
            this.radioButtonMaxHealth.Location = new System.Drawing.Point(21, 70);
            this.radioButtonMaxHealth.Name = "radioButtonMaxHealth";
            this.radioButtonMaxHealth.Size = new System.Drawing.Size(150, 24);
            this.radioButtonMaxHealth.TabIndex = 19;
            this.radioButtonMaxHealth.TabStop = true;
            this.radioButtonMaxHealth.Text = "MaxHealth +250";
            this.radioButtonMaxHealth.UseVisualStyleBackColor = true;
            // 
            // labelLevelPoint
            // 
            this.labelLevelPoint.AutoSize = true;
            this.labelLevelPoint.Location = new System.Drawing.Point(17, 36);
            this.labelLevelPoint.Name = "labelLevelPoint";
            this.labelLevelPoint.Size = new System.Drawing.Size(116, 20);
            this.labelLevelPoint.TabIndex = 18;
            this.labelLevelPoint.Text = "label level point";
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.Controls.Add(this.button9);
            this.groupBoxShop.Controls.Add(this.buttonDoneShop);
            this.groupBoxShop.Controls.Add(this.groupBox4);
            this.groupBoxShop.Controls.Add(this.groupBox3);
            this.groupBoxShop.Controls.Add(this.groupBox2);
            this.groupBoxShop.Controls.Add(this.labelCoins);
            this.groupBoxShop.Location = new System.Drawing.Point(1271, 356);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Size = new System.Drawing.Size(641, 540);
            this.groupBoxShop.TabIndex = 14;
            this.groupBoxShop.TabStop = false;
            this.groupBoxShop.Text = "shop";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(21, 75);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 395);
            this.button9.TabIndex = 4;
            this.button9.Text = "Feed";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // buttonDoneShop
            // 
            this.buttonDoneShop.Location = new System.Drawing.Point(21, 478);
            this.buttonDoneShop.Name = "buttonDoneShop";
            this.buttonDoneShop.Size = new System.Drawing.Size(589, 50);
            this.buttonDoneShop.TabIndex = 28;
            this.buttonDoneShop.Text = "Done";
            this.buttonDoneShop.UseVisualStyleBackColor = true;
            this.buttonDoneShop.Click += new System.EventHandler(this.buttonDoneShop_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonChageColor);
            this.groupBox4.Controls.Add(this.buttonChameleonSleep);
            this.groupBox4.Location = new System.Drawing.Point(142, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 130);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chameleon";
            // 
            // buttonChageColor
            // 
            this.buttonChageColor.Location = new System.Drawing.Point(10, 25);
            this.buttonChageColor.Name = "buttonChageColor";
            this.buttonChageColor.Size = new System.Drawing.Size(108, 98);
            this.buttonChageColor.TabIndex = 3;
            this.buttonChageColor.Text = "Change Color (100Coins)";
            this.buttonChageColor.UseVisualStyleBackColor = true;
            this.buttonChageColor.Click += new System.EventHandler(this.buttonChageColor_Click);
            // 
            // buttonChameleonSleep
            // 
            this.buttonChameleonSleep.Location = new System.Drawing.Point(124, 25);
            this.buttonChameleonSleep.Name = "buttonChameleonSleep";
            this.buttonChameleonSleep.Size = new System.Drawing.Size(108, 98);
            this.buttonChameleonSleep.TabIndex = 2;
            this.buttonChameleonSleep.Text = "Sleep (200Coins)";
            this.buttonChameleonSleep.UseVisualStyleBackColor = true;
            this.buttonChameleonSleep.Click += new System.EventHandler(this.buttonChameleonSleep_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonFishClean);
            this.groupBox3.Location = new System.Drawing.Point(142, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 130);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fish";
            // 
            // buttonFishClean
            // 
            this.buttonFishClean.Location = new System.Drawing.Point(6, 25);
            this.buttonFishClean.Name = "buttonFishClean";
            this.buttonFishClean.Size = new System.Drawing.Size(108, 98);
            this.buttonFishClean.TabIndex = 1;
            this.buttonFishClean.Text = "Clean (100Coins)";
            this.buttonFishClean.UseVisualStyleBackColor = true;
            this.buttonFishClean.Click += new System.EventHandler(this.buttonFishClean_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonVaccinate);
            this.groupBox2.Controls.Add(this.buttonCatBath);
            this.groupBox2.Controls.Add(this.buttonCatSleep);
            this.groupBox2.Controls.Add(this.buttonCatPlay);
            this.groupBox2.Location = new System.Drawing.Point(142, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 130);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cat";
            // 
            // buttonVaccinate
            // 
            this.buttonVaccinate.Location = new System.Drawing.Point(345, 25);
            this.buttonVaccinate.Name = "buttonVaccinate";
            this.buttonVaccinate.Size = new System.Drawing.Size(117, 98);
            this.buttonVaccinate.TabIndex = 3;
            this.buttonVaccinate.Text = "Vaccinate (500Coins)";
            this.buttonVaccinate.UseVisualStyleBackColor = true;
            this.buttonVaccinate.Click += new System.EventHandler(this.buttonVaccinate_Click);
            // 
            // buttonCatBath
            // 
            this.buttonCatBath.Location = new System.Drawing.Point(231, 26);
            this.buttonCatBath.Name = "buttonCatBath";
            this.buttonCatBath.Size = new System.Drawing.Size(108, 98);
            this.buttonCatBath.TabIndex = 2;
            this.buttonCatBath.Text = "Bath (150Coins)";
            this.buttonCatBath.UseVisualStyleBackColor = true;
            this.buttonCatBath.Click += new System.EventHandler(this.buttonCatBath_Click);
            // 
            // buttonCatSleep
            // 
            this.buttonCatSleep.Location = new System.Drawing.Point(117, 26);
            this.buttonCatSleep.Name = "buttonCatSleep";
            this.buttonCatSleep.Size = new System.Drawing.Size(108, 98);
            this.buttonCatSleep.TabIndex = 1;
            this.buttonCatSleep.Text = "Sleep (200Coins)";
            this.buttonCatSleep.UseVisualStyleBackColor = true;
            this.buttonCatSleep.Click += new System.EventHandler(this.buttonCatSleep_Click);
            // 
            // buttonCatPlay
            // 
            this.buttonCatPlay.Location = new System.Drawing.Point(3, 26);
            this.buttonCatPlay.Name = "buttonCatPlay";
            this.buttonCatPlay.Size = new System.Drawing.Size(108, 98);
            this.buttonCatPlay.TabIndex = 0;
            this.buttonCatPlay.Text = "Play (100Coins)";
            this.buttonCatPlay.UseVisualStyleBackColor = true;
            this.buttonCatPlay.Click += new System.EventHandler(this.buttonCatPlay_Click_1);
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.Location = new System.Drawing.Point(17, 42);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(83, 20);
            this.labelCoins.TabIndex = 25;
            this.labelCoins.Text = "label coins";
            // 
            // FormBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 935);
            this.Controls.Add(this.groupBoxShop);
            this.Controls.Add(this.groupBoxLvUp);
            this.Controls.Add(this.groupBoxChoosePet);
            this.Controls.Add(this.groupBoxBattle);
            this.Controls.Add(this.groupBoxChooseEnemy);
            this.Name = "FormBattle";
            this.Text = "Form Battle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxChooseEnemy.ResumeLayout(false);
            this.groupBoxChooseEnemy.PerformLayout();
            this.groupBoxBattle.ResumeLayout(false);
            this.groupBoxBattle.PerformLayout();
            this.groupBoxPetAction.ResumeLayout(false);
            this.groupBoxChoosePet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxLvUp.ResumeLayout(false);
            this.groupBoxLvUp.PerformLayout();
            this.groupBoxShop.ResumeLayout(false);
            this.groupBoxShop.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerBattle;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ListBox Door2;
        private System.Windows.Forms.ListBox Door1;
        private System.Windows.Forms.RadioButton radioButtonDoor2;
        private System.Windows.Forms.RadioButton radioButtonDoor1;
        private System.Windows.Forms.GroupBox groupBoxChooseEnemy;
        private System.Windows.Forms.GroupBox groupBoxBattle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonUlti;
        private System.Windows.Forms.GroupBox groupBoxPetAction;
        private System.Windows.Forms.Button buttonBasicAttack;
        private System.Windows.Forms.Button buttonSkill;
        private System.Windows.Forms.Label labelBattleNumber;
        private System.Windows.Forms.Label labelSkillPoint;
        private System.Windows.Forms.GroupBox groupBoxChoosePet;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxPet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFish;
        private System.Windows.Forms.RadioButton radioButtonChameleon;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.Label labelDebuff;
        private System.Windows.Forms.Label labelBuff;
        private System.Windows.Forms.GroupBox groupBoxLvUp;
        private System.Windows.Forms.GroupBox groupBoxShop;
        private System.Windows.Forms.RadioButton radioButtonMaxHealth;
        private System.Windows.Forms.Label labelLevelPoint;
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.RadioButton radioButtonAtkSpeed;
        private System.Windows.Forms.RadioButton radioButtonHappinessGain;
        private System.Windows.Forms.RadioButton radioButtonDefense;
        private System.Windows.Forms.RadioButton radioButtonEnergy;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.ListBox listBoxLevelUp;
        private System.Windows.Forms.Button buttonDoneShop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonChageColor;
        private System.Windows.Forms.Button buttonChameleonSleep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonFishClean;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonVaccinate;
        private System.Windows.Forms.Button buttonCatBath;
        private System.Windows.Forms.Button buttonCatSleep;
        private System.Windows.Forms.Button buttonCatPlay;
    }
}

