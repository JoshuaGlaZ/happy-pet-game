using System;
using System.Drawing;

namespace happy_pet_game_2019
{
    public class Pet
    {
        #region DataMembers
        private string name;
        private Image image;

        private int health;
        private int happiness;
        private int energy;

        private Toy toy;
        private Player owner;
        #endregion

        #region Constructors
        public Pet(string inName, Image inPict, Player inOwner)
        {
            Name = inName;
            Image = inPict;
            Health = 100;
            Happiness = 100;
            Energy = 100;
            Toy = toy;
            Owner = inOwner;
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
                    throw new Exception("Nama tidak boleh kosong");
                }
                else
                {
                    name = value;
                }
            }
        }
        public Image Image 
        {
            get => image; 
            set => image = value; 
        }
        public int Health 
        {
            get => health; 
            set
            {
                if (value >= 10 && value <= 100)
                {
                    health = value;
                }
                else if (value < 10)
                {
                    health = 10;
                }
                else
                {
                    health = 100;
                }
            } 
        }
        public int Happiness 
        {
            get => happiness; 
            set
            {
                if (value >= 10 && value <= 100)
                {
                    happiness = value;
                }
                else if (value < 10)
                {
                    happiness = 10;
                }
                else
                {
                    happiness = 100;
                }
            }
        }
        public int Energy 
        {
            get => energy; 
            set
            {
                if (value >= 10 && value <= 100)
                {
                    energy = value;
                }
                else if (value < 10)
                {
                    energy = 10;
                }
                else
                {
                    energy = 100;
                }
            }
        }
        public Toy Toy 
        {
            get => toy; set => toy = value; 
        }
        public Player Owner 
        {
            get => owner; set => owner = value; 
        }

        public Player Player
        {
            get => default;
            set
            {
            }
        }

        public Toy Toy1
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region Methods
        public virtual void Feed()
        {
            this.Health += 30;
            this.Energy += 50;
        }
        public virtual string DisplayData()
        {
            return Name +
                   "\nHealth : " + Health +
                   "\nEnergy : " + Energy +
                   "\nHappiness : " + Happiness;
        }
        public string GetHealthCondition()
        {
            string condition;
            if (this.Health > 80) { condition = "Very Good"; }
            else if (this.Health >= 61) { condition = "Good"; }
            else if (this.Health >= 26) { condition = "Poor"; }
            else { condition = "Very Poor"; }
            return condition;
        }
        public string GetEnergyCondition()
        {
            string condition;
            if (this.Energy > 76) { condition = "Strong"; }
            else if (this.Energy >= 51) { condition = "Moderate"; }
            else { condition = "Weak"; }
            return condition;
        }
        public string GetHappinessCondition()
        {
            return this.Happiness > 60 ? "Happy" : "Unhappy"; //if (this.Happiness > 60) { return "Happy"; } else { return "Unhappy"; }
        }
        public void GetToy()
        {

        }
        #endregion
    }
}