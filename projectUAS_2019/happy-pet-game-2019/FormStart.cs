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
using System.Timers;
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

        #region PanelButton

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
            panelButton.Width = panelLoadPlayer.Width = panelReset.Width = 0;
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
            panelButton.Width = panelNewPlayer.Width = panelReset.Width = 0;
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
            panelButton.Width = panelNewPlayer.Width = panelLoadPlayer.Width = 0;
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
                pictureBoxNewChoosePet.BackgroundImage = null;
                buttonChooseColor.Enabled = false;
                buttonChooseColor.Visible = false;
            }
            else if (radioButtonChooseFish.Checked)
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.fish;
                pictureBoxNewChoosePet.BackgroundImage = Properties.Resources.fishbowl_clean;
                buttonChooseColor.Enabled = false;
                buttonChooseColor.Visible = false;
            }
            else
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.chameleon_green;
                pictureBoxNewChoosePet.BackgroundImage = null;
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
            panelButton.Width = panelMain.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            ButtonResetGameState();
        }

        private void buttonNewBack_MouseEnter(object sender, EventArgs e)
        {   buttonNewBack.BackgroundImage = Properties.Resources.buttonback_pressed; }

        private void buttonNewBack_MouseLeave(object sender, EventArgs e)
        {   buttonNewBack.BackgroundImage = Properties.Resources.buttonback; }

        // Method dibawah dipakai untuk mengubah gambar, tag gambar, dan radioButton dengan aman 
        // Karena memastikan semuanya memakai thread memory yang sama (Timer membuat thread baru yang bekerja
        // di background).

        private void SetChameleonImage(Image image)
        {
            if (pictureBoxChameleonNewColor.InvokeRequired)
            {
                pictureBoxChameleonNewColor.Invoke((MethodInvoker)(() => SetChameleonImage(image)));
            }
            else
            {
                pictureBoxChameleonNewColor.Image = image;
            }
        }

        private void SetChameleonTag(string tag)
        {
            if (pictureBoxChameleonNewColor.InvokeRequired)
            {
                pictureBoxChameleonNewColor.Invoke((MethodInvoker)(() => SetChameleonTag(tag)));
            }
            else
            {
                pictureBoxChameleonNewColor.Tag = tag;
            }
        }

        private void EnableAllRadioButtons(bool enable)
        {
            if (radioButtonBlue.InvokeRequired || radioButtonGreen.InvokeRequired || radioButtonRed.InvokeRequired || radioButtonYellow.InvokeRequired)
            {
                radioButtonBlue.Invoke(new Action<bool>(EnableAllRadioButtons), enable);
                radioButtonGreen.Invoke(new Action<bool>(EnableAllRadioButtons), enable);
                radioButtonRed.Invoke(new Action<bool>(EnableAllRadioButtons), enable);
                radioButtonYellow.Invoke(new Action<bool>(EnableAllRadioButtons), enable);
            }
            else
            {
                radioButtonBlue.Enabled = enable;
                radioButtonGreen.Enabled = enable;
                radioButtonRed.Enabled = enable;
                radioButtonYellow.Enabled = enable;
            }
        }
        private void ChangeColorBlue(object sender, ElapsedEventArgs e)
        {
            SetChameleonImage(Properties.Resources.chameleon_blue);
            SetChameleonTag("blue");
            EnableAllRadioButtons(true);
        }

        private void ChangeColorGreen(object sender, ElapsedEventArgs e)
        {
            SetChameleonImage(Properties.Resources.chameleon_green);
            SetChameleonTag("green");
            EnableAllRadioButtons(true);
        }

        private void ChangeColorRed(object sender, ElapsedEventArgs e)
        {
            SetChameleonImage(Properties.Resources.chameleon_red);
            SetChameleonTag("red");
            EnableAllRadioButtons(true);
        }

        private void ChangeColorYellow(object sender, ElapsedEventArgs e)
        {
            SetChameleonImage(Properties.Resources.chameleon_yellow);
            SetChameleonTag("yellow");
            EnableAllRadioButtons(true);
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlue.Checked)
            {
                System.Timers.Timer timerChangeColorBlue;
                timerChangeColorBlue = new System.Timers.Timer(1200);
                timerChangeColorBlue.AutoReset = false;
                timerChangeColorBlue.Elapsed += ChangeColorBlue;
                if ((string)pictureBoxChameleonNewColor.Tag == "green")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_green_blue;
                }
                else if ((string)pictureBoxChameleonNewColor.Tag == "red")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_red_blue;

                }
                else if ((string)pictureBoxChameleonNewColor.Tag == "yellow")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_yellow_blue;
                }
                EnableAllRadioButtons(false);
                timerChangeColorBlue.Start();
            }
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreen.Checked)
            {
                System.Timers.Timer timerChangeColorGreen;
                timerChangeColorGreen = new System.Timers.Timer(1200);
                timerChangeColorGreen.AutoReset = false;
                timerChangeColorGreen.Elapsed += ChangeColorGreen;
                timerChangeColorGreen.Start();
                if ((string)pictureBoxChameleonNewColor.Tag == "blue")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_blue_green;

                }
                else if ((string)pictureBoxChameleonNewColor.Tag == "red")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_red_green;

                }
                else if ((string)pictureBoxChameleonNewColor.Tag == "yellow")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_yellow_green;
                }
                EnableAllRadioButtons(false);
                timerChangeColorGreen.Start();
            }
        }
        
        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked)
            {
                System.Timers.Timer timerChangeColorRed;
                timerChangeColorRed = new System.Timers.Timer(1200);
                timerChangeColorRed.AutoReset = false;
                timerChangeColorRed.Elapsed += ChangeColorRed;
                timerChangeColorRed.Start();
                if ((string)pictureBoxChameleonNewColor.Tag == "blue")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_blue_red;

                }
                else if ((string)pictureBoxChameleonNewColor.Tag == "green")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_green_red;

                }
                else if ((string)pictureBoxChameleonNewColor.Tag == "yellow")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_yellow_red;
                }
                EnableAllRadioButtons(false);
                timerChangeColorRed.Start();
            }
        }

        private void radioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYellow.Checked)
            {
                System.Timers.Timer timerChangeColorYellow;
                timerChangeColorYellow = new System.Timers.Timer(1200);
                timerChangeColorYellow.AutoReset = false;
                timerChangeColorYellow.Start();
                timerChangeColorYellow.Elapsed += ChangeColorYellow;
                if ((string)pictureBoxChameleonNewColor.Tag == "blue")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_blue_yellow;
                }
                else if ((string)pictureBoxChameleonNewColor.Tag == "red")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_red_yellow;

                }
                else if ((string)pictureBoxChameleonNewColor.Tag == "green")
                {
                    pictureBoxChameleonNewColor.Image = Properties.Resources.chameleon_green_yellow;
                }
                EnableAllRadioButtons(false);
                timerChangeColorYellow.Start();
            }
        }

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
            listBoxLoadProgress.Items.Clear();
            if (comboBoxLoadPlayers.SelectedIndex != -1)
            {
                Player selectedPlayer = (Player)comboBoxLoadPlayers.SelectedItem;
                labelLoadPetName.Text = selectedPlayer.ChoosenPet.Name;
                labelLoadPetLevel.Text = "Lvl = "+ selectedPlayer.ChoosenPet.Level.ToString();
                pictureBoxLoadPet.Image = selectedPlayer.ChoosenPet.Picture;
                listBoxLoadProgress.Items.Add("Last Played = " + selectedPlayer.Lastplay.ToString());
                listBoxLoadStat.Items.AddRange(selectedPlayer.ChoosenPet.ToString().Split('\n'));
            }
        }

        private void LoadPanelState()
        {
            if (comboBoxLoadPlayers.SelectedIndex == -1)
            {
                pictureBoxLoadBorder.Visible = false;
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
            panelLoadPlayer.Width = panelButton.Width = panelReset.Width = 0;
        }

        private void buttonLoadBack_Click(object sender, EventArgs e)
        {
            labelStart.Text = "Happy Pet";
            panelButton.Width = panelMain.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            ButtonResetGameState(); 
            labelLoadPetName.Text = "";
            labelLoadPetLevel.Text = "";
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
                labelResetPetLevel.Visible = false;
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
                labelResetPetLevel.Visible = true;
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
            panelButton.Width = panelMain.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            ButtonResetGameState();
            labelResetRuntime.Text = "";
            labelResetPetLevel.Text = "";
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
                labelResetPetLevel.Text = "Lvl = " + selectedPlayer.ChoosenPet.Level.ToString();
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
