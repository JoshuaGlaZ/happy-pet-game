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
        int timer;
        int countdown; // buat ngitung berapa battle lagi untuk ke ruang istirahat
        Player owner = new Player("player",DateTime.Now);
        Image image;
        Pet pet;
        Enemy enemy,enemy1,enemy2;
        public Form1() { InitializeComponent(); }

        private void timerBattle_Tick(object sender, EventArgs e)
        {
            timer += 1;

            #region battle
            if (timer % (int)(((1 / pet.AtkSpeed) * 100)) == 0)
            {
                pet.basicAttack(enemy);
                listBox1.Items.Add("pet attack enemy " + enemy.Health + " " + pet.Happiness + "/" + pet.MaxHappiness);
                if (enemy is EnemyPoisonous && enemy.StatusBerjalan > 0)
                {
                    pet.Health -= enemy.getPoisonEffect();
                    enemy.StatusBerjalan -= 1;
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
            }
            if (timer % (int)((1 / enemy.AtkSpeed) * 100) == 0 && enemy.Health > 0)
            {
                if (enemy.Rage == enemy.MaxRage)
                {
                    enemy.specialAttack(pet);
                    listBox1.Items.Add("enemy unleash special attack " + pet.Health + " " + pet.Energy);
                }
                else
                {
                    enemy.attack(pet);
                    listBox1.Items.Add("enemy attack pet " + pet.Health + " " + enemy.Rage + "/" + enemy.MaxRage);
                }
            }
            #endregion

            #region battle result
            if (pet.Health <= 0) { listBox1.Items.AddRange("\nGame Over\n".Split('\n')); timerBattle.Stop(); }
            else if (enemy.Health <= 0)
            {
                listBox1.Items.AddRange("\nyou win\n".Split('\n'));
                listBox1.Items.Add("Coins Reward : " + enemy.CoinsReward);
                listBox1.Items.Add("Exp Reward   : " + enemy.ExpReward);
                pet.Owner.Coins += enemy.CoinsReward;
                pet.ExpProgress += enemy.ExpReward;
                if (pet.ExpProgress >= pet.ExpBar)
                {
                    pet.levelUp(enemy.ExpReward);
                    listBox1.Items.AddRange("\nyour pet is leveled up\n".Split('\n'));
                    listBox1.Items.AddRange(pet.DisplayData().Split('\n'));
                }
                timerBattle.Stop();
                countdown -= 1;
                label1.Text = "Battle before rest : " + countdown;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            countdown = 3;
            timerBattle.Start();
            label1.Text = "Battle before rest : "+countdown;
            pet = new Cat("kochenk", image, owner, 100, 100, 100);
            enemy = new EnemyDebuffer("debuffer", image, 100, 10, 10, 100, 10);
            groupBoxChooseEnemy.Enabled = false;
            listBox1.Items.AddRange((pet.DisplayData()+"'\n").Split('\n'));
            listBox1.Items.AddRange((enemy.DisplayData()+"\n").Split('\n'));
            timer = 0;
        }

        private void buttonUlti_Click(object sender, EventArgs e)
        {
            try
            {
                pet.Ultimate(enemy);
                listBox1.Items.Add("Ultimate unleashed");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void checkBox2Xspeed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2Xspeed.Checked) { timerBattle.Interval = 1; }
            else { timerBattle.Interval = 2; }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButtonDoor1.Checked) { enemy = enemy1; timerBattle.Start(); }
            if (radioButtonDoor2.Checked) { enemy = enemy2; timerBattle.Start(); }
        }

        #region method
        private Enemy RandomEnemy()
        {
            Random random = new Random();
            Enemy enemy;
            int tipe = random.Next(1, 3);
            int health = random.Next(500, 1000);
            int energy = random.Next(50,200);
            int statusEffect = random.Next(10, 100);
            if (tipe == 1) { enemy = new EnemyDebuffer("debuffer",image,health,energy,1,50,statusEffect); }
            else if (tipe == 2) { enemy = new EnemyDrain("drain", image, health, energy, 1, 50, statusEffect); }
            else { enemy = new EnemyPoisonous("poisonous", image, health, energy, 1, 50, statusEffect); }
            return enemy;
        }
        #endregion
    }
}
