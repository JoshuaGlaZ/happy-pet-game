﻿using System;
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
        public EnemyDrain(string inName, Image inIdle, Image inHurt, Image inDeath, Image inAttack, int inHealth, int inEnergy, double inAtkSpeed, 
            int inDrainEffect, int inMaxRage,int inLevel) : 
            base(inName, inIdle, inHurt, inDeath, inAttack, inHealth, inEnergy, inAtkSpeed, inMaxRage, inLevel)
        {
            DrainEffect = inDrainEffect;
        }

        public int DrainEffect { get => drainEffect; set => drainEffect = value; }

        public override void specialAttack(Pet target)
        {
            if (target.GetColor() == "white" || target.GetEnviromentStatus() == "Clean")
            {
                base.specialAttack(target);
            }
            else
            {
                base.specialAttack(target);
                target.Happiness -= DrainEffect;
            }
            this.StatusDuration = 0;
        }
    }
}
