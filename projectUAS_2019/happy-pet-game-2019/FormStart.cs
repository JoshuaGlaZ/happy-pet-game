using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region PanelMain
        private void ButtonResetGameState()
        {
            if (File.Exists("playerData.dat"))
            {
                buttonResetGame.Enabled = true;
                buttonResetGame.BackgroundImage = Properties.Resources.buttonlarge_normal;
            }
            else
            {
                buttonResetGame.Enabled = false;
                buttonResetGame.BackgroundImage = Properties.Resources.buttonlarge_disable;
            }
        }

        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Selecting Player";
            panelLoadPlayer.Width = panelMain.Width;
            panelMain.Width = panelNewPlayer.Width = panelReset.Width = 0;
            LoadPanelState();
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
            comboBoxLoadPlayers.SelectedIndex = -1;
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
        private void buttonNewReady_Click(object sender, EventArgs e)
        {
            string playerName = textBoxNewPlayerName.Text;
            string petName = textBoxNewPetName.Text;
            string petTrait;
            if (radioButtonStrength.Checked) { petTrait = radioButtonStrength.Text; }
            else if (radioButtonEndurance.Checked) { petTrait = radioButtonEndurance.Text; }
            else if (radioButtonWillpower.Checked) { petTrait = radioButtonWillpower.Text; }
            else { petTrait = radioButtonHealth.Text; }
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
        #endregion

        #region PanelLoad
        private void comboBoxLoadPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPanelState();
        }

        private void LoadPanelState()
        {
            if (comboBoxLoadPlayers.SelectedIndex == -1)
            {
                pictureBoxLoadBorder.Visible = false;
                labelLoadRuntime.Visible = false;
                labelLoadPetName.Visible = false;
                labelLoadPetLevel.Visible = false;
                pictureBoxLoadPet.Visible = false;
                pictureBoxLoadPetBorder.Visible = false;
                listBoxLoadStat.Visible = false;
                pictureBoxLoadStatBorder.Visible = false;
                listBoxLoadProgress.Visible = false;
                pictureBoxLoadProgressBorder.Visible = false;
                buttonLoadReady.Visible = false;
                labelNewPlayer.Visible = true;
                linkLabelClickHere.Visible = true;
            }
            else
            {
                pictureBoxLoadBorder.Visible = true;
                labelLoadRuntime.Visible = true;
                labelLoadPetName.Visible = true;
                labelLoadPetLevel.Visible = true;
                pictureBoxLoadPet.Visible = true;
                pictureBoxLoadPetBorder.Visible = true;
                listBoxLoadStat.Visible = true;
                pictureBoxLoadStatBorder.Visible = true;
                listBoxLoadProgress.Visible = true;
                pictureBoxLoadProgressBorder.Visible = true;
                buttonLoadReady.Visible = true;
                labelNewPlayer.Visible = false;
                linkLabelClickHere.Visible = false;
            }
        }
        private void linkLabelClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelStart.Text = "Creating Player";
            panelNewPlayer.Width = panelMain.Width;
            panelMain.Width = panelLoadPlayer.Width = panelReset.Width = 0;
        }

        #endregion

        private void radioButtonStrength_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHealth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonEndurance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonWillpower_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
