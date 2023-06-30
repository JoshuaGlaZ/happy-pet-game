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
        private Image image;
        private double atkSpeed;

        private int health;
        private int energy;
        private int maxRage; // kayak Maxhappiness di pet, buat njalain special attack
        private int rage; // Kayak Happiness di pet
        private int statusDuration; // lama statusnya berjalan
        private int statusBerjalan; // counter sudah berapa lama statusnya berjalan

        private int coinsReward;
        private int expReward;
        #endregion

        #region constructor
        public Enemy(string inName, Image inPict, int inHealth, int inEnergy, double inAtkSpeed, int inMaxRage)
        {
            Name = inName;
            Image = inPict;
            Health = inHealth;
            Energy = inEnergy;
            AtkSpeed = inAtkSpeed;
            StatusDuration = 3;
            StatusBerjalan = 0;
            CoinsReward    = (int)(Health * Energy * AtkSpeed);
            ExpReward      = (int)(CoinsReward/2);
            MaxRage = inMaxRage;
            Rage = 0;
        }
        #endregion

        #region property
        public string Name { get => name; set => name = value; }
        public Image Image { get => image; set => image = value; }
        public int Health { get => health; set => health = value; }
        public int Energy { get => energy; set => energy = value; }
        public double AtkSpeed { get => atkSpeed; set => atkSpeed = value; }
        public int StatusDuration { get => statusDuration; set => statusDuration = value; }
        public int StatusBerjalan { get => statusBerjalan; set => statusBerjalan = value; }
        public int CoinsReward { get => coinsReward; set => coinsReward = value; }
        public int ExpReward { get => expReward; set => expReward = value; }
        public int MaxRage { get => maxRage; set => maxRage = value; }
        public int Rage { get => rage; set => rage = value; }
        #endregion

        #region method
        public virtual int getDebuffEffect() { return 0; }
        public virtual int getPoisonEffect() { return 0; }
        public virtual string DisplayData()
        {
            return "Name : "+Name+"\n"+
                   "Health : "+Health +"\n"+
                   "Energy : "+Energy +"\n"+
                   "Attack Speed : "+AtkSpeed;
        }
        public virtual void specialAttack(Pet target)
        {
            target.Health -= Energy;
            statusBerjalan = statusDuration;
            Rage = 0;
        }
        public virtual void attack(Pet target)
        {
            target.Health -= Energy;
            Rage += 10;
        }
        #endregion
    }
}
