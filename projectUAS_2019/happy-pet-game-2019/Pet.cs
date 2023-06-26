using System;
using System.Drawing;

namespace happy_pet_game_2019
{
    public abstract class Pet
    {
        #region DataMembers
        private string name;
        private Image image;

        private int maxHealth;
        private int maxHappiness;
        private int maxEnergy;

        private int health;
        private int happiness;
        private int energy;

        private Toy toy;
        private Player owner;
        #endregion

        #region Constructors
        public Pet(string inName, Image inPict, Player inOwner, int inMaxHealth, int inMaxHappiness, int inEnergy)
        {
            Name = inName;
            Image = inPict;

            MaxHealth = inMaxHealth;
            Health = inMaxHealth;
            Energy = inEnergy;
            MaxHappiness = inMaxHappiness;
            Happiness = 0;

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
        public Image Image { get => image;  set => image = value; }
        public int Health 
        {
            get => health; 
            set
            {
                if (value >= 0 && value <= MaxHealth)
                {
                    health = value;
                }
                else if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = MaxHealth;
                }
            } 
        }
        public int Happiness 
        {
            get => happiness; 
            set
            {
                if (value >= 0 && value <= MaxHappiness)
                {
                    happiness = value;
                }
                else if (value < 0)
                {
                    happiness = 0;
                }
                else
                {
                    happiness = MaxHappiness;
                }
            }
        }
        public int Energy 
        {
            get => energy; 
            set
            {
                if (value >= 0 && value <= MaxEnergy)
                {
                    energy = value;
                }
                else if (value < 0)
                {
                    energy = 0;
                }
                else
                {
                    energy = MaxEnergy;
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
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public int MaxHappiness { get => maxHappiness; set => maxHappiness = value; }
        public int MaxEnergy { get => maxEnergy; set => maxEnergy = value; }
        #endregion

        #region Methods
        public virtual void Feed(Consumable food)
        {
            this.Health += food.HealthBonus;
            this.Happiness += food.HappinessBonus;
            this.Energy += food.EnergyBonus;
        }
        public virtual string DisplayData()
        {
            return Name +
                   "\nHealth : " + Health + "/"+ MaxHealth +
                   "\nEnergy : " + Energy +
                   "\nHappiness : " + Happiness + "/" + MaxHappiness;
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

        public void GetToy(Toy equipment)
        {
            this.Toy = equipment;
            this.MaxHealth += equipment.BonusHealth;
            this.MaxEnergy += equipment.BonusEnergy;
        }

        public void basicAttack(Enemy target)
        {
            target.Health -= this.Energy;
            this.Happiness += 10 + toy.HappinessGain;
        }
        public abstract void Ultimate(Enemy target);
        #endregion
    }
}