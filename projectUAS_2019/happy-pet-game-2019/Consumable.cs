﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    [Serializable]
    public class Consumable
    {
        #region DataMembers
        private string name;
        private int price;

        private int healthBonus;
        private int enerygBonus;
        private int happinessBonus;

        private Image picture;
        #endregion

        #region Constuctors
        public Consumable(string name, int price, int healthBonus, int enerygBonus, int happinessBonus, Image inPicture)
        {
            Name = name;
            Price = price;
            HealthBonus = healthBonus;
            EnerygBonus = enerygBonus;
            HappinessBonus = happinessBonus;
            Picture = inPicture;
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
        public int Price { get => price; set => price = value; }
        public int HealthBonus { get => healthBonus; set => healthBonus = value; }
        public int EnerygBonus { get => enerygBonus; set => enerygBonus = value; }
        public int HappinessBonus { get => happinessBonus; set => happinessBonus = value; }
        public Image Picture { get => picture; set => picture = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return this.Name + "\n" +
                   this.HealthBonus + "\n" +
                   this.EnerygBonus + "\n" +
                   this.HappinessBonus + "\n";
        }
        #endregion
    }
}