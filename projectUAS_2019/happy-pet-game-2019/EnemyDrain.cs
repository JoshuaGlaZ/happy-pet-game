using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace happy_pet_game_2019
{
    public class EnemyDrain:Enemy
    {
        private int drainEffect;
        public EnemyDrain(string inName, Image inPict, int inHealth, int inEnergy, double inAtkSpeed, 
            int inDrainEffect, int inMaxRage,int inLevel) : 
            base(inName, inPict, inHealth, inEnergy, inAtkSpeed, inMaxRage, inLevel)
        {
            Name = inName;
            Image = inPict;
            Health = inHealth;
            Energy = inEnergy;
            AtkSpeed = inAtkSpeed;
            DrainEffect = inDrainEffect;
        }

        public int DrainEffect { get => drainEffect; set => drainEffect = value; }

        public override void specialAttack(Pet target)
        {
            base.specialAttack(target);
            target.Happiness -= DrainEffect;
        }
    }
}
