using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    public class Cat : Pet
    {
        #region DataMembers
        private bool vaccStatus;
        #endregion

        #region Constructors
        public Cat(string inName, Image inPict, Player inOwner, int inMaxHealth, int inMaxHappiness, int inEnergy) : base(inName, inPict, inOwner,inMaxHealth,inMaxHappiness,inEnergy)
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

        public void Play()
        {
            base.Happiness += (int)(base.MaxHappiness/2);
        }

        public void Sleep()
        {
            base.Happiness = base.MaxHappiness;
            base.Health = base.MaxHealth;
        }

        public void Bath()
        {
            base.Health = base.MaxHealth;
        }

        public void Vaccinate()
        {
            if (VaccStatus)  { throw new Exception("already vaccinated"); }
            else if (base.Owner.Coins < 1000) { throw new Exception("not enough coins.\nVaccinate = 1000Coins"); }
            else{ base.Owner.Coins -= 1000; }
        }

        public override void Skill(Enemy target)
        {
            throw new NotImplementedException();
        }
        public override void Ultimate(Enemy target)
        {
            if(base.Happiness == base.MaxHappiness)
            {
                target.Health -= this.Energy * 2;
                this.Happiness = 0;
                if (this.VaccStatus) { base.Health += (int)(MaxHealth / 5); }
            }
            else { throw new Exception("Ultimate not ready"); }
        }
        #endregion
    }
}