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
        public Chamaleon(string inName, Image inPict, Player inOwner, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense) : base(inName, inPict, inOwner, inMaxHealth, inMaxHappiness, inEnergy, inDefense)
        {
            CurrentColor = Color.Green;
        }
        #endregion

        #region Properties
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion 

        #region Methods
        public override string DisplayData()
        {
            return base.DisplayData() + "\nCurrent color :" + this.CurrentColor + "\n";
        }

        public void ChangeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }

        public override string GetColor()
        {
            if(CurrentColor == Color.White) { return "white"; }
            else { return "not white"; }
        }
        #endregion
    }
}