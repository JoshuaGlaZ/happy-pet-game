﻿
namespace happy_pet_game_2019
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.battleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPetStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeresizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeresizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPet.Enabled = false;
            this.pictureBoxPet.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPet.Image")));
            this.pictureBoxPet.Location = new System.Drawing.Point(296, 185);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPet.TabIndex = 0;
            this.pictureBoxPet.TabStop = false;
            this.pictureBoxPet.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(165)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.battleToolStripMenuItem,
            this.showPetStatToolStripMenuItem,
            this.showInventoryToolStripMenuItem,
            this.shopToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.maximizeresizeToolStripMenuItem,
            this.minimizeresizeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // battleToolStripMenuItem
            // 
            this.battleToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.battleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.battleToolStripMenuItem.Name = "battleToolStripMenuItem";
            this.battleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.battleToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.battleToolStripMenuItem.Text = "Battle";
            this.battleToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.battleToolStripMenuItem.Click += new System.EventHandler(this.battleToolStripMenuItem_Click);
            // 
            // showPetStatToolStripMenuItem
            // 
            this.showPetStatToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPetStatToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showPetStatToolStripMenuItem.Name = "showPetStatToolStripMenuItem";
            this.showPetStatToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.showPetStatToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.showPetStatToolStripMenuItem.Text = "Show Pet Stat";
            this.showPetStatToolStripMenuItem.Click += new System.EventHandler(this.showPetStatToolStripMenuItem_Click);
            // 
            // showInventoryToolStripMenuItem
            // 
            this.showInventoryToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInventoryToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showInventoryToolStripMenuItem.Name = "showInventoryToolStripMenuItem";
            this.showInventoryToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.showInventoryToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.showInventoryToolStripMenuItem.Text = "Show Inventory";
            this.showInventoryToolStripMenuItem.Click += new System.EventHandler(this.showInventoryToolStripMenuItem_Click);
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.shopToolStripMenuItem.Text = "Shop";
            this.shopToolStripMenuItem.Click += new System.EventHandler(this.shopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.exitToolStripMenuItem.Text = "EXIT";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maximizeresizeToolStripMenuItem
            // 
            this.maximizeresizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximizeresizeToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeresizeToolStripMenuItem.Name = "maximizeresizeToolStripMenuItem";
            this.maximizeresizeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.maximizeresizeToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.maximizeresizeToolStripMenuItem.Text = "RESIZE";
            this.maximizeresizeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.maximizeresizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeresizeToolStripMenuItem_Click);
            // 
            // minimizeresizeToolStripMenuItem
            // 
            this.minimizeresizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizeresizeToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeresizeToolStripMenuItem.Name = "minimizeresizeToolStripMenuItem";
            this.minimizeresizeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.minimizeresizeToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.minimizeresizeToolStripMenuItem.Text = "MINIMIZE";
            this.minimizeresizeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.minimizeresizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeresizeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePetToolStripMenuItem,
            this.resetGameToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // changePetToolStripMenuItem
            // 
            this.changePetToolStripMenuItem.Name = "changePetToolStripMenuItem";
            this.changePetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePetToolStripMenuItem.Text = "Change Pet";
            this.changePetToolStripMenuItem.Click += new System.EventHandler(this.changePetToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(165)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(778, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 474);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(165)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 474);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Informal Roman", 20F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(390, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Let\'s Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(165)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem battleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPetStatToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem minimizeresizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeresizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.ToolStripMenuItem changePetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

