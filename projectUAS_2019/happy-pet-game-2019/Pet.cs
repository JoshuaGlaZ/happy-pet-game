using System;
using System.Drawing;
using System.Windows.Forms;

namespace happy_pet_game_2019
{
    public abstract class Pet
    {
        #region DataMembers
        private string name;
        private Image image;

        private int level;
        private int expBar; //banyak exp yg dibutuhkan untuk naik level
        private int expProgress; //exp yg terkumpul

        private int statusDuration; // lama statusnya berjalan
        private int statusBerjalan; // counter sudah berapa lama statusnya berjalan

        private int maxHealth;
        private int maxHappiness;
        private double atkSpeed;

        private int health;
        private int happiness;
        private int energy;

        private int fill;
        private int maxFill; // batas kekenyangannya

        private Toy toy;
        private Player owner;
        #endregion

        #region Constructors
        public Pet(string inName, Image inPict, Player inOwner, int inMaxHealth, int inMaxHappiness, int inEnergy)
        {
            Name = inName;
            Image = inPict;

            Level = 1;
            ExpBar = 100;
            ExpProgress = 0;

            StatusDuration = 3;
            StatusBerjalan = 0;

            MaxHealth = inMaxHealth;
            Health = inMaxHealth;
            Energy = inEnergy;
            MaxHappiness = inMaxHappiness;
            Happiness = 0;
            AtkSpeed = 1;

            Fill = 0;
            MaxFill = 100; 

            toy = new Toy("none", 0, 0, 0, 1, image, 0);
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
                    throw new Exception("Name can't be empty");
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
        public int Energy  { get => energy; set { if (value < 0) { energy = 0; } else { energy = value; } } }
        public Toy Toy  { get => toy; set => toy = value; }
        public Player Owner  { get => owner; set => owner = value; }
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public int MaxHappiness { get => maxHappiness; set => maxHappiness = value; }
        public double AtkSpeed { get => atkSpeed; set => atkSpeed = value; }
        public int ExpBar { get => expBar; set => expBar = value; }
        public int ExpProgress { get => expProgress; set => expProgress = value; }
        public int Level { get => level; set => level = value; }
        public int Fill { get => fill; set => fill = value; }
        public int MaxFill { get => maxFill; set => maxFill = value; }
        public int StatusDuration { get => statusDuration; set => statusDuration = value; }
        public int StatusBerjalan { get => statusBerjalan; set => statusBerjalan = value; }
        #endregion

        #region Methods
        public void levelUp(int expGained)
        {
            while(ExpProgress >= ExpBar)
            {
                if (ExpProgress - ExpBar < 0) { break; }
                else { ExpProgress = ExpProgress - ExpBar; }
                ExpBar = (int)(ExpBar * 1.25);

                Level += 1;
                MaxHealth = (int)(MaxHealth * 1.1);
                Health = MaxHealth;
                Energy = (int)(Energy * 1.1);
                Happiness = MaxHappiness;
            }
        }

        public virtual void Feed(Consumable food)
        {
            this.Health += food.HealthBonus;
            this.Happiness += food.HappinessBonus;
            this.Energy += food.EnergyBonus;
        }
        public virtual string DisplayData()
        {
            return "Name : " + Name +
                   "\nLevel  : " + Level  + "\t\tNext level up : " + ExpProgress + "/" + expBar +
                   "\nHealth : " + Health + "/"+ MaxHealth +
                   "\nEnergy : " + Energy +
                   "\nHappiness : " + Happiness + "/" + MaxHappiness +
                   "\nAttack Speed : " + toy.AtkSpeedMultiplier;
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
            this.Energy += equipment.BonusEnergy;
            this.AtkSpeed = 1 / equipment.AtkSpeedMultiplier;
        }

        public void basicAttack(Enemy target)
        {
            target.Health -= Energy;
            this.Happiness += 10 + toy.HappinessGain;
        }

        public abstract void Skill(Enemy target);
        public abstract void Ultimate(Enemy target);
        #endregion
    }
}