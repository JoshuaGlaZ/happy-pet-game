using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace happy_pet_game_2019
{
    public class EnemyPoisonous:Enemy
    {
        private int poisonEffect;
        public EnemyPoisonous(string inName, Image inPict, int inHealth, int inEnergy,double inAtkSpeed, 
            int inPoisonEffect, int inMaxRage, int inLevel) : 
            base(inName, inPict, inHealth, inEnergy, inAtkSpeed, inMaxRage, inLevel)
        {
            Name = inName;
            Image = inPict;
            Health = inHealth;
            Energy = inEnergy;
            AtkSpeed = inAtkSpeed;
            PoisonEffect = inPoisonEffect;
        }

        public int PoisonEffect { get => poisonEffect; set => poisonEffect = value; }

        public override int getPoisonEffect()
        {
            return base.getPoisonEffect() + PoisonEffect;
        }
        public override void specialAttack(Pet target)
        {
            base.specialAttack(target);
            StatusBerjalan = StatusDuration; 
        }
    }
}