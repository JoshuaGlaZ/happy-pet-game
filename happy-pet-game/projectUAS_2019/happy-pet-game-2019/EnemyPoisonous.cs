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
        public EnemyPoisonous(string inName, Image inPict, int inSpeed, int inHealth, int inEnergy, int inPoisonEffect): base(inName,inPict,inSpeed,inHealth,inEnergy)
        {
            Name = inName;
            Image = inPict;
            Speed = inSpeed;
            Health = inHealth;
            Energy = inEnergy;
            Poisoneffect = inPoisonEffect;
        }

        public int Poisoneffect { get => poisoneffect; set => poisoneffect = value; }

        public override void specialAttack(Pet target)
        {
            base.specialAttack(target);
            //masih dipikirkan cara masukinnya
        }
    }
}
