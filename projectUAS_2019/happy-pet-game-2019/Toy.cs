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

        public Player Player
        {
            get => default;
            set
            {
            }
        }

        public Pet Pet
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region Methods
        public string DisplayDate()
        {
            return this.Name + "\n" +
                   this.Price + "\n" +
                   this.Benefit + "%";
        }
        #endregion
    }
}