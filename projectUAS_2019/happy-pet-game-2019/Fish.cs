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
        private bool envStatus;
        #endregion

        #region Constructors
        public Fish(string inName, Image inPict, Player inOwner, bool envStatus) : base(inName, inPict, inOwner)
        {
            EnvStatus = envStatus;
        }
        #endregion

        #region Properties
        public bool EnvStatus { get => envStatus; set => envStatus = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + "\nEnviroment :" + this.envStatus;
        }
        public override void Feed(Consumable consumable)
        {
            base.Feed(consumable);
        }
        public void Clean()
        {
            if (base.Owner.Coins >= 500)
            {
                base.Health += 60;
                base.Happiness += 50;
                base.Owner.Coins -= 500;
                base.Owner.Coins += (int)(0.5 * 60 * 100);
                base.Owner.Coins += (int)(0.5 * 50 * 100);
            }
            else { throw new Exception("Not enough coins.\nClean = 500 Coins"); }
        }
        public override void GetToy(Toy EquipedToy)
        {
            if (EquipedToy.Type == "fish".ToUpper())
            {
                base.Toy = EquipedToy;
            }
            else { throw new Exception("Toy isn't compatible to Fish"); }
        }
        #endregion
    }
}