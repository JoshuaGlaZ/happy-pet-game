using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    [Serializable]
    public class Chamaleon : Pet
    {
        #region DataMembers
        private Color currentColor;
        #endregion

        #region Constructors
        public Chamaleon(string inName, string trait, Image inPict, Color currentColor) : base(inName, trait, inPict)
        {
            CurrentColor = currentColor;
        }
        #endregion

        #region Properties
        public Color CurrentColor 
        { 
            get => currentColor;
            set
            {
                if (value == Color.Blue || value == Color.Green || value == Color.Red || value == Color.Yellow)
                {
                    currentColor = value;
                }
                else
                {
                    throw new Exception("Chameleon only has green, blue, red, and yellow color");
                }
            }
        }
        #endregion 

        #region Methods
        public override string ToString()
        {
            string color;
            if (this.CurrentColor == Color.Blue) { color = "Blue"; }
            else if (this.CurrentColor == Color.Green) { color = "Green"; }
            else if (this.CurrentColor == Color.Red) { color = "Red"; }
            else { color = "Yellow"; }
            return base.ToString() + "\nCurrent color : " + color + "\n";
        }
        public override void Feed(Consumable consumable)
        {
            base.Feed(consumable);
        }
        public void ChangeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }

        #endregion
    }
}