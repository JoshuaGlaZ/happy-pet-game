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

        private int bonusHealth;
        private int bonusEnergy;
        private int happinessGain;
        private double atkSpeedMultiplier;

        private int price;
        private Image picture;
        #endregion

        #region Constructors
        public Toy(string name, Image inPicture, int price, int inBonusHealth, int inBonusEnergy, int inHappinessGain, double inAtkSpeedMultiplier)
        {
            Name = name;
            BonusHealth = inBonusHealth;
            BonusEnergy = inBonusEnergy;
            HappinessGain = inHappinessGain;
            AtkSpeedMultiplier = inAtkSpeedMultiplier;
            Price = price;
            Picture = inPicture;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int Price { get => price; set => price = value; }
        public int BonusHealth { get => bonusHealth; set => bonusHealth = value; }
        public int BonusEnergy { get => bonusEnergy; set => bonusEnergy = value; }
        public int HappinessGain { get => happinessGain; set => happinessGain = value; }
        public double AtkSpeedMultiplier { get => atkSpeedMultiplier; set => atkSpeedMultiplier = value; }
        #endregion

        #region Methods
        public string DisplayData()
        {
            return "Name  : " + this.Name + "\n" +
                   "Price : " + this.Price + "\n" +
                   "Bonus maxHealth : " + this.BonusHealth + "\n" +
                   "Bonus maxEnergy : " + this.BonusEnergy + "\n" +
                   "Happiness Gain  : " + this.HappinessGain + "\n" +
                   "Attack Speed Multiplier : "+ this.AtkSpeedMultiplier;
        }
        #endregion
    }
}