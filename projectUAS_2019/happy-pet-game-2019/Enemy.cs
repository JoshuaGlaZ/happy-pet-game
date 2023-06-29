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
        private int statusDuration;
        private int statusBerjalan;
        #endregion

        #region constructor
        public Enemy(string inName, Image inPict, int inHealth, int inEnergy, double inAtkSpeed,int inStatusDuration)
        {
            Name = inName;
            Image = inPict;
            Health = inHealth;
            Energy = inEnergy;
            AtkSpeed = inAtkSpeed;
            StatusDuration = inStatusDuration;
            StatusBerjalan = 0;
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
        #endregion

        #region method
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
        }
        public virtual void attack(Pet target)
        {
            target.Health -= Energy;
        }
        #endregion
    }
}
