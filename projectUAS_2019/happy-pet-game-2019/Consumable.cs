using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    public class Consumable
    {
        #region DataMembers
        private string name;
        private Image image;
        private int price;

        private int healthBonus;
        private int enerygBonus;
        private int happinessBonus;

        private int fullness; // seberapa banyak ngisi status kenyang
        #endregion

        #region Constuctors
        public Consumable(string name, Image image, int price, int healthBonus, int enerygBonus, int happinessBonus, int fullness)
        {
            Name = name;
            Image = image;
            Price = price;
            HealthBonus = healthBonus;
            EnergyBonus = enerygBonus;
            HappinessBonus = happinessBonus;
            Fullness = fullness;
        }
        #endregion

        #region Properties
        public string Name
        {
            get => name;
            set
            {
                if (value == "")
                {
                    throw new Exception("Name cannot be empty");
                }
                else { name = value; }
            }
        }
        public Image Image { get => image; set => image = value; }
        public int Price { get => price; set => price = value; }
        public int HealthBonus { get => healthBonus; set => healthBonus = value; }
        public int EnergyBonus { get => enerygBonus; set => enerygBonus = value; }
        public int HappinessBonus { get => happinessBonus; set => happinessBonus = value; }
        public int Fullness 
        { 
            get => fullness; 
            set 
            { 
                if (value > 0 && value <= 100) { fullness = value; } 
                else { throw new Exception("fullness range 1-100"); } 
            } 
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Name : " + this.Name + "\n" +
                   "Health Bonus :" + this.HealthBonus + "\n" +
                   "Energy Bonus :" + this.EnergyBonus + "\n" +
                   "Happiness Bonus :" + this.HappinessBonus + "\n" +
                   "Fullness : " + Fullness;
        }
        #endregion
    }
}