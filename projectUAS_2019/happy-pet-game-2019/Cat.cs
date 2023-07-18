using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    [Serializable]
    public class Cat : Pet
    {
        #region DataMembers
        private bool vaccStatus;
        #endregion

        #region Constructors
        public Cat(string inName, string inTrait, Image inPict, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense) : base(inName,inTrait,inPict,inMaxHealth,inMaxHappiness,inEnergy, inDefense)
        {
            VaccStatus = false;
        }
        #endregion

        #region Properties
        public bool VaccStatus { get => vaccStatus; set => vaccStatus = value; }
        #endregion

        #region Methods
        public override string DisplayData()
        {
            string condition = VaccStatus ? "True" : "False"; //if (VaccStatus) { condition = "True"; } else { condition = "False"; }
            return base.DisplayData() + "\nVaccine Status : " + condition;
        }

        public override void Play()
        {
            base.Happiness += (int)(base.MaxHappiness/2);
        } 
        public override void Sleep() 
        {
            Happiness += MaxHappiness;
            Health += MaxHealth;
        } 
        public override void Bath()
        {
            base.Health = base.MaxHealth;
        }
        public override void Vaccinate()
        {
            if (VaccStatus)  { throw new Exception("already vaccinated"); }
            else{VaccStatus = true;}
        }

        private int stack=0;
        public override void Skill(Enemy target)
        {
            if (SkillPoin > 0 && stack<2)
            {
                Energy += Energy;
                AtkSpeed = AtkSpeed * 1.25;
                StatusDuration = 3;
                if (VaccStatus == false) { Health -= (int)(0.05 * Health); }
                Happiness = Happiness + HappinessGain;
                stack += 1;
                SkillPoin -= 1;
            }
            else if(SkillPoin > 0 && stack >= 2) { throw new Exception("Full stack achieved"); }
            else { throw new Exception("skill point isn't enough"); }
        }
        public override void Ultimate(Enemy target)
        {
            if(base.Happiness == base.MaxHappiness)
            {
                target.Health -= this.Energy * 4;
                this.Happiness = 0;
                if (this.VaccStatus) { base.Health += (int)(MaxHealth / 5); }
            }
            else { throw new Exception("Ultimate not ready"); }
        }

        public override void buffRemover(Enemy enemy)
        {
            if(enemy is EnemyDebuffer && enemy.StatusDuration > 0)
            {
                Energy = OriginalEnergy-enemy.getDebuffEffect(); 
            }
            else
            {
                Energy = OriginalEnergy; 
            }
            AtkSpeed = AtkSpeed / Math.Pow(1.25,stack);
            stack = 0;
        }
        #endregion
    }
}