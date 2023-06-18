
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.battleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPetStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeresizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeresizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPet.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPet.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPet.Image")));
            this.pictureBoxPet.Location = new System.Drawing.Point(368, 162);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(225, 170);
            this.pictureBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPet.TabIndex = 0;
            this.pictureBoxPet.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(368, 133);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(225, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(165)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.battleToolStripMenuItem,
            this.showInventoryToolStripMenuItem,
            this.showPetStatToolStripMenuItem,
            this.shopToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.maximizeresizeToolStripMenuItem,
            this.minimizeresizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // battleToolStripMenuItem
            // 
            this.battleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.battleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("battleToolStripMenuItem.Image")));
            this.battleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.battleToolStripMenuItem.Name = "battleToolStripMenuItem";
            this.battleToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.battleToolStripMenuItem.Text = "Battle";
            this.battleToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.battleToolStripMenuItem.Click += new System.EventHandler(this.battleToolStripMenuItem_Click);
            // 
            // showInventoryToolStripMenuItem
            // 
            this.showInventoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showInventoryToolStripMenuItem.Image")));
            this.showInventoryToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showInventoryToolStripMenuItem.Name = "showInventoryToolStripMenuItem";
            this.showInventoryToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.showInventoryToolStripMenuItem.Text = "Show Inventory";
            this.showInventoryToolStripMenuItem.Click += new System.EventHandler(this.showInventoryToolStripMenuItem_Click);
            // 
            // showPetStatToolStripMenuItem
            // 
            this.showPetStatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPetStatToolStripMenuItem.Image")));
            this.showPetStatToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showPetStatToolStripMenuItem.Name = "showPetStatToolStripMenuItem";
            this.showPetStatToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.showPetStatToolStripMenuItem.Text = "Show Pet Stat";
            this.showPetStatToolStripMenuItem.Click += new System.EventHandler(this.showPetStatToolStripMenuItem_Click);
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shopToolStripMenuItem.Image")));
            this.shopToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.shopToolStripMenuItem.Text = "Shop";
            this.shopToolStripMenuItem.Click += new System.EventHandler(this.shopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maximizeresizeToolStripMenuItem
            // 
            this.maximizeresizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximizeresizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("maximizeresizeToolStripMenuItem.Image")));
            this.maximizeresizeToolStripMenuItem.Name = "maximizeresizeToolStripMenuItem";
            this.maximizeresizeToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.maximizeresizeToolStripMenuItem.Text = "Maximize";
            this.maximizeresizeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.maximizeresizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeresizeToolStripMenuItem_Click);
            // 
            // minimizeresizeToolStripMenuItem
            // 
            this.minimizeresizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizeresizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizeresizeToolStripMenuItem.Image")));
            this.minimizeresizeToolStripMenuItem.Name = "minimizeresizeToolStripMenuItem";
            this.minimizeresizeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.minimizeresizeToolStripMenuItem.Text = "Minimize";
            this.minimizeresizeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.minimizeresizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeresizeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(165)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(910, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(165)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 426);
            this.panel2.TabIndex = 4;
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
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
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

        private System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.ProgressBar progressBar1;
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
    }
}

