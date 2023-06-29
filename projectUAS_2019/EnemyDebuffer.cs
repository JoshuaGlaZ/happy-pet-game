﻿using System;
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
        public EnemyDebuffer(string inName, Image inPict, int inHealth, int inEnergy, double inAtkSpeed, int inDebuffEffect) : base(inName, inPict, inHealth, inEnergy, inAtkSpeed)
        {
            Name = inName;
            Image = inPict;
            Health = inHealth;
            Energy = inEnergy;
            AtkSpeed = inAtkSpeed;
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
