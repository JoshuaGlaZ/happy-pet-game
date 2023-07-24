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
        public BindingList<Player> listPlayers = new BindingList<Player>();

        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            ButtonResetGameState();
            DeserializeListPlayers();
            labelStart.Text = "Happy Pet";
            panelButton.Width = panelMain.Width;
            panelNewPlayer.Width = panelLoadPlayer.Width = panelReset.Width = 0;
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
            if (File.Exists("playerData.dat") && listPlayers.Count > 0)
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
            panelButton.Width = panelLoadPlayer.Width = panelReset.Width = 0;
            panelNewPlayer.Width = panelMain.Width;
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
                pictureBoxNewChoosePet.Image = Properties.Resources.cat_idle;
                pictureBoxNewChoosePet.BackgroundImage = null;
            }
            else if (radioButtonChooseFish.Checked)
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.fish_idle;
                pictureBoxNewChoosePet.BackgroundImage = Properties.Resources.fishbowl_clean;
            }
            else
            {
                pictureBoxNewChoosePet.Image = Properties.Resources.chameleon_green_idle;
                pictureBoxNewChoosePet.BackgroundImage = null;
            }
        }
        private void DisplayTraitStat()
        {
            listBoxNewStat.Items.Clear();
            if (radioButtonStrength.Checked) { listBoxNewStat.Items.Add("Strength Stat : "); }
            else if (radioButtonHealth.Checked) { listBoxNewStat.Items.Add("Health Stat : "); }
            else if (radioButtonEndurance.Checked) { listBoxNewStat.Items.Add("Endurance Stat : "); }
            else { listBoxNewStat.Items.Add("Willpower Stat : "); }
            if (radioButtonChooseCat.Checked)
            {
                listBoxNewStat.Items.Add("CAT");
                // original cat: health=1250 M.happiness=60 Energy=150 Defense=100
                if (radioButtonStrength.Checked) { listBoxNewStat.Items.AddRange("Health:1150\nMaxHappiness:60\nEnergy:200\nDefense:75\n".Split('\n')); }
                else if (radioButtonEndurance.Checked) { listBoxNewStat.Items.AddRange("Health:1150\nMaxHappiness:60\nEnergy:125\nDefense:150\n".Split('\n')); }
                else if (radioButtonWillpower.Checked) { listBoxNewStat.Items.AddRange("Health:1050\nMaxHappiness:50\nEnergy:175\nDefense:125\n".Split('\n')); }
                else if (radioButtonHealth.Checked) { listBoxNewStat.Items.AddRange("Health:1450\nMaxHappiness:70\nEnergy:125\nDefense:100\n".Split('\n')); }
            }//kurang variabel stat
            else if (radioButtonChooseFish.Checked)
            {
                listBoxNewStat.Items.Add("FISH");
                // original fish: health=1500 M.Happiness=80 Energy=100 Defense=125
                if (radioButtonStrength.Checked) { listBoxNewStat.Items.AddRange("Health:1400\nMaxHappiness:80\nEnergy:150\nDefense:100\n".Split('\n')); }
                else if (radioButtonEndurance.Checked) { listBoxNewStat.Items.AddRange("Health:1400\nMaxHappiness:80\nEnergy:75\nDefense:175\n".Split('\n')); }
                else if (radioButtonWillpower.Checked) { listBoxNewStat.Items.AddRange("Health:1300\nMaxHappiness:70\nEnergy:100\nDefense:150\n".Split('\n')); }
                else if (radioButtonHealth.Checked) { listBoxNewStat.Items.AddRange("Health:1700\nMaxHappiness:90\nEnergy:75\nDefense:125\n".Split('\n')); }
            }
            else if (radioButtonChooseChamaleon.Checked)
            {
                listBoxNewStat.Items.Add("CHAMELEON");
                // original chameleon: health=1250 M.Happiness=60 Energy=125 Defense=125
                if (radioButtonStrength.Checked) { listBoxNewStat.Items.AddRange("Health:1150\nMaxHappiness:60\nEnergy:175\nDefense:100\n".Split('\n')); }
                else if (radioButtonEndurance.Checked) { listBoxNewStat.Items.AddRange("Health:1150\nMaxHappiness:60\nEnergy:100\nDefense:175\n".Split('\n')); }
                else if (radioButtonWillpower.Checked) { listBoxNewStat.Items.AddRange("Health:1050\nMaxHappiness:50\nEnergy:150\nDefense:150\n".Split('\n')); }
                else if (radioButtonHealth.Checked) { listBoxNewStat.Items.AddRange("Health:1450\nMaxHappiness:70\nEnergy:100\nDefense:125\n".Split('\n')); }
            }
        }

        #region radio button change
        private void radioButtonChooseCat_CheckedChanged(object sender, EventArgs e)
        { ChangePictureBoxChoosePet();DisplayTraitStat(); }

        private void radioButtonChooseFish_CheckedChanged(object sender, EventArgs e)
        { ChangePictureBoxChoosePet(); DisplayTraitStat(); }

        private void radioButtonChooseChamaleon_CheckedChanged(object sender, EventArgs e)
        { ChangePictureBoxChoosePet(); DisplayTraitStat(); }

        private void radioButtonStrength_CheckedChanged(object sender, EventArgs e)
        {   DisplayTraitStat(); }

        private void radioButtonHealth_CheckedChanged(object sender, EventArgs e)
        {   DisplayTraitStat(); }

        private void radioButtonEndurance_CheckedChanged(object sender, EventArgs e)
        {   DisplayTraitStat(); }

        private void radioButtonWillpower_CheckedChanged(object sender, EventArgs e)
        {   DisplayTraitStat(); }
        #endregion

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
                if (radioButtonChooseCat.Checked) 
                {
                    Image inIdle = Properties.Resources.cat_idle;
                    Image inHurt = Properties.Resources.cat_hurt;
                    Image inDeath = Properties.Resources.cat_death;
                    Image inBasic = Properties.Resources.cat_basicAttack;
                    Image inSkill = Properties.Resources.cat_skill;
                    Image inUlti = Properties.Resources.cat_ult;
                    // original cat: health=1250 M.happiness=60 Energy=150 Defense=100
                    if (radioButtonStrength.Checked) { newPlayer.AddPetCat(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1150, 60, 200, 75); }
                    else if (radioButtonEndurance.Checked) { newPlayer.AddPetCat(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1150, 60, 125, 150); }
                    else if (radioButtonWillpower.Checked) { newPlayer.AddPetCat(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1050, 50, 175, 125); }
                    else if (radioButtonHealth.Checked) { newPlayer.AddPetCat(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1450, 70, 125, 100); }
                }//kurang variabel stat
                else if (radioButtonChooseFish.Checked)
                {
                    Image inIdle = Properties.Resources.fish_idle;
                    Image inHurt = Properties.Resources.fish_hurt;
                    Image inDeath = Properties.Resources.fish_death;
                    Image inBasic = Properties.Resources.fish_basicAttack;
                    Image inSkill = Properties.Resources.fish_skill;
                    Image inUlti = Properties.Resources.fish_ult;
                    // original fish: health=1500 M.Happiness=80 Energy=100 Defense=125
                    if (radioButtonStrength.Checked) { newPlayer.AddPetFish(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1400, 80, 150, 100); }
                    else if (radioButtonEndurance.Checked) { newPlayer.AddPetFish(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1400, 80, 75, 175); }
                    else if (radioButtonWillpower.Checked) { newPlayer.AddPetFish(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1300, 70, 125, 150); }
                    else if (radioButtonHealth.Checked) { newPlayer.AddPetFish(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1700, 90, 75, 125); }
                }
                else if (radioButtonChooseChamaleon.Checked)
                {
                    Image inIdle = Properties.Resources.chameleon_green_idle;
                    Image inHurt = Properties.Resources.chameleon_green_hurt;
                    Image inDeath = Properties.Resources.chameleon_green_death;
                    Image inBasic = Properties.Resources.chameleon_green_basicAttack;
                    Image inSkill = Properties.Resources.chameleon_green_blue;
                    Image inUlti = Properties.Resources.chameleon_ult;
                    // original chameleon: health=1250 M.Happiness=60 Energy=125 Defense=125
                    if (radioButtonStrength.Checked) { newPlayer.AddPetChamaleon(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1150, 60, 175, 100); }
                    else if (radioButtonEndurance.Checked) { newPlayer.AddPetChamaleon(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1150, 60, 100, 175); }
                    else if (radioButtonWillpower.Checked) { newPlayer.AddPetChamaleon(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1050, 50, 150, 150); }
                    else if (radioButtonHealth.Checked) { newPlayer.AddPetChamaleon(petName, petTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, 1450, 70, 100, 125); }
                }
                else { throw new Exception("Please select your pet"); }

                listPlayers.Add(newPlayer);
                listBoxNewStat.Items.AddRange(newPlayer.DisplayPetStat().Split('\n'));
                SerializeListPlayers();

                FormBattle battle = new FormBattle();
                battle.activePlayer = newPlayer;
                battle.Owner = this;
                battle.ShowDialog(this);
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
                pictureBoxLoadPet.Image = selectedPlayer.ChoosenPet.Idle;
                listBoxLoadProgress.Items.Add("Last Played = " + selectedPlayer.Lastplay.ToString());
                listBoxLoadStat.Items.AddRange(selectedPlayer.ChoosenPet.DisplayData().Split('\n'));
            }

        }
        private void buttonLoadReady_Click(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)comboBoxLoadPlayers.SelectedItem;
            FormBattle battle = new FormBattle();
            battle.activePlayer = selectedPlayer;
            battle.Owner = this;
            battle.ShowDialog(this);
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
                pictureBoxResetPet.Image = selectedPlayer.ChoosenPet.Idle;
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

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fileStream = new FileStream("playerData.dat",FileMode.Create,FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream,listPlayers);
            fileStream.Close();
        }
    }
}
