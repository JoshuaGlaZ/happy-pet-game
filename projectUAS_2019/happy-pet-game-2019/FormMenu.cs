﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace happy_pet_game_2019
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists("playerData.dat"))
            {

            }
            else
            {
                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void battleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showPetStatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShop formShop = new FormShop();
            formShop.Owner = this;
            formShop.ShowDialog();
        }

        private void maximizeresizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeresizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("playerData.dat"))
            {
                DialogResult userChoice = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (userChoice == DialogResult.Yes)
                {
                    File.Delete("playerData.dat");
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
