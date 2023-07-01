
namespace happy_pet_game_2019
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonUlti = new System.Windows.Forms.Button();
            this.groupBoxPetAction = new System.Windows.Forms.GroupBox();
            this.buttonSkill = new System.Windows.Forms.Button();
            this.buttonBasicAttack = new System.Windows.Forms.Button();
            this.labelBattleNumber = new System.Windows.Forms.Label();
            this.labelSkillPoint = new System.Windows.Forms.Label();
            this.groupBoxChooseEnemy.SuspendLayout();
            this.groupBoxBattle.SuspendLayout();
            this.groupBoxPetAction.SuspendLayout();
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
            this.groupBoxChooseEnemy.Location = new System.Drawing.Point(819, 69);
            this.groupBoxChooseEnemy.Name = "groupBoxChooseEnemy";
            this.groupBoxChooseEnemy.Size = new System.Drawing.Size(432, 540);
            this.groupBoxChooseEnemy.TabIndex = 10;
            this.groupBoxChooseEnemy.TabStop = false;
            this.groupBoxChooseEnemy.Text = "Choose Enemy";
            // 
            // groupBoxBattle
            // 
            this.groupBoxBattle.Controls.Add(this.labelSkillPoint);
            this.groupBoxBattle.Controls.Add(this.groupBoxPetAction);
            this.groupBoxBattle.Controls.Add(this.listBox1);
            this.groupBoxBattle.Location = new System.Drawing.Point(18, 69);
            this.groupBoxBattle.Name = "groupBoxBattle";
            this.groupBoxBattle.Size = new System.Drawing.Size(795, 540);
            this.groupBoxBattle.TabIndex = 11;
            this.groupBoxBattle.TabStop = false;
            this.groupBoxBattle.Text = "Battle";
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
            // labelBattleNumber
            // 
            this.labelBattleNumber.AutoSize = true;
            this.labelBattleNumber.Location = new System.Drawing.Point(25, 24);
            this.labelBattleNumber.Name = "labelBattleNumber";
            this.labelBattleNumber.Size = new System.Drawing.Size(144, 20);
            this.labelBattleNumber.TabIndex = 13;
            this.labelBattleNumber.Text = "label battle number";
            // 
            // labelSkillPoint
            // 
            this.labelSkillPoint.AutoSize = true;
            this.labelSkillPoint.Location = new System.Drawing.Point(37, 44);
            this.labelSkillPoint.Name = "labelSkillPoint";
            this.labelSkillPoint.Size = new System.Drawing.Size(105, 20);
            this.labelSkillPoint.TabIndex = 15;
            this.labelSkillPoint.Text = "label skill poin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 649);
            this.Controls.Add(this.labelBattleNumber);
            this.Controls.Add(this.groupBoxBattle);
            this.Controls.Add(this.groupBoxChooseEnemy);
            this.Name = "Form1";
            this.Text = "Form Battle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxChooseEnemy.ResumeLayout(false);
            this.groupBoxChooseEnemy.PerformLayout();
            this.groupBoxBattle.ResumeLayout(false);
            this.groupBoxBattle.PerformLayout();
            this.groupBoxPetAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

