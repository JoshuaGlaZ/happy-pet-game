using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace happy_pet_game_2019
{
    public abstract class Enemy
    {
        #region dataMember
        private string name;
        private Image idle;
        private Image hurt;
        private Image death;
        private Image attack1;
        private double atkSpeed;

        private int level;

        private int maxHealth;
        private int health;
        private int energy;
        private int maxRage; // kayak Maxhappiness di pet, buat njalain special attack
        private int rage; // Kayak Happiness di pet
        private int statusDuration; // lama statusnya berjalan
        #endregion

        #region constructor
        public Enemy(string inName, Image inIdle, Image inHurt, Image inDeath, Image inAttack, int inHealth, int inEnergy, double inAtkSpeed, int inMaxRage, int level)
        {
            Name = inName;
            Idle = inIdle;
            Hurt = inHurt;
            Death = inDeath;
            Attack1 = inAttack;

            Level = level;

            MaxHealth = inHealth;
            Health = MaxHealth;
            Energy = inEnergy;
            AtkSpeed = inAtkSpeed;
            StatusDuration = 0;
            MaxRage = inMaxRage;
            Rage = 0;
        }
        #endregion

        #region property
        public string Name { get => name; set => name = value; }
        public Image Idle { get => idle; set => idle = value; }
        public Image Hurt { get => hurt; set => hurt = value; }
        public Image Death { get => death; set => death = value; }
        public Image Attack1 { get => attack1; set => attack1 = value; }
        public int Health { get => health; set => health = value; }
        public int Energy { get => energy; set => energy = value; }
        public double AtkSpeed { get => atkSpeed; set => atkSpeed = value; }
        public int StatusDuration { get => statusDuration; set => statusDuration = value; }
        public int MaxRage { get => maxRage; set => maxRage = value; }
        public int Rage { get => rage; set { if (value > maxRage) { rage = MaxRage; } else { rage = value; } } }
        public int Level { get => level; set => level = value; }
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        #endregion

        #region method
        public virtual int getDebuffEffect() { return 0; }
        public virtual int getPoisonEffect() { return 0; }
        public virtual string DisplayData()
        {
            return "Name : " + Name + "\n" +
                   "Level  : " + Level + "\n" +
                   "Health : " + Health +"/"+ MaxHealth+ "\n" +
                   "Energy : " + Energy + "\n" +
                   "Attack Speed : " + AtkSpeed + "\n" +
                   "Rage : "+Rage+"/"+MaxRage;
        }
        public virtual void specialAttack(Pet target)
        {
            target.Health -= Energy-(target.Defense/2);
            Rage = 0;
            if(target.GetColor()=="white" || target.GetEnviromentStatus() == "Clean") { statusDuration = 0; }
            else { statusDuration = 3; }
        }
        public virtual void attack(Pet target)
        {
            if (Energy > target.Defense) { target.Health -= Energy - target.Defense; }
            Rage = rage + 10;
        }
        #endregion
    }
}
