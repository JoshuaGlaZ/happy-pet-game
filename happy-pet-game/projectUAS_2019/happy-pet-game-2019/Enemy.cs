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
        private int speed;

        private int health;
        private int energy;
        #endregion

        #region constructor
        public Enemy(string inName, Image inPict, int speed, int inHealth, int inEnergy)
        {
            Name = inName;
            Image = inPict;
            Speed = speed;
            Health = inHealth;
            Energy = inEnergy;
        }
        #endregion

        #region property
        public int Speed 
        { 
            get => speed; 
            set 
            { 
                if (value < 0) { speed = 0; } 
                else if (value>100){ speed = 100; }
                else { speed = value; }
            } 
        }

        public string Name { get => name; set => name = value; }
        public Image Image { get => image; set => image = value; }
        public int Health { get => health; set => health = value; }
        public int Energy { get => energy; set => energy = value; }
        #endregion

        #region method
        public virtual void specialAttack(Pet target)
        {
            target.Health -= Energy;
        }
        public void attack(Pet target)
        {
            target.Health -= Energy;
        }
        #endregion
    }
}
