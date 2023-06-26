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
        int statusTimer;
        Player owner = new Player("player",DateTime.Now);
        Image image;
        Pet pet;
        Enemy enemy;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerBattle_Tick(object sender, EventArgs e)
        {
            timer += 1;
            if(pet.Health <= 0) { listBox1.Items.Add("Game Over"); timerBattle.Stop(); }
            if(enemy.Health <= 0 ) { listBox1.Items.Add("you win"); timerBattle.Stop(); }
            if (timer % (int)(((1 / pet.AtkSpeed) * 100)) == 0) 
            {
                pet.basicAttack(enemy);
                listBox1.Items.Add("pet attack enemy"+enemy.Health+"/"+pet.Happiness);
            }
            if (timer % (int)((1 / enemy.AtkSpeed) * 100) == 0)
            {
                enemy.attack(pet);
                listBox1.Items.Add("enemy attack pet"+pet.Health);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerBattle.Start();
            pet = new Cat("kochenk", image, owner, 100, 100, 5);
            enemy = new EnemyDebuffer("debuffer", image, 100, 5, 1, 1);
            listBox1.Items.AddRange(pet.DisplayData().Split('\n'));
            listBox1.Items.Add("");
            listBox1.Items.AddRange((enemy.DisplayData()).Split('\n'));
            listBox1.Items.Add("");
            timer = 0;
        }

        private void buttonSpeedUp_Click(object sender, EventArgs e)
        {
            timerBattle.Interval = 1;
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
    }
}
