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
        private int price;
        #endregion

        #region Constructors
        public Toy(string name, string benefit, int price)
        {
            Name = name;
            Benefit = benefit;
            Price = price;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public int Price { get => price; set => price = value; }
        
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