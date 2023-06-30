
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
            this.checkBox2Xspeed = new System.Windows.Forms.CheckBox();
            this.buttonUlti = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButtonPause = new System.Windows.Forms.RadioButton();
            this.radioButtonPlay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxChooseEnemy.SuspendLayout();
            this.groupBoxBattle.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerBattle
            // 
            this.timerBattle.Interval = 2;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(28, 408);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(378, 58);
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
            this.groupBoxChooseEnemy.Size = new System.Drawing.Size(432, 480);
            this.groupBoxChooseEnemy.TabIndex = 10;
            this.groupBoxChooseEnemy.TabStop = false;
            this.groupBoxChooseEnemy.Text = "Choose Enemy";
            // 
            // groupBoxBattle
            // 
            this.groupBoxBattle.Controls.Add(this.radioButtonPlay);
            this.groupBoxBattle.Controls.Add(this.radioButtonPause);
            this.groupBoxBattle.Controls.Add(this.checkBox2Xspeed);
            this.groupBoxBattle.Controls.Add(this.listBox1);
            this.groupBoxBattle.Controls.Add(this.buttonUlti);
            this.groupBoxBattle.Location = new System.Drawing.Point(18, 69);
            this.groupBoxBattle.Name = "groupBoxBattle";
            this.groupBoxBattle.Size = new System.Drawing.Size(795, 480);
            this.groupBoxBattle.TabIndex = 11;
            this.groupBoxBattle.TabStop = false;
            this.groupBoxBattle.Text = "Battle";
            // 
            // checkBox2Xspeed
            // 
            this.checkBox2Xspeed.AutoSize = true;
            this.checkBox2Xspeed.Location = new System.Drawing.Point(653, 40);
            this.checkBox2Xspeed.Name = "checkBox2Xspeed";
            this.checkBox2Xspeed.Size = new System.Drawing.Size(103, 24);
            this.checkBox2Xspeed.TabIndex = 14;
            this.checkBox2Xspeed.Text = "2X speed";
            this.checkBox2Xspeed.UseVisualStyleBackColor = true;
            // 
            // buttonUlti
            // 
            this.buttonUlti.Location = new System.Drawing.Point(37, 408);
            this.buttonUlti.Name = "buttonUlti";
            this.buttonUlti.Size = new System.Drawing.Size(90, 38);
            this.buttonUlti.TabIndex = 13;
            this.buttonUlti.Text = "Ulti";
            this.buttonUlti.UseVisualStyleBackColor = true;
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
            // radioButtonPause
            // 
            this.radioButtonPause.AutoSize = true;
            this.radioButtonPause.Location = new System.Drawing.Point(37, 40);
            this.radioButtonPause.Name = "radioButtonPause";
            this.radioButtonPause.Size = new System.Drawing.Size(79, 24);
            this.radioButtonPause.TabIndex = 15;
            this.radioButtonPause.TabStop = true;
            this.radioButtonPause.Text = "Pause";
            this.radioButtonPause.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlay
            // 
            this.radioButtonPlay.AutoSize = true;
            this.radioButtonPlay.Location = new System.Drawing.Point(122, 40);
            this.radioButtonPlay.Name = "radioButtonPlay";
            this.radioButtonPlay.Size = new System.Drawing.Size(63, 24);
            this.radioButtonPlay.TabIndex = 16;
            this.radioButtonPlay.TabStop = true;
            this.radioButtonPlay.Text = "Play";
            this.radioButtonPlay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxBattle);
            this.Controls.Add(this.groupBoxChooseEnemy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxChooseEnemy.ResumeLayout(false);
            this.groupBoxChooseEnemy.PerformLayout();
            this.groupBoxBattle.ResumeLayout(false);
            this.groupBoxBattle.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox2Xspeed;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonUlti;
        private System.Windows.Forms.RadioButton radioButtonPlay;
        private System.Windows.Forms.RadioButton radioButtonPause;
        private System.Windows.Forms.Label label1;
    }
}

