using System;
using System.Drawing;

namespace happy_pet_game_2019
{
    [Serializable]
    public abstract class Pet
    {
        #region DataMembers
        private string name;
        private string trait;

        private int health;
        private int happiness;
        private int energy;

        private Image picture;
        public Toy toy;
        #endregion

        #region Constructors
        public Pet(string inName, string trait, Image picture)
        {
            Name = inName;
            Trait = trait;
            Health = 100;
            Happiness = 100;
            Energy = 100;
            Toy = toy;
            Picture = picture;
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
                    throw new Exception("Pet name cannot be empty");
                }
                else { name = value; }
            }
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
                else if (value < 10) { health = 10; }
                else { health = 100; }
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
                else if (value < 10)  { happiness = 10; }
                else { happiness = 100; }
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
                else if (value < 10){ energy = 10;}
                else { energy = 100; }
            }
        }
        public Toy Toy { get => toy; set => toy = value; }
        public string Trait 
        {
            get => trait; 
            set
            {
                if (value != "")
                {
                    trait = value;
                }
                else
                {
                    throw new Exception("Trait cannot be empty");
                }
            }
        }

        public Image Picture { get => picture; set => picture = value; }


        #endregion

        #region Methods
        public virtual void Feed(Consumable consumable)
        {
            this.Health += consumable.HealthBonus;
            this.Energy += consumable.EnerygBonus;
            this.Happiness += consumable.HappinessBonus;
        }
        public virtual void Sleep() { this.Health += 0; }
        public override string ToString()
        {
            return "Name : " + Name +
                   "\nTrait : " + Trait + 
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
        public virtual void GetToy(Toy EquipedToy)
        {
            Toy = EquipedToy;
        }
        #endregion
    }
}