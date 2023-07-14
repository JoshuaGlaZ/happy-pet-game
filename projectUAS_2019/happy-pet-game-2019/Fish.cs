using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    public class Fish : Pet
    {
        #region DataMembers
        private string envStatus;
        #endregion

        #region Constructors
        public Fish(string inName, Image inPict, Player inOwner, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense) : base(inName, inPict, inOwner, inMaxHealth, inMaxHappiness, inEnergy, inDefense)
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
            if (base.Owner.Coins >= 500)
            {
                base.Health += base.MaxHealth;
                base.Happiness += base.MaxHappiness;
                base.Owner.Coins -= 500;
                envStatus = "Clean";
            }
            else { throw new Exception("not enough coins.\nClean = 500 Coins"); }
        }

        public override void Skill(Enemy target)
        {
            if (SkillPoin == 3)
            {
                EnvStatus = "Clean";
                Health = Health + (int)(0.15 * MaxHealth);
                BuffStatus = true;
                StatusDuration = 3;
            }
            else { throw new Exception("skill point isn't enough"); }
        }
        public override void Ultimate(Enemy target)
        {
            if (base.Happiness == base.MaxHappiness)
            {
                target.Health -= (int)(this.Energy * 1.5);
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
            BuffStatus = false;
        }
        #endregion
    }
}