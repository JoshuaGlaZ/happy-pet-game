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
        public Cat(string inName, Image inPict, Player inOwner, bool vaccStatus) : base(inName, inPict, inOwner)
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
            return base.ToString() + "\nVaccine Status : " + condition;
        }

        public void Play()
        {
            base.Happiness += 50;
            base.Energy -= 30;
            base.Owner.Coins += (int)(0.5 * 50 * 100);
        }

        public void Sleep()
        {
            base.Happiness += 20;
            base.Energy += 70;
            base.Owner.Coins += (int)(0.5 * 20 * 100);
            base.Owner.Coins += (int)(0.5 * 70 * 100);
        }

        public void Bath()
        {
            base.Health += 30;
            base.Owner.Coins += (int)(0.5 * 30 * 100);
        }

        public void Vaccinate()
        {
            if (VaccStatus)  { throw new Exception("Already vaccinated"); }
            else if (base.Owner.Coins < 1000) { throw new Exception("Not Enough Coins.\nVaccinate = 1000Coins"); }
            else
            {
                base.Health += 40;
                base.Happiness -= 10;
                base.Owner.Coins -= 1000;
            }
        }
        #endregion
    }
}