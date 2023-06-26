using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace happy_pet_game_2019
{
    public class EnemyDebuffer : Enemy
    {
        private int debuffEffect;
        public EnemyDebuffer(string inName, Image inPict, int inSpeed, int inHealth, int inEnergy, int inDebuffEffect) : base(inName, inPict, inSpeed, inHealth, inEnergy)
        {
            Name = inName;
            Image = inPict;
            Speed = inSpeed;
            Health = inHealth;
            Energy = inEnergy;
            DebuffEffect = inDebuffEffect;
        }

        public int DebuffEffect { get => debuffEffect; set => debuffEffect = value; }

        public override void specialAttack(Pet target)
        {
            base.specialAttack(target);
            target.Energy -= DebuffEffect;
        }
    }
}

