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
        public EnemyDrain(string inName, Image inPict, int inSpeed, int inHealth, int inEnergy, int inDrainEffect) : base(inName, inPict, inSpeed, inHealth, inEnergy)
        {
            Name = inName;
            Image = inPict;
            Speed = inSpeed;
            Health = inHealth;
            Energy = inEnergy;
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
