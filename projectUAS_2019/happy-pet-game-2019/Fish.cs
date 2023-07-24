using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    [Serializable]
    public class Fish : Pet
    {
        #region DataMembers
        private string envStatus;
        #endregion

        #region Constructors
        public Fish(string inName, string inTrait, Image inIdle, Image inHurt, Image inDeath, Image inBasic, Image inSkill, Image inUlti, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense) : base(inName, inTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, inMaxHealth, inMaxHappiness, inEnergy, inDefense)
        {
            EnvStatus = "Normal";
        }
        #endregion

        #region Properties
        public string EnvStatus { get => envStatus; set => envStatus = value; }
        #endregion

        #region Methods
        public override string DisplayData()
        {
            return base.DisplayData() + 
                   "\nEnviroment :" + this.EnvStatus;
        }

        public void Clean()
        {
            base.Health += base.MaxHealth;
            base.Happiness += base.MaxHappiness;
            envStatus = "Clean";
        }

        public override void Skill(Enemy target)
        {
            if (SkillPoin == 3)
            {
                EnvStatus = "Clean";
                Health = Health + (int)(0.15 * MaxHealth);
                StatusDuration = 3;
                SkillPoin = 0;
            }
            else { throw new Exception("skill point isn't enough"); }
        }
        public override void Ultimate(Enemy target)
        {
            if (base.Happiness == base.MaxHappiness)
            {
                target.Health -= (int)(this.Energy * 1.5);
                if (EnvStatus == "Clean") { target.Health -= (int)(this.Energy * 1.5); }
                this.Health += (int)(this.MaxHealth / 2);
                this.Happiness = 0;
            }
            else { throw new Exception("Ultimate not ready"); }
        }

        public override string GetEnviromentStatus()
        {
            return EnvStatus;
        }

        public override void buffRemover(Enemy enemy)
        {
            EnvStatus = "Normal";
        }
        #endregion
    }
}