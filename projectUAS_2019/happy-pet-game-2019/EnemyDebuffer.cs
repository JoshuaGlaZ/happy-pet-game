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
        public EnemyDebuffer(string inName, Image inIdle, Image inHurt, Image inDeath, Image inAttack, int inHealth, int inEnergy, double inAtkSpeed, 
            int inMaxRage, int inDebuffEffect, int inLevel) : 
            base(inName, inIdle, inHurt, inDeath, inAttack, inHealth, inEnergy, inAtkSpeed, inMaxRage, inLevel)
        {
            DebuffEffect = inDebuffEffect;
        }

        public int DebuffEffect { get => debuffEffect; set => debuffEffect = value; }

        public override int getDebuffEffect()
        {
            return base.getDebuffEffect()+DebuffEffect;
        }
        public override void specialAttack(Pet target)
        {
            if(target.GetColor() == "white" || target.GetEnviromentStatus() == "Clean")
            {
                base.specialAttack(target);
                target.Energy -= DebuffEffect;
            }
            else
            {
                base.specialAttack(target);
                target.Energy -= DebuffEffect;
            }
        }
    }
}

