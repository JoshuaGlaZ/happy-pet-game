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
        public Cat(string inName, Image inPict, Player inOwner) : base(inName, inPict, inOwner)
        {
            VaccStatus = false;
        }
        #endregion

        #region Properties
        public bool VaccStatus { get => vaccStatus; set => vaccStatus = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            string condition = VaccStatus ? "True" : "False"; //if (VaccStatus) { condition = "True"; } else { condition = "False"; }
            return base.ToString() + "\nVaccine Status : " + condition;
        }   
        public override void Feed(Consumable consumable)
        {
            base.Feed(consumable);
        }
        public void Play()
        {
            base.Happiness += 50;
            base.Energy -= 30;
            base.Owner.Coins += (int)(0.5 * 50 * 100);
        }

        public override void Sleep()
        {
            base.Health += 20;
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
            else if (base.Owner.Coins < 1000) { throw new Exception("Not enough Coins.\nVaccinate = 1000Coins"); }
            else
            {
                base.Health += 40;
                base.Happiness -= 10;
                base.Owner.Coins -= 1000;
            }
        }
        public override void GetToy(Toy EquipedToy)
        {
            if (EquipedToy.Type == "cat".ToUpper())
            {
                base.Toy = EquipedToy;
            }
            else { throw new Exception("Toy isn't compatible to Cat"); }
        }
        #endregion
    }
}