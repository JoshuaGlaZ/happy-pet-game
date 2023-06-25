using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace happy_pet_game_2019
{
    public partial class FormStart : Form
    {
        FormMenu formMenu;
        public FormStart()
        {
            InitializeComponent();
        }
        private void FormStart_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
            ButtonResetGameState();
        }
        private void ButtonResetGameState()
        {
            if (File.Exists("playerData.dat")) {  buttonResetGame.Enabled = true; }
            else { buttonResetGame.Enabled = false; }
        }

        private void maximizeresizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizeresizeToolStripMenuItem.Text = "Resize";
                maximizeresizeToolStripMenuItem.Image = Properties.Resources.ExitFullScreen;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                maximizeresizeToolStripMenuItem.Text = "Maximize";
                maximizeresizeToolStripMenuItem.Image = Properties.Resources.Scale;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeresizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region PanelMain
        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Selecting Player";
            panelLoadPlayer.Width = 947;
            panelMain.Width = panelNewPlayer.Width = panelReset.Width = 0;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Creating Player";
            panelNewPlayer.Width = panelMain.Width;
            panelMain.Width = panelLoadPlayer.Width = panelReset.Width = 0;
        }

        private void buttonLoadBack_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Happy Pet";
            panelMain.Width = panelLoadPlayer.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            ButtonResetGameState();
        }

        private void buttonNewBack_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Happy Pet";
            panelMain.Width = panelNewPlayer.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            ButtonResetGameState();
        }

        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Reseting Player";
            panelReset.Width = panelMain.Width;
            panelMain.Width = panelNewPlayer.Width = panelLoadPlayer.Width = 0;
        }

        private void buttonResetBack_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Happy Pet";
            panelMain.Width = panelReset.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            ButtonResetGameState();
        }

        #endregion

        #region PanelNew
        private void ChangePictureBoxChoosePet()
        {
            if (radioButtonChooseCat.Checked)
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.cat_happy;
            }
            else if (radioButtonChooseFish.Checked)
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.fish_happy;
            }
            else
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.chameleon_happy;
            }
        }
        private void comboBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLoadPlayers.SelectedIndex == -1)
            {
                labelLoadRuntime.Visible = false;
                labelLoadPetName.Visible = false;
                labelLoadPetLevel.Visible = false;
                pictureBoxLoadPet.Visible = false;
                listBoxLoadStat.Visible = false;
                listBoxLoadProgress.Visible = false;
                buttonLoadReady.Visible = false;
            }
            else
            {
                labelLoadRuntime.Visible = true;
                labelLoadPetName.Visible = true;
                labelLoadPetLevel.Visible = true;
                pictureBoxLoadPet.Visible = true;
                listBoxLoadStat.Visible = true;
                listBoxLoadProgress.Visible = true;
                buttonLoadReady.Visible = true;
            }
        }

        private void buttonNewReady_Click(object sender, EventArgs e)
        {
            string playerName = textBoxNewPlayerName.Text;
            string petName = textBoxNewPetName.Text;
            string petTrait;
            if (radioButtonStrength.Checked) { petTrait = radioButtonStrength.Text; }
            else if (radioButtonEndurance.Checked) { petTrait = radioButtonEndurance.Text; }
            else if (radioButtonWillpower.Checked) { petTrait = radioButtonWillpower.Text; }
            else if (radioButtonHealth.Checked) { petTrait = radioButtonHealth.Text; }
            else { petTrait = radioButtonWeird.Text; }
        }

        private void radioButtonChooseCat_CheckedChanged(object sender, EventArgs e)
        {
            ChangePictureBoxChoosePet();
        }

        private void radioButtonChooseFish_CheckedChanged(object sender, EventArgs e)
        {
            ChangePictureBoxChoosePet();
        }

        private void radioButtonChooseChamaleon_CheckedChanged(object sender, EventArgs e)
        {
            ChangePictureBoxChoosePet();
        }

        private void linkLabelClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelStart.Text = "Creating Player";
            panelNewPlayer.Width = panelMain.Width;
            panelMain.Width = panelLoadPlayer.Width = panelReset.Width = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    pictureBoxCat.Enabled = true;
        //    pictureBoxCat.Visible = true;
        //    pictureBoxFish.Enabled = true;
        //    pictureBoxFish.Visible = true;
        //    pictureBoxChamaleon.Enabled = true;
        //    pictureBoxChamaleon.Visible = true;
        //}
    }
}
