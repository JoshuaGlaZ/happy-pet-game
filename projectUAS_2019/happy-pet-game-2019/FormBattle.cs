using System;
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
    public partial class FormBattle : Form
    {
        FormStart start;
        int timer=0; // timer battlenya
        int countdown; // buat ngitung berapa battle lagi untuk ke ruang istirahat
        Enemy enemy,enemy1,enemy2;
        public Player activePlayer;
        Pet pet;
        public FormBattle() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            start = (FormStart)this.Owner;
            pet = activePlayer.ChoosenPet;
            countdown = 3;
            labelBattleNumber.Text = "Battle before rest : " + countdown;
            labelLevelPoint.Text = "level point : " + 0;
            labelSkillPoint.Text = "Skill point remaining : " + pet.SkillPoin;
            labelBuff.Text = "Buff Duration : " + 0;
            labelDebuff.Text = "Debuff Duration : " + 0;

            /*
            if (File.Exists("progress.vc"))
            {
                DialogResult load = MessageBox.Show("Do you want to load last progress ?", "progress load", MessageBoxButtons.YesNo);
                if (load == DialogResult.Yes)
                {
                    FileStream fileStream = new FileStream("progress.vc", FileMode.Open, FileAccess.Read);

                    BinaryFormatter bf = new BinaryFormatter();
                    pet = bf.Deserialize(fileStream) as Pet;
                    owner = bf.Deserialize(fileStream) as Player;

                    fileStream.Close();

                    groupBoxChoosePet.Enabled = false;
                    groupBoxBattle.Enabled = true;
                }
            }
            */
        }

        private void timerBattle_Tick(object sender, EventArgs e)
        {
            timer += 1;

            #region battle
            //bagian mekanik pet attack
            if (timer % (int)(((1 / pet.AtkSpeed) * 100)) == 0)
            {
                #region status musuh
                if (enemy.StatusDuration > 0)
                {
                    enemy.StatusDuration -= 1;
                    if (enemy is EnemyPoisonous)
                    {
                        pet.Health -= enemy.getPoisonEffect();
                        if (pet.Health <= 0)
                        { listBox1.Items.AddRange("\nGame Over\n".Split('\n')); timerBattle.Stop(); groupBoxPetAction.Enabled = false; }
                        listBox1.Items.Add("got poison damage " + enemy.getPoisonEffect());
                        if (enemy.StatusDuration == 0)
                        {
                            listBox1.Items.Add("Poison Effect removed");
                        }
                    }
                    if (enemy is EnemyDebuffer)
                    {
                        if (enemy.StatusDuration == 0)
                        {
                            listBox1.Items.Add("Debuff removed");
                            pet.Energy += enemy.getDebuffEffect();
                        }
                    }
                }
                #endregion

                #region status pet
                if(pet.StatusDuration>0)
                { 
                    pet.StatusDuration -= 1;
                    if (pet.StatusDuration == 0) { pet.buffRemover(enemy); }
                }
                #endregion

                labelBuff.Text = "Buff Duration : " + pet.StatusDuration;
                labelDebuff.Text = "Debuff Duration : " + enemy.StatusDuration;

                timerBattle.Stop();
                groupBoxPetAction.Enabled = true;
            }

            //bagian mekanik enemy attack
            if (timer % (int)((1 / enemy.AtkSpeed) * 100) == 0 && enemy.Health > 0)
            {
                if (enemy.Rage == enemy.MaxRage)
                {
                    if(pet.GetEnviromentStatus() == "Clean")
                    {
                        enemy.specialAttack(pet);
                        Door1.Items.Clear();
                        Door1.Items.AddRange(("pet status\n" + pet.DisplayData()).Split('\n'));
                        Door2.Items.Clear();
                        Door2.Items.AddRange(("enemy status\n" + enemy.DisplayData()).Split('\n'));
                        listBox1.Items.Add("enemy unleash special attack dealing " + (enemy.Energy) + " damage");
                        listBox1.Items.Add("immunity to debuff");
                        enemy.StatusDuration = 0;
                    }
                    else
                    {
                        enemy.specialAttack(pet);
                        Door1.Items.Clear();
                        Door1.Items.AddRange(("pet status\n" + pet.DisplayData()).Split('\n'));
                        Door2.Items.Clear();
                        Door2.Items.AddRange(("enemy status\n" + enemy.DisplayData()).Split('\n'));
                        listBox1.Items.Add("enemy unleash special attack dealing " + (enemy.Energy) + " damage");
                    }
                } // skill musuh
                else
                {
                    enemy.attack(pet);
                    Door1.Items.Clear();
                    Door1.Items.AddRange(("pet status\n" + pet.DisplayData()).Split('\n'));
                    Door2.Items.Clear();
                    Door2.Items.AddRange(("enemy status\n" + enemy.DisplayData()).Split('\n'));
                    int damage = 0;
                    if (enemy.Energy > pet.Defense) { damage += (enemy.Energy - pet.Defense); }
                    listBox1.Items.Add("enemy attack pet dealing " + damage + " damage");
                } // normal attack musuh
            }
            #endregion

            #region battle result
            if (pet.Health <= 0) { listBox1.Items.AddRange("\nGame Over\n".Split('\n')); timerBattle.Stop(); groupBoxPetAction.Enabled = false; }
            else if (enemy.Health <= 0)
            {
                // buat ngilangin efek2 setelah battle
                if (enemy.StatusDuration > 0)
                {
                    enemy.StatusDuration = 0;
                    if (enemy is EnemyPoisonous)
                    {
                        listBox1.Items.Add("Poison Effect removed");
                    }
                    if (enemy is EnemyDebuffer)
                    {
                        listBox1.Items.Add("Debuff removed");
                    }
                }
                if (pet.StatusDuration > 0)
                {
                    pet.StatusDuration = 0;
                    pet.buffRemover(enemy); 
                }

                groupBoxPetAction.Enabled = false;
                listBox1.Items.AddRange("\nyou win\n".Split('\n'));
                int CoinsReward = (int)((1 + ((double)(enemy.Level-pet.Level)/10))*((enemy.MaxHealth+enemy.Energy))/10);
                int ExpReward = (int)(CoinsReward / 2);
                if(enemy is EnemyPhysical == false) { CoinsReward += CoinsReward/2; ExpReward += ExpReward/2; }
                listBox1.Items.Add("Coins Reward : " + CoinsReward);
                listBox1.Items.Add("Exp Reward   : " + ExpReward);
                activePlayer.Coins += CoinsReward;
                pet.ExpProgress += ExpReward;
                if (pet.ExpProgress >= pet.ExpBar)
                {
                    pet.levelUp();
                    labelLevelPoint.Text = "level point : " + pet.LevelPoin;
                    listBox1.Items.AddRange("\nyour pet is leveled up\n".Split('\n'));
                    listBox1.Items.AddRange(pet.DisplayData().Split('\n'));
                }
                timerBattle.Stop();
                countdown -= 1;
                pet.SkillPoin = 0;
                labelSkillPoint.Text = "skill poin remaining : " + 0;
                labelBattleNumber.Text = "Battle before rest : " + countdown;
                if (countdown == 0) 
                { 
                    groupBoxShop.Enabled = true;
                    groupBoxChooseEnemy.Enabled = false;
                    if(pet is Cat)
                    {
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                    }
                    else if (pet is Fish)
                    {
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                    }
                    else if (pet is Chamaleon)
                    {
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                    }
                    countdown = 5;
                } // ke shop
                else { groupBoxChooseEnemy.Enabled = true; }
                groupBoxLvUp.Enabled = true;
                radioButtonMaxHealth.Checked = true;
                Door1.Items.Clear();
                Door2.Items.Clear();
                enemy1 = RandomEnemy();
                enemy2 = RandomEnemy();
                Door1.Items.AddRange(enemy1.DisplayData().Split('\n'));
                Door2.Items.AddRange(enemy2.DisplayData().Split('\n'));
                radioButtonDoor1.Checked = true;
                timer = 0;
            }
            #endregion
        }

        #region pet action
        private void buttonBasicAttack_Click(object sender, EventArgs e)
        {
            pet.basicAttack(enemy);
            listBox1.Items.Add("pet using basic attack dealing "+pet.Energy+" damage");
            groupBoxPetAction.Enabled = false;
            labelSkillPoint.Text = "Skill point remaining : " + pet.SkillPoin;
            Door1.Items.Clear();
            Door1.Items.AddRange(("pet status\n" + pet.DisplayData()).Split('\n'));
            Door2.Items.Clear();
            Door2.Items.AddRange(("enemy status\n" + enemy.DisplayData()).Split('\n'));
            timerBattle.Start();
        } 
        private void buttonSkill_Click(object sender, EventArgs e)
        {
            try
            {
                pet.Skill(enemy);
                listBox1.Items.Add("pet using skill ");
                groupBoxPetAction.Enabled = false;
                labelSkillPoint.Text = "Skill point remaining : " + pet.SkillPoin;
                labelBuff.Text = "Buff Duration : " + pet.StatusDuration;
                Door1.Items.Clear();
                Door1.Items.AddRange(("pet status\n" + pet.DisplayData()).Split('\n'));
                Door2.Items.Clear();
                Door2.Items.AddRange(("enemy status\n" + enemy.DisplayData()).Split('\n'));
                timerBattle.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonUlti_Click(object sender, EventArgs e)
        {
            try
            {
                pet.Ultimate(enemy);
                listBox1.Items.Add("Ultimate unleashed dealing "+pet.Energy*4+" damage");
                groupBoxPetAction.Enabled = false;
                Door1.Items.Clear();
                Door1.Items.AddRange(("pet status\n" + pet.DisplayData()).Split('\n'));
                Door2.Items.Clear();
                Door2.Items.AddRange(("enemy status\n" + enemy.DisplayData()).Split('\n'));
                timerBattle.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        private void buttonGo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButtonDoor1.Checked) { enemy = enemy1; timerBattle.Start(); }
            if (radioButtonDoor2.Checked) { enemy = enemy2; timerBattle.Start(); }
            groupBoxChooseEnemy.Enabled = false;
            groupBoxLvUp.Enabled = false;
            listBox1.Items.AddRange((enemy.DisplayData() + "\n").Split('\n'));
        }
        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonMaxHealth.Checked) { pet.MaxHealthUp(); }
                else if (radioButtonEnergy.Checked) { pet.EnergyUp(); }
                else if (radioButtonDefense.Checked) { pet.DefenseUp(); }
                else if (radioButtonHappinessGain.Checked) { pet.HappinessGainUp(); }
                else if (radioButtonAtkSpeed.Checked) { pet.AtkSpeedUp(); }
                labelLevelPoint.Text = "level point : " + pet.LevelPoin;
                listBoxLevelUp.Items.Clear();
                listBoxLevelUp.Items.AddRange(pet.DisplayData().Split('\n'));
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        #region shop
        #region shop cat
        private void buttonCatSleep_Click(object sender, EventArgs e)
        {
            if (activePlayer.Coins >= 200)
            {
                pet.Sleep();
                activePlayer.Coins -= 200;
                MessageBox.Show("+100% Health and +100% Happiness\n"+pet.DisplayData());
            }
            else { MessageBox.Show("not enough coins"); }
        }
        private void buttonCatBath_Click(object sender, EventArgs e)
        {
            if (activePlayer.Coins >= 150)
            {
                pet.Bath();
                activePlayer.Coins -= 150;
                MessageBox.Show("+100% Health\n" + pet.DisplayData());
            }
            else { MessageBox.Show("not enough coins"); }
        }
        private void buttonVaccinate_Click(object sender, EventArgs e)
        {
            try
            {
                if (activePlayer.Coins >= 500)
                {
                    pet.Vaccinate();
                    activePlayer.Coins -= 500;
                    MessageBox.Show("Cat Vaccinated \nGet new Passive Skill \nskill no longer consume Health & Ultimate gain healing effect\n" + pet.DisplayData());
                }
                else { MessageBox.Show("not enough coins"); }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonCatPlay_Click_1(object sender, EventArgs e)
        {
            if (activePlayer.Coins >= 100)
            {
                pet.Play();
                activePlayer.Coins -= 100;
                MessageBox.Show("+50% Happiness\n" + pet.DisplayData());
            }
            else { MessageBox.Show("not enough coins"); }
        }
        #endregion

        #region shop fish
        private void buttonFishClean_Click(object sender, EventArgs e)
        {
            if (activePlayer.Coins >= 100)
            {
                pet.SkillPoin += 3;
                pet.Skill(enemy);
                activePlayer.Coins -= 100;
                MessageBox.Show("enviroment status --> Clean (3 turn) \n Health +100% \n" + pet.DisplayData());
            }
            else { MessageBox.Show("not enough coins"); }
        }
        #endregion

        #region shop chameleon
        private void buttonChameleonSleep_Click(object sender, EventArgs e)
        {
            if (activePlayer.Coins >= 200)
            {
                pet.Sleep();
                activePlayer.Coins -= 200;
                MessageBox.Show("+100% Health and +100% Happiness\n" + pet.DisplayData());
            }
            else { MessageBox.Show("not enough coins"); }
        }
        private void buttonChageColor_Click(object sender, EventArgs e)
        {
            if (activePlayer.Coins >= 100)
            {
                pet.SkillPoin += 1;
                pet.Skill(enemy);
                owner.Coins -= 100;
                MessageBox.Show("get random buff when battle start (3 turn)\n" + pet.DisplayData());
            }
            else { MessageBox.Show("not enough coins"); }
        }
        #endregion

        private void buttonDoneShop_Click(object sender, EventArgs e)
        {
            groupBoxChooseEnemy.Enabled = true;
            groupBoxShop.Enabled = false;
        }
        #endregion

        #region save data
        private void FormBattle_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            DialogResult save =  MessageBox.Show("Do you want to save the progress ?", "progress save", MessageBoxButtons.YesNo);
            if(save == DialogResult.Yes)
            {
                FileStream fileStream = new FileStream("progress.vc",FileMode.Create,FileAccess.Write);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fileStream, pet);
                bf.Serialize(fileStream, Owner);

                fileStream.Close();
            }
            */
        }
        #endregion

        #region enemy generator
        Enemy newEnemy;
        int tipe, enemyLevel;
        Random random = new Random();
        private Enemy RandomEnemy()
        {
            tipe = random.Next(1, 5);
            enemyLevel = random.Next(pet.Level - 4, pet.Level + 4);
            if (enemyLevel < 1) { enemyLevel = 1; } // mencegah level enemy minus

            if (tipe == 1)
            {
                newEnemy = new EnemyDebuffer("debuffer", image, (int)(1200 * (Math.Pow(1.1, enemyLevel - 1))),
                    (int)(140 * (Math.Pow(1.1, enemyLevel - 1))), 1, (int)((50 * (Math.Pow(1.1, (enemyLevel - 1) / 10)))), 30, enemyLevel);
            }// tipe debuffer
            else if (tipe == 2)
            {
                newEnemy = new EnemyDrain("drain", image, (int)(1200 * (Math.Pow(1.1, enemyLevel - 1)))
                    , (int)(150 * (Math.Pow(1.1, enemyLevel - 1))), 1, (int)((50 * (Math.Pow(1.1, (enemyLevel - 1) / 10)))), 30, enemyLevel);
            }// tipe drain
            else if (tipe == 3)
            {
                newEnemy = new EnemyPoisonous("poisonous", image, (int)(1000 * (Math.Pow(1.1, enemyLevel - 1)))
                    , (int)(130 * (Math.Pow(1.1, enemyLevel - 1))), 1, (int)((50 * (Math.Pow(1.1, (enemyLevel - 1) / 10)))), 30, enemyLevel);
            } // tipe poisonous
            else
            {
                newEnemy = new EnemyPhysical("physical", image, (int)(1500 * (Math.Pow(1.1, enemyLevel - 1)))
                    , (int)(160 * (Math.Pow(1.1, enemyLevel - 1))), 1, 30, enemyLevel);
            } // tipe physical

            return newEnemy;
            #endregion
        }
    }
}
