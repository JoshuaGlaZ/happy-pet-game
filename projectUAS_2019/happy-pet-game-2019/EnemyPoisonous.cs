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
        private int poisoneffect;
        private bool poisonStatus;
        public EnemyPoisonous(string inName, Image inPict, int inHealth, int inEnergy,double inAtkSpeed, int inPoisonEffect): base(inName,inPict,inHealth,inEnergy,inAtkSpeed)
        {
            Name = inName;
            Image = inPict;
            Health = inHealth;
            Energy = inEnergy;
            AtkSpeed = inAtkSpeed;
            Poisoneffect = inPoisonEffect;
            PoisonStatus = false;
        }

        public int Poisoneffect { get => poisoneffect; set => poisoneffect = value; }
        public bool PoisonStatus { get => poisonStatus; set => poisonStatus = value; }


        public override void attack(Pet target)
        {
            base.attack(target);
            if (PoisonStatus)
            {
                target.Health -= Poisoneffect;
            }
        }
        public override void specialAttack(Pet target)
        {
            base.specialAttack(target);
            poisonStatus = true;
        }
    }
}
