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
        private bool envStatus;
        #endregion

        #region Constructors
        public Fish(string inName, Image inPict, Player inOwner, int inMaxHealth, int inMaxHappiness, int inEnergy, bool envStatus) : base(inName, inPict, inOwner,inMaxHealth,inMaxHappiness,inEnergy)
        {
            EnvStatus = envStatus;
        }
        #endregion

        #region Properties
        public bool EnvStatus { get => envStatus; set => envStatus = value; }
        #endregion

        #region Methods
        public override string DisplayData()
        {
            return base.DisplayData() + 
                   "\nEnviroment :" + this.envStatus;
        }

        public void Clean()
        {
            if (base.Owner.Coins >= 500)
            {
                base.Health += base.MaxHealth;
                base.Happiness += base.MaxHappiness;
                base.Owner.Coins -= 500;
            }
            else { throw new Exception("not enough coins.\nClean = 500 Coins"); }
        }

        public override void Skill(Enemy target)
        {
            throw new NotImplementedException();
        }
        public override void Ultimate(Enemy target)
        {
            if (base.Happiness == base.MaxHappiness)
            {
                target.Health -= (int)(this.Energy * 1.25);
                this.Health += (int)(this.MaxHealth / 2);
                this.Happiness = 0;
            }
            else { throw new Exception("Ultimate not ready"); }
        }
        #endregion
    }
}