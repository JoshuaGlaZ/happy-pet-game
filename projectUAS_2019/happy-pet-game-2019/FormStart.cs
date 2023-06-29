using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace happy_pet_game_2019
{
    public partial class FormStart : Form
    {
        FormMenu formMenu;
        public BindingList<Player> listPlayers = new BindingList<Player>();

        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            ButtonResetGameState();
            DeserializeListPlayers();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        #region PanelMain

        private void SerializeListPlayers()
        {
            FileStream playerFile = new FileStream("playerData.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(playerFile, listPlayers);
            playerFile.Close();
            ComboBoxReload();
        }
        private void DeserializeListPlayers()
        {
            if (File.Exists("playerData.dat"))
            {
                FileStream playerFile = new FileStream("playerData.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                listPlayers = binary.Deserialize(playerFile) as BindingList<Player>;
                playerFile.Close();
            }
            ComboBoxReload();
        }

        private void ComboBoxReload()
        {
            comboBoxLoadPlayers.DataSource = listPlayers;
            comboBoxLoadPlayers.DisplayMember = "Name";
            comboBoxResetPlayers.DataSource = listPlayers;
            comboBoxResetPlayers.DisplayMember = "Name";
        }

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

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Creating Player";
            panelNewPlayer.Width = panelMain.Width;
            panelMain.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            NewPanelState();
        }

        private void buttonNewGame_MouseEnter(object sender, EventArgs e)
        {
            buttonNewGame.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonNewGame_MouseLeave(object sender, EventArgs e)
        {
            buttonNewGame.BackgroundImage = Properties.Resources.buttonlarge_normal;
        }

        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Selecting Player";
            panelLoadPlayer.Width = panelMain.Width;
            panelMain.Width = panelNewPlayer.Width = panelReset.Width = 0;
            LoadPanelState(); DeserializeListPlayers(); comboBoxLoadPlayers.SelectedIndex = -1;
            //DeserializeListPlayers() disini akan dihapus kalau tekan ready di panel new ada code (Lanjut ke formMenu / formBattle)
        }
        private void buttonLoadGame_MouseEnter(object sender, EventArgs e)
        {
            buttonLoadGame.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }
        private void buttonLoadGame_MouseLeave(object sender, EventArgs e)
        {
            buttonLoadGame.BackgroundImage = Properties.Resources.buttonlarge_normal;
        }

        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Reseting Player";
            panelReset.Width = panelMain.Width;
            panelMain.Width = panelNewPlayer.Width = panelLoadPlayer.Width = 0;
            ResetPanelState(); DeserializeListPlayers(); comboBoxResetPlayers.SelectedIndex = -1;
        }

        private void buttonResetGame_MouseEnter(object sender, EventArgs e)
        {
            buttonResetGame.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonResetGame_MouseLeave(object sender, EventArgs e)
        {
            buttonResetGame.BackgroundImage = Properties.Resources.buttonlarge_normal;
        }
        #endregion

        #region PanelNew
        private void NewPanelState()
        {
            textBoxNewPlayerName.Clear();
            textBoxNewPetName.Clear();
            radioButtonChooseCat.Checked = true;
            radioButtonChooseFish.Checked = false;
            radioButtonChooseChamaleon.Checked = false;
            ChangePictureBoxChoosePet(); DisplayTraitStat();
            radioButtonStrength.Checked = true;
            radioButtonEndurance.Checked = false;
            radioButtonWillpower.Checked = false;
            radioButtonHealth.Checked = false;
        }
        private void ChangePictureBoxChoosePet()
        {
            if (radioButtonChooseCat.Checked)
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.cat;
                buttonChooseColor.Enabled = false;
                buttonChooseColor.Visible = false;
            }
            else if (radioButtonChooseFish.Checked)
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.fish_happy;
                buttonChooseColor.Enabled = false;
                buttonChooseColor.Visible = false;
            }
            else
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.chameleon_green;
                buttonChooseColor.Enabled = true;
                buttonChooseColor.Visible = true;
            }
        }
        private void DisplayTraitStat()
        {
            listBoxNewStat.Items.Clear();
            if (radioButtonStrength.Checked) { listBoxNewStat.Items.Add("Strength Stat : "); }
            else if (radioButtonHealth.Checked) { listBoxNewStat.Items.Add("Health Stat : "); }
            else if (radioButtonEndurance.Checked) { listBoxNewStat.Items.Add("Endurance Stat : "); }
            else { listBoxNewStat.Items.Add("Willpower Stat : "); }
        }
        private Color SelectChameleonColor()
        {
            if (panelChameleonColor.Visible == true)
            {
                if (radioButtonGreen.Checked) { return Color.Green; }
                else if (radioButtonBlue.Checked) { return Color.Blue; }
                else if (radioButtonRed.Checked) { return Color.Red; }
                else if (radioButtonYellow.Checked){ return Color.Yellow; }
                else { throw new Exception("Please select your pet color"); }
            }
            else
            {
                if ((string)pictureBoxNewChoosePet.Tag == "green")
                { return Color.Green; }
                else if ((string)pictureBoxNewChoosePet.Tag == "blue")
                { return Color.Blue; }
                else if ((string)pictureBoxNewChoosePet.Tag == "red")
                { return Color.Red; }
                else if ((string)pictureBoxNewChoosePet.Tag == "yellow")
                { return Color.Yellow; }
                else { throw new Exception("Please choose your desired pet color"); }
            }
        }
        private void radioButtonChooseCat_CheckedChanged(object sender, EventArgs e)
        {   ChangePictureBoxChoosePet(); }

        private void radioButtonChooseFish_CheckedChanged(object sender, EventArgs e)
        {   ChangePictureBoxChoosePet(); }

        private void radioButtonChooseChamaleon_CheckedChanged(object sender, EventArgs e)
        {   ChangePictureBoxChoosePet(); }

        private void radioButtonStrength_CheckedChanged(object sender, EventArgs e)
        {   DisplayTraitStat(); }

        private void radioButtonHealth_CheckedChanged(object sender, EventArgs e)
        {   DisplayTraitStat(); }

        private void radioButtonEndurance_CheckedChanged(object sender, EventArgs e)
        {   DisplayTraitStat(); }

        private void radioButtonWillpower_CheckedChanged(object sender, EventArgs e)
        {   DisplayTraitStat(); }

        private void buttonNewBack_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Happy Pet";
            panelMain.Width = panelNewPlayer.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            ButtonResetGameState();
        }

        private void buttonNewBack_MouseEnter(object sender, EventArgs e)
        {   buttonNewBack.BackgroundImage = Properties.Resources.buttonback_pressed; }

        private void buttonNewBack_MouseLeave(object sender, EventArgs e)
        {   buttonNewBack.BackgroundImage = Properties.Resources.buttonback; }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {   pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_blue; }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {   pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_green; }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {   pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_red; }

        private void radioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {   pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_yellow; }

        private void buttonChooseColor_Click(object sender, EventArgs e)
        {
            if (radioButtonChooseChamaleon.Checked)
            {
                panelChameleonColor.Visible = true;
                listBoxNewStat.Items.Clear();
                if (buttonChooseColor.Text == "Accept ?")
                {
                    if (SelectChameleonColor() == Color.Green)
                    {
                        pictureBoxNewChoosePet.Image = Properties.Resources.chameleon_green;
                        pictureBoxNewChoosePet.Tag = "green";
                        listBoxNewStat.Items.Add("Chameleon color now is green");
                    }
                    else if (SelectChameleonColor() == Color.Blue)
                    {
                        pictureBoxNewChoosePet.Image = Properties.Resources.chameleon_blue;
                        pictureBoxNewChoosePet.Tag = "blue";
                        listBoxNewStat.Items.Add("Chameleon color now is blue");
                    }
                    else if (SelectChameleonColor() == Color.Red)
                    {
                        pictureBoxNewChoosePet.Image = Properties.Resources.chameleon_red;
                        pictureBoxNewChoosePet.Tag = "red";
                        listBoxNewStat.Items.Add("Chameleon color now is red");
                    }
                    else
                    {
                        pictureBoxNewChoosePet.Image = Properties.Resources.chameleon_yellow;
                        pictureBoxNewChoosePet.Tag = "yellow";
                        listBoxNewStat.Items.Add("Chameleon color now is yellow");
                    }
                    panelChameleonColor.Visible = false;
                    buttonChooseColor.Text = "Choose" + "\nColor";
                }
                else {  buttonChooseColor.Text = "Accept ?"; }
            }
        }

        private void buttonChooseColor_MouseEnter(object sender, EventArgs e)
        {   buttonChooseColor.BackgroundImage = Properties.Resources.buttonlarge_pressed; }

        private void buttonChooseColor_MouseLeave(object sender, EventArgs e)
        {   buttonChooseColor.BackgroundImage = Properties.Resources.buttonlarge_normal; }

        private void buttonNewReady_MouseEnter(object sender, EventArgs e)
        {   buttonNewReady.BackgroundImage = Properties.Resources.buttonlarge_pressed; }

        private void buttonNewReady_MouseLeave(object sender, EventArgs e)
        {   buttonNewReady.BackgroundImage = Properties.Resources.buttonlarge_normal; }

        private void buttonNewReady_Click(object sender, EventArgs e)
        {
            try
            {
                string playerName = textBoxNewPlayerName.Text;
                string petName = textBoxNewPetName.Text;
                Image petPicture = pictureBoxNewChoosePet.Image;
                string petTrait;
                if (radioButtonStrength.Checked) { petTrait = radioButtonStrength.Text; }
                else if (radioButtonEndurance.Checked) { petTrait = radioButtonEndurance.Text; }
                else if (radioButtonWillpower.Checked) { petTrait = radioButtonWillpower.Text; }
                else if (radioButtonHealth.Checked) { petTrait = radioButtonHealth.Text; }
                else { throw new Exception("Please choose your pet trait"); }

                Player newPlayer = new Player(playerName);
                if (radioButtonChooseCat.Checked) { newPlayer.AddPetCat(petName, petTrait, petPicture); }
                else if (radioButtonChooseFish.Checked)
                { newPlayer.AddPetFish(petName, petTrait, petPicture); }
                else if (radioButtonChooseChamaleon.Checked)
                { newPlayer.AddPetChamaleon(petName, petTrait, petPicture, SelectChameleonColor()); }
                else { throw new Exception("Please select your pet"); }

                listPlayers.Add(newPlayer);
                listBoxNewStat.Items.AddRange(newPlayer.DisplayPetStat().Split('\n'));
                SerializeListPlayers();

                //formMenu = new FormMenu();
                //formMenu.Owner = this;
                //formMenu.ShowDialog();
            }
            catch (Exception ex)
            {   MessageBox.Show(ex.Message); }
        }

        #endregion

        #region PanelLoad
        private void comboBoxLoadPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPanelState();
            listBoxLoadStat.Items.Clear();
            if (comboBoxLoadPlayers.SelectedIndex != -1)
            {
                Player selectedPlayer = (Player)comboBoxLoadPlayers.SelectedItem;
                labelLoadRuntime.Text = selectedPlayer.Lastplay.ToString();
                labelLoadPetName.Text = selectedPlayer.ChoosenPet.Name;
                pictureBoxLoadPet.Image = selectedPlayer.ChoosenPet.Picture;
                listBoxLoadStat.Items.AddRange(selectedPlayer.ChoosenPet.ToString().Split('\n'));
            }
        }

        private void LoadPanelState()
        {
            if (comboBoxLoadPlayers.SelectedIndex == -1)
            {
                pictureBoxLoadBorder.Visible = false;
                labelLoadRuntime.Visible = false; 
                labelLoadPetName.Visible = false;
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
            panelNewPlayer.Width = panelLoadPlayer.Width;
            panelLoadPlayer.Width = panelMain.Width = panelReset.Width = 0;
        }

        private void buttonLoadBack_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Happy Pet";
            panelMain.Width = panelLoadPlayer.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            ButtonResetGameState(); 
            labelLoadRuntime.Text = "";
            labelLoadPetName.Text = "";
            pictureBoxLoadPet.Image = null;
            comboBoxLoadPlayers.SelectedIndex = -1;
        }

        private void buttonLoadBack_MouseEnter(object sender, EventArgs e)
        {   buttonLoadBack.BackgroundImage = Properties.Resources.buttonback_pressed; }

        private void buttonLoadBack_MouseLeave(object sender, EventArgs e)
        {   buttonLoadBack.BackgroundImage = Properties.Resources.buttonback; }

        private void buttonLoadReady_MouseEnter(object sender, EventArgs e)
        {   buttonLoadReady.BackgroundImage = Properties.Resources.buttonlarge_pressed; }

        private void buttonLoadReady_MouseLeave(object sender, EventArgs e)
        {   buttonLoadReady.BackgroundImage = Properties.Resources.buttonlarge_normal;  }
        #endregion

        #region PanelReset
        private void ResetPanelState()
        {
            if (comboBoxResetPlayers.SelectedIndex == -1)
            {
                pictureBoxResetBorder.Visible = false;
                labelResetPetName.Visible = false;
                labelAreYouSure.Visible = false;
                labelResetRuntime.Visible = false;
                pictureBoxResetPet.Visible = false;
                listBoxResetStat.Visible = false;
                pictureBoxResetStatBorder.Visible = false;
                pictureBoxResetPetBorder.Visible = false;
                buttonResetYes.Visible = false;
                buttonResetNo.Visible = false;
            }
            else
            {
                pictureBoxResetBorder.Visible = true;
                labelResetPetName.Visible = true;
                labelAreYouSure.Visible = true;
                labelResetRuntime.Visible = true;
                pictureBoxResetPet.Visible = true;
                listBoxResetStat.Visible = true;
                pictureBoxResetStatBorder.Visible = true;
                pictureBoxResetPetBorder.Visible = true;
                buttonResetYes.Visible = true;
                buttonResetNo.Visible = true;
            }
        }
        private void buttonResetBack_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Happy Pet";
            panelMain.Width = panelReset.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            ButtonResetGameState();
            labelResetRuntime.Text = "";
            labelResetPetName.Text = "";
            pictureBoxResetPet.Image = null;
            comboBoxResetPlayers.SelectedIndex = -1;
        }

        private void buttonResetBack_MouseEnter(object sender, EventArgs e)
        {
            buttonResetBack.BackgroundImage = Properties.Resources.buttonback_pressed;
        }

        private void buttonResetBack_MouseLeave(object sender, EventArgs e)
        {
            buttonResetBack.BackgroundImage = Properties.Resources.buttonback;
        }

        private void buttonResetYes_MouseEnter(object sender, EventArgs e)
        {
            buttonResetYes.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonResetYes_MouseLeave(object sender, EventArgs e)
        {
            buttonResetYes.BackgroundImage = Properties.Resources.buttonlarge_normal;
        }

        private void buttonResetNo_MouseEnter(object sender, EventArgs e)
        {
            buttonResetNo.BackgroundImage = Properties.Resources.buttonlarge_pressed;
        }

        private void buttonResetNo_MouseLeave(object sender, EventArgs e)
        {
            buttonResetNo.BackgroundImage = Properties.Resources.buttonlarge_normal;
        }

        private void comboBoxResetPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetPanelState();
            listBoxResetStat.Items.Clear();
            if (comboBoxResetPlayers.SelectedIndex != -1)
            {
                Player selectedPlayer = (Player)comboBoxResetPlayers.SelectedItem;
                labelResetRuntime.Text = selectedPlayer.Lastplay.ToString();
                labelResetPetName.Text = selectedPlayer.ChoosenPet.Name;
                pictureBoxResetPet.Image = selectedPlayer.ChoosenPet.Picture;
                listBoxResetStat.Items.AddRange(selectedPlayer.ChoosenPet.ToString().Split('\n'));
            }
        }


        #endregion

        private void buttonResetYes_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxResetPlayers.SelectedIndex != -1)
                {
                    Player resetPlayer = (Player)comboBoxResetPlayers.SelectedItem;
                    if (MessageBox.Show("Are you really sure?", "Resetting Player Data",
                        MessageBoxButtons.YesNo) == DialogResult.Yes) //Rencana mau buat captcha sendiri
                    {
                        listPlayers.Remove(resetPlayer);
                        comboBoxResetPlayers.SelectedIndex = -1;
                        labelResetRuntime.Text = "";
                        labelResetPetName.Text = "";
                        pictureBoxResetPet.Image = null;
                        listBoxResetStat.Items.Clear();
                        SerializeListPlayers();
                    }
                    else
                    {
                        MessageBox.Show("Reset player data is cancelled");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
