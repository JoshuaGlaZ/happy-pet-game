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
        public Fish(string inName, string trait ,Image inPict) : base(inName, trait, inPict)
        {
            EnvStatus = false;
        }
        #endregion

        #region Properties
        public bool EnvStatus { get => envStatus; set => envStatus = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + "\nEnviroment :" + this.envStatus + '\n';
        }
        public override void Feed(Consumable consumable)
        {
            base.Feed(consumable);
        }
        
        #endregion
    }
}