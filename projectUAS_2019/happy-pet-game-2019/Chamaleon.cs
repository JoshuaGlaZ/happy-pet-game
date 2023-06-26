using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    public class Chamaleon : Pet
    {
        #region DataMembers
        private Color currentColor;
        #endregion

        #region Constructors
        public Chamaleon(string inName, Image inPict, Player inOwner, Color currentColor) : base(inName, inPict, inOwner)
        {
            CurrentColor = currentColor;
        }
        #endregion

        #region Properties
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion 

        #region Methods
        public override string ToString()
        {
            return base.ToString() + "\nCurrent color :" + this.CurrentColor + "\n";
        }
        public override void Feed(Consumable consumable)
        {
            base.Feed(consumable);
        }
        public void ChangeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }

        public override void Sleep()
        {
            base.Health += 60;
            base.Energy += 60;
            base.Owner.Coins += (int)(0.5 * 60 * 100);
            base.Owner.Coins += (int)(0.5 * 60 * 100);
        }
        public override void GetToy(Toy EquipedToy)
        {
            if (EquipedToy.Type == "chamaleon".ToUpper())
            {
                base.Toy = EquipedToy;
            }
            else { throw new Exception("Toy isn't compatible to Chamaleon"); }
        }
        #endregion
    }
}