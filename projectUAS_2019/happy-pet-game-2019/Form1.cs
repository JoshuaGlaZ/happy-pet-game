using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace happy_pet_game_2019
{
    public partial class Form1 : Form
    {
        int timer; // timer battlenya
        int countdown; // buat ngitung berapa battle lagi untuk ke ruang istirahat
        Player owner = new Player("player",DateTime.Now);
        Image image;
        Pet pet;
        Enemy enemy,enemy1,enemy2;
        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            countdown = 3;
            labelBattleNumber.Text = "Battle before rest : " + countdown;
            timerBattle.Start();
            groupBoxChooseEnemy.Enabled = false;
            groupBoxPetAction.Enabled = false;
            pet = new Cat("kochenk", image, owner, 1250, 100, 150, 100);
            enemy = RandomEnemy();
            labelSkillPoint.Text = "Skill point remaining : " + pet.SkillPoin;
            listBox1.Items.AddRange((pet.DisplayData() + "'\n").Split('\n'));
            listBox1.Items.AddRange((enemy.DisplayData() + "\n").Split('\n'));
            timer = 0;
        }

        private void timerBattle_Tick(object sender, EventArgs e)
        {
            timer += 1;

            #region battle
            //bagian mekanik pet attack
            if (timer % (int)(((1 / pet.AtkSpeed) * 100)) == 0)
            {
                #region status musuh
                if (enemy is EnemyPoisonous && enemy.StatusBerjalan > 0)
                {
                    pet.Health -= enemy.getPoisonEffect();
                    if (pet.Health <= 0) 
                    { listBox1.Items.AddRange("\nGame Over\n".Split('\n')); timerBattle.Stop(); groupBoxPetAction.Enabled = false; }
                    enemy.StatusBerjalan -= 1;
                    listBox1.Items.Add("got poison damage "+enemy.getPoisonEffect());
                    if (enemy.StatusBerjalan == 0)
                    {
                        listBox1.Items.Add("Poison Effect removed");
                    }
                }
                if (enemy is EnemyDebuffer)
                {
                    if (enemy.StatusBerjalan > 0)
                    {
                        enemy.StatusBerjalan -= 1;
                        if (enemy.StatusBerjalan == 0)
                        {
                            listBox1.Items.Add("Debuff removed");
                            pet.Energy += enemy.getDebuffEffect();
                        }
                    }
                }
                #endregion

                #region status pet
                if (pet.StatusDuration == 0 && pet.BuffStatus) { pet.buffRemover(); listBox1.Items.Add("pet buff removed"); }
                else { pet.StatusDuration -= 1; }
                #endregion

                timerBattle.Stop();
                groupBoxPetAction.Enabled = true;
            }

            //bagian mekanik enemy attack
            if (timer % (int)((1 / enemy.AtkSpeed) * 100) == 0 && enemy.Health > 0)
            {
                if (enemy.Rage == enemy.MaxRage)
                {
                    enemy.specialAttack(pet);
                    Door1.Items.Clear();
                    Door1.Items.AddRange(("pet status\n" + pet.DisplayData()).Split('\n'));
                    Door2.Items.Clear();
                    Door2.Items.AddRange(("enemy status\n" + enemy.DisplayData()).Split('\n'));
                    listBox1.Items.Add("enemy unleash special attack dealing "+(enemy.Energy)+" damage");
                }
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
                }
            }
            #endregion

            #region battle result
            if (pet.Health <= 0) { listBox1.Items.AddRange("\nGame Over\n".Split('\n')); timerBattle.Stop(); groupBoxPetAction.Enabled = false; }
            else if (enemy.Health <= 0) // ada bug saat enemy dikalahkan sebelum debuffnya terhapus akan mempengaruhi stat pet sampai kedepannya
            {
                groupBoxPetAction.Enabled = false;
                listBox1.Items.AddRange("\nyou win\n".Split('\n'));
                int CoinsReward = (int)((1 + ((double)(enemy.Level-pet.Level)/10))*((enemy.MaxHealth+enemy.Energy))/10);
                int ExpReward = (int)(CoinsReward / 2);
                listBox1.Items.Add("Coins Reward : " + CoinsReward);
                listBox1.Items.Add("Exp Reward   : " + ExpReward);
                pet.Owner.Coins += CoinsReward;
                pet.ExpProgress += ExpReward;
                if (pet.ExpProgress >= pet.ExpBar)
                {
                    pet.levelUp(ExpReward);
                    listBox1.Items.AddRange("\nyour pet is leveled up\n".Split('\n'));
                    listBox1.Items.AddRange(pet.DisplayData().Split('\n'));
                }
                timerBattle.Stop();
                countdown -= 1;
                labelBattleNumber.Text = "Battle before rest : " + countdown;
                if (countdown == 0) { MessageBox.Show("Do you want to go to the shop ?","to the shop",MessageBoxButtons.YesNo); }
                groupBoxChooseEnemy.Enabled = true;
                Door1.Items.Clear();
                Door2.Items.Clear();
                enemy1 = RandomEnemy();
                enemy2 = RandomEnemy();
                Door1.Items.AddRange(enemy1.DisplayData().Split('\n'));
                Door2.Items.AddRange(enemy2.DisplayData().Split('\n'));
                radioButtonDoor1.Checked = true;
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
        }

        #region method
        Enemy newEnemy;
        int tipe, enemyLevel;
        private Enemy RandomEnemy()
        {
            Random random = new Random();
            tipe = random.Next(1, 4);
            enemyLevel = random.Next(pet.Level-4,pet.Level+4);
            if (enemyLevel < 1) { enemyLevel = 1; } // mencegah level enemy minus

            if (tipe == 1) 
            { 
                newEnemy = new EnemyDebuffer("debuffer",image,(int)(1200*(Math.Pow(1.1,enemyLevel-1))),
                    (int)(140 * (Math.Pow(1.1, enemyLevel-1))), 1, 60, (int)((50 * (Math.Pow(1.1, (enemyLevel-1) / 10)))), enemyLevel);
            }// tipe debuffer
            else if (tipe == 2)
            { 
                newEnemy = new EnemyDrain("drain", image, (int)(1200 * (Math.Pow(1.1, enemyLevel-1)))
                    , (int)(150 * (Math.Pow(1.1, enemyLevel-1))), 1, 50, (int)((30 * (Math.Pow(1.1, (enemyLevel-1) / 10)))), enemyLevel);
            }// tipe drain
            else if(tipe==3)
            { 
                newEnemy = new EnemyPoisonous("poisonous", image, (int)(1000 * (Math.Pow(1.1, enemyLevel-1)))
                    , (int)(130 * (Math.Pow(1.1, enemyLevel-1))), 1, 50, (int)((50 * (Math.Pow(1.1, (enemyLevel-1) / 10)))),enemyLevel);
            } // tipe poisonous
            else
            {
                newEnemy = new EnemyPhysical("physical", image, (int)(1500 * (Math.Pow(1.1, enemyLevel - 1)))
                    , (int)(160 * (Math.Pow(1.1, enemyLevel - 1))), 1, 50, enemyLevel);
            } // tipe physical

            return newEnemy;
        } // masih nggak bisa bikin 2 musuh berbeda di door 1 dan door 2
        #endregion
    }
}
