using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    [Serializable]
    public class Toy
    {
        #region DataMembers
        private string name;
        private string benefit;
        private Image picture;
        private int price;
        #endregion

        #region Constructors
        public Toy(string name, string benefit, int price, Image inPicture)
        {
            Name = name;
            Benefit = benefit;
            Price = price;
            Picture = inPicture;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public int Price { get => price; set => price = value; }
        public Image Picture { get => picture; set => picture = value; }

        #endregion

        #region Methods
        public override string ToString()
        {
            return this.Name + "\n" +
                   this.Benefit + "%\n" + 
                   this.Price + "\n";
        }
        #endregion
    }
}