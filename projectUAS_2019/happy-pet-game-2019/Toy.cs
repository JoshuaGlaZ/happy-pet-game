using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    public class Toy
    {
        #region DataMembers
        private string name;
        private string type;
        private string benefit;
        private Image image;
        private int price;
        #endregion

        #region Constructors
        public Toy(string name, string benefit, Image image, int price)
        {
            Name = name;
            Benefit = benefit;
            Image = image;
            Price = price;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public Image Image { get => image; set => image = value; }
        public int Price { get => price; set => price = value; }
        public string Type
        {
            get => type;
            set
            {
                if (value == "cat".ToUpper() || value == "fish".ToUpper() || value == "chamaleon".ToUpper())
                {
                    type = value;
                }
                else { throw new Exception("Not registered type"); }
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return this.Name + "\n" +
                   this.Type + "\n" + 
                   this.Benefit + "%\n" + 
                   this.Price + "\n";
        }
        #endregion
    }
}