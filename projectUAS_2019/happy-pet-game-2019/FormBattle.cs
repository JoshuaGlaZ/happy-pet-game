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
using System.Timers;

namespace happy_pet_game_2019
{
    public partial class FormBattle : Form
    {
        #region variabel bantu
        FormStart start;
        int timer=0; // timer battlenya
        int countdown; // buat ngitung berapa battle lagi untuk ke shop
        Enemy enemy,enemy1,enemy2;
        public Player activePlayer;
        Pet pet;
        #endregion

        public FormBattle() { InitializeComponent(); }

        private void FormBattle_Load(object sender, EventArgs e)
        {
            start = (FormStart)this.Owner;
            pet = activePlayer.ChoosenPet;
            countdown = 5;
            labelBattleResult.Text = "";
            labelTurn.Text = "";
            labelBattleNumber.Text = "Battle before rest : " + countdown;
            labelLevelPoint.Text = "level point : " + 0;
            labelSkillPoint.Text = "Skill point remaining : " + pet.SkillPoin;
            labelBuff.Text = "Buff Duration : " + 0;
            labelDebuff.Text = "Debuff Duration : " + 0;
            pictureBoxPet.Image = pet.Idle;

            panelBattle.Width = 1500;
            panelAfterBattle.Width = 0;
            groupBoxPetAction.Enabled = false;

            enemy = RandomEnemy();
            pictureBoxEnemy.Image = enemy.Idle;
            timerBattle.Start();
        }

        System.Timers.Timer animation = new System.Timers.Timer(2000);
        private void timerBattle_Tick(object sender, EventArgs e)
        {
            timer += 1;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.AddRange(pet.DisplayData().Split('\n'));
            listBox2.Items.AddRange(enemy.DisplayData().Split('\n'));

            #region battle
            //bagian mekanik enemy attack
            if (timer % (int)((1 / enemy.AtkSpeed) * 100) == 0 && enemy.Health > 0)
            {
                //Idle();
                labelTurn.Text = "ENEMY";
                if (enemy.Rage == enemy.MaxRage) // special attack musuh
                {
                    enemy.specialAttack(pet);
                    // kasih pemberitahuan debuff

                    /*
                    animation = new System.Timers.Timer(1000);
                    animation.Elapsed += EnemyAttack;
                    animation.Start();

                    animation = new System.Timers.Timer(2000);
                    animation.Elapsed += PetHurt;
                    animation.Start();
                    */
                }
                else // normal attack musuh
                {
                    enemy.attack(pet);

                    /*
                    animation = new System.Timers.Timer(1000);
                    animation.Elapsed += EnemyAttack;
                    animation.Start();

                    animation = new System.Timers.Timer(2000);
                    animation.Elapsed += PetHurt;
                    animation.Start();
                    */
                }
                //Idle();
            }
            //bagian mekanik pet attack
            if (timer % (int)(((1 / pet.AtkSpeed) * 100)) == 0)
            {
                //Idle();
                labelTurn.Text = "PET";

                #region status musuh
                if (enemy.StatusDuration > 0)
                {
                    enemy.StatusDuration -= 1;
                    if (enemy is EnemyPoisonous)
                    {
                        pet.Health -= enemy.getPoisonEffect();
                        if (pet.Health <= 0)
                        {
                            timerBattle.Stop();
                            groupBoxPetAction.Enabled = false;
                            labelBattleResult.Text = "GAME OVER";
                            pictureBoxPet.Image = pet.Death;
                        }
                        if (enemy.StatusDuration == 0)
                        {
                            // masukan pemberitahuan efek poison removed
                        }
                    }
                    if (enemy is EnemyDebuffer)
                    {
                        if (enemy.StatusDuration == 0)
                        {
                            pet.Energy += enemy.getDebuffEffect();
                            // masukan pemberitahuan efek debuff removed
                        }
                    }
                }
                #endregion
                #region status pet
                if (pet.StatusDuration > 0)
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
            #endregion

            #region battle result
            if (pet.Health <= 0) 
            { 
                timerBattle.Stop(); 
                groupBoxPetAction.Enabled = false; 
                labelBattleResult.Text = "GAME OVER"; 
                pictureBoxPet.Image = pet.Death; 
            }
            else if (enemy.Health <= 0)
            {
                countdown -= 1;
                pet.SkillPoin = 0;
                labelSkillPoint.Text = "skill poin remaining : " + 0;
                labelBattleNumber.Text = "Battle before rest : " + countdown;
                labelBattleResult.Text = "WIN";
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox1.Items.AddRange(pet.DisplayData().Split('\n'));
                listBox2.Items.AddRange(enemy.DisplayData().Split('\n'));
                // buat ngilangin efek2 setelah battle
                if (enemy.StatusDuration > 0)
                {
                    enemy.StatusDuration = 0;
                    if (enemy is EnemyDebuffer)
                    {
                        pet.Energy += enemy.getDebuffEffect();
                    }
                }
                if (pet.StatusDuration > 0)
                {
                    pet.StatusDuration = 0;
                    pet.buffRemover(enemy); 
                }
                pictureBoxEnemy.Image = enemy.Death;
                // kasih delay

                #region panel after battle
                timerBattle.Stop();
                panelBattle.Width = 0;
                panelAfterBattle.Width = 1500;
                pictureBoxPetDisplay.Image = pet.Idle;
                int CoinsReward = (int)((1 + ((double)(enemy.Level-pet.Level)/10))*((enemy.MaxHealth+enemy.Energy))/10);
                int ExpReward = (int)(CoinsReward / 2);
                if(enemy is EnemyPhysical == false) { CoinsReward += CoinsReward/2; ExpReward += ExpReward/2; }
                labelCoinsReward.Text = "Coins Reward : " + CoinsReward;
                labelExpReward.Text = "Exp Reward : " + ExpReward;
                activePlayer.Coins += CoinsReward;
                pet.ExpProgress += ExpReward;
                if (pet.ExpProgress >= pet.ExpBar)
                {
                    pet.levelUp();
                    labelLevelPoint.Text = "level point : " + pet.LevelPoin;
                }
                listBoxLevelUp.Items.Clear();
                listBoxLevelUp.Items.AddRange(pet.DisplayData().Split('\n'));
                if (countdown == 0) 
                {
                    countdown = 5;
                    /*
                    FormShop shop = new FormShop();
                    shop.Owner = this;
                    shop.ShowDialog(this);
                    */
                }
                else { panelAfterBattle.Width = 1500; panelBattle.Width = 0; }
                radioButtonMaxHealth.Checked = true;
                radioButtonDoor1.Checked = true;
                Door1.Items.Clear();
                Door2.Items.Clear();
                enemy1 = RandomEnemy();
                enemy2 = RandomEnemy();
                Door1.Items.AddRange(enemy1.DisplayData().Split('\n'));
                Door2.Items.AddRange(enemy2.DisplayData().Split('\n'));
                timer = 0;
                #endregion
            }
            #endregion
        }

        #region pet action
        private void buttonBasicAttack_Click(object sender, EventArgs e)
        {
            pet.basicAttack(enemy);
            groupBoxPetAction.Enabled = false;
            labelSkillPoint.Text = "Skill point remaining : " + pet.SkillPoin;

            /*
            animation = new System.Timers.Timer(2000);
            animation.Elapsed += PetBasic;
            animation.Start();

            //Idle();
            animation = new System.Timers.Timer(1000);
            animation.Elapsed += EnemyHurt;
            animation.Start();
            */

            //Idle();
            timerBattle.Start();
            labelTurn.Text = "";
        } 
        private void buttonSkill_Click(object sender, EventArgs e)
        {
            try
            {
                pet.Skill(enemy);
                groupBoxPetAction.Enabled = false;
                labelSkillPoint.Text = "Skill point remaining : " + pet.SkillPoin;
                labelBuff.Text = "Buff Duration : " + pet.StatusDuration;

                /*
                animation = new System.Timers.Timer(1000);
                animation.Elapsed += PetSkill;
                animation.Start();
                */

                //Idle();
                timerBattle.Start();
                labelTurn.Text = "";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonUlti_Click(object sender, EventArgs e)
        {
            try
            {
                pet.Ultimate(enemy);
                groupBoxPetAction.Enabled = false;

                /*
                animation = new System.Timers.Timer(2000);
                animation.Elapsed += PetUlti;
                animation.Start();

                //Idle();
                animation = new System.Timers.Timer(1000);
                animation.Elapsed += EnemyHurt;
                animation.Start();
                */

                //Idle();
                timerBattle.Start();
                labelTurn.Text = "";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (radioButtonDoor1.Checked) { enemy = enemy1; timerBattle.Start(); }
            if (radioButtonDoor2.Checked) { enemy = enemy2; timerBattle.Start(); }
            panelAfterBattle.Width = 0;
            panelBattle.Width = 1500;
            labelBattleResult.Text = "";
            pictureBoxEnemy.Image = enemy.Idle;
        } // untuk mulai battle selanjutnya
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
        } // buat upgrade stat pet kalau naik level

        #region button exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackgroundImage = Properties.Resources.Exit_pressed;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackgroundImage = Properties.Resources.Exit_normal;
        }
        #endregion

        #region enemy generator
        Enemy newEnemy;
        int tipe, enemyLevel;
        Random random = new Random();
        private Enemy RandomEnemy()
        {
            tipe = random.Next(1, 4);
            enemyLevel = random.Next(pet.Level - 4, pet.Level + 4);
            if (enemyLevel < 1) { enemyLevel = 1; } // mencegah level enemy minus

            if (tipe == 1)
            {
                Image inIdle = Properties.Resources.spider_idle;
                Image inHurt = Properties.Resources.spider_hurt;
                Image inDeath = Properties.Resources.spider_death;
                Image inAttack =Properties.Resources.spider_attack;
                newEnemy = new EnemyDebuffer("debuffer", inIdle, inHurt, inDeath, inAttack, (int)(1200 * (Math.Pow(1.1, enemyLevel - 1))),
                    (int)(140 * (Math.Pow(1.1, enemyLevel - 1))), 1, 30, (int)((50 * (Math.Pow(1.1, (enemyLevel - 1) / 10)))), enemyLevel);
            }// tipe debuffer
            else if (tipe == 2)
            {
                Image inIdle = Properties.Resources.fly_idle;
                Image inHurt = Properties.Resources.fly_hurt;
                Image inDeath = Properties.Resources.fly_death;
                Image inAttack = Properties.Resources.fly_attack;
                newEnemy = new EnemyDrain("drain", inIdle, inHurt, inDeath, inAttack, (int)(1200 * (Math.Pow(1.1, enemyLevel - 1)))
                    , (int)(150 * (Math.Pow(1.1, enemyLevel - 1))), 1, (int)((50 * (Math.Pow(1.1, (enemyLevel - 1) / 10)))), 30, enemyLevel);
            }// tipe drain
            else if (tipe == 3)
            {
                Image inIdle = Properties.Resources.cat;
                Image inHurt = Properties.Resources.cat_hurt;
                Image inDeath = Properties.Resources.cat_death;
                Image inAttack = Properties.Resources.cat_basicAttack;
                newEnemy = new EnemyPoisonous("poisonous", inIdle, inHurt, inDeath, inAttack, (int)(1000 * (Math.Pow(1.1, enemyLevel - 1)))
                    , (int)(150 * (Math.Pow(1.1, enemyLevel - 1))), 1, (int)((100 * (Math.Pow(1.1, (enemyLevel - 1) / 10)))), 30, enemyLevel);
            } // tipe poisonous
            else
            {
                Image inIdle = Properties.Resources.cat;
                Image inHurt = Properties.Resources.cat_hurt;
                Image inDeath = Properties.Resources.cat_death;
                Image inAttack = Properties.Resources.cat_basicAttack;
                newEnemy = new EnemyPhysical("physical", inIdle, inHurt, inDeath, inAttack, (int)(1500 * (Math.Pow(1.1, enemyLevel - 1)))
                    , (int)(160 * (Math.Pow(1.1, enemyLevel - 1))), 1, 30, enemyLevel);
            } // tipe physical

            return newEnemy;
        }
        #endregion

        #region animation
        int durasiAttack;
        int durasiHitEnemy;
        int durasiHurt;
        System.Timers.Timer animationAttack;
        System.Timers.Timer animationHurt;
        System.Timers.Timer animationIdle;
        private void Attack_IdlePet(object sender, ElapsedEventArgs e) //attacknya pet
        { 
            pictureBoxPet.Image = Properties.Resources.cat_idle;
        }
        private void Attack_IdleEnemy(object sender, ElapsedEventArgs e) //attacknya enemy
        {
            pictureBoxEnemy.Image = Properties.Resources.cobra_idle;
        }
        private void HurtPet(object sender, ElapsedEventArgs e) //hurtnya enemy yang kena damage dari pet
        {
            pictureBoxEnemy.Image = Properties.Resources.cobra_hurt;
            animationIdle = new System.Timers.Timer(durasiHurt) { AutoReset = false } ;
            animationIdle.Elapsed += IdlePet;
            animationIdle.Start();
        }
        private void HurtEnemy(object sender, ElapsedEventArgs e) //hurtnya pet yang kena damage dari enemy
        {
            pictureBoxPet.Image = Properties.Resources.cat_hurt;
            animationIdle = new System.Timers.Timer(durasiHurt) { AutoReset = false };
            animationIdle.Elapsed += IdleEnemy;
            animationIdle.Start();
        }

        private void IdlePet(object sender, ElapsedEventArgs e) //idle enemy setelah kena hurt
        {
            pictureBoxEnemy.Image = Properties.Resources.cobra_idle;
        }
        private void IdleEnemy(object sender, ElapsedEventArgs e) //idle pet setelah kena hurt
        {
            pictureBoxPet.Image = Properties.Resources.cat_idle;
        }



        private void PetIdle(object sender, ElapsedEventArgs e)
        {
            pictureBoxPet.Image = pet.Idle;
        }
        private void PetBasic(object sender, ElapsedEventArgs e)
        {
            pictureBoxPet.Image = pet.Basic;
            System.Timers.Timer animationAttack = new System.Timers.Timer(durasiAttack) { AutoReset = false }; 
            animationAttack.AutoReset = false;
            animationAttack.Elapsed += Attack_IdlePet;
            animationAttack.Start();

            System.Timers.Timer animationHurt = new System.Timers.Timer(durasiHitEnemy) { AutoReset = false };
            animationHurt.AutoReset = false;
            animationHurt.Elapsed += HurtPet;
            animationHurt.Start();
        }
        private void PetSkill(object sender, ElapsedEventArgs e)
        {
            pictureBoxPet.Image = pet.Skill1;
        }
        private void PetUlti(object sender, ElapsedEventArgs e)
        {
            pictureBoxPet.Image = pet.Ulti;
            //if cat
            //pictureBoxPet.Image = pet.Basic;
            //System.Timers.Timer animationAttack = new System.Timers.Timer(durasiAttack) { AutoReset = false };
            //animationAttack.AutoReset = false;
            //animationAttack.Elapsed += Attack_IdlePet;
            //animationAttack.Start();

            //System.Timers.Timer animationHurt = new System.Timers.Timer(durasiHitEnemy) { AutoReset = false };
            //animationHurt.AutoReset = false;
            //animationHurt.Elapsed += HurtPet;
            //animationHurt.Start();
        }
        
        private void EnemyIdle(object sender, ElapsedEventArgs e)
        {
            pictureBoxEnemy.Image = enemy.Idle;
        }
        private void EnemyAttack(object sender, ElapsedEventArgs e)
        {
            pictureBoxEnemy.Image = enemy.Attack1;
            System.Timers.Timer animationAttack = new System.Timers.Timer(durasiAttack) { AutoReset = false };
            animationAttack.AutoReset = false;
            animationAttack.Elapsed += Attack_IdlePet;
            animationAttack.Start();

            System.Timers.Timer animationHurt = new System.Timers.Timer(durasiHitEnemy) { AutoReset = false };
            animationHurt.AutoReset = false;
            animationHurt.Elapsed += HurtPet;
            animationHurt.Start();
        }
        #endregion
    }
}
