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
        public Cat(string inName, string trait, Image inPict) : base(inName, trait, inPict)
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
            return base.ToString() + "\nVaccine Status : " + condition + '\n';
        }   
        public override void Feed(Consumable consumable)
        {
            base.Feed(consumable);
        }
        
        #endregion
    }
}