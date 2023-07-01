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

        private bool buffStatus;
        private int statusDuration; // lama statusnya berjalan

        private int maxHealth;
        private int maxHappiness;
        private double atkSpeed;

        private int health;
        private int happiness;
        private int happinessGain;
        private int energy;
        private int defense;

        private int skillPoin; // sama kayak di hsr, buat njalanin skillnya

        private int levelPoin; // buat nambah stat dari level up

        private int fill;
        private int maxFill; // batas kekenyangannya

        private Toy toy;
        private Player owner;
        #endregion

        #region Constructors
        public Pet(string inName, Image inPict, Player inOwner, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense)
        {
            Name = inName;
            Image = inPict;

            Level = 1;
            ExpBar = 100;
            ExpProgress = 0;

            BuffStatus = false;
            StatusDuration = 0;

            MaxHealth = inMaxHealth;
            Health = inMaxHealth;
            Energy = inEnergy;
            MaxHappiness = inMaxHappiness;
            Happiness = 0;
            HappinessGain = 10;
            AtkSpeed = 1;
            Defense = inDefense;

            SkillPoin = 0;

            LevelPoin = 0;

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
        public int Defense { get => defense; set => defense = value; }
        public int LevelPoin { get => levelPoin; set => levelPoin = value; }
        public int HappinessGain { get => happinessGain; set => happinessGain = value; }
        public int SkillPoin { get => skillPoin; set { if (value > 3) { skillPoin = 3; } else { skillPoin = value; } } }

        public bool BuffStatus { get => buffStatus; set => buffStatus = value; }
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
                Health = MaxHealth;
                Happiness = MaxHappiness;

                LevelPoin += 1;
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
                   "\nDefense: " + Defense +
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
            //ngapus efek toy lama
            this.MaxHealth -= Toy.BonusHealth;
            this.Energy -= Toy.BonusEnergy;
            this.AtkSpeed -= Toy.AtkSpeedMultiplier - 1;
            //ngasih efek toy baru
            this.Toy = equipment;
            this.MaxHealth += equipment.BonusHealth;
            this.Energy += equipment.BonusEnergy;
            this.AtkSpeed += equipment.AtkSpeedMultiplier-1;
        }

        public void basicAttack(Enemy target)
        {
            target.Health -= Energy;
            SkillPoin = SkillPoin + 1; // nggak pakai += biar pengecekan properties nya jalan
            this.Happiness += HappinessGain + toy.HappinessGain;
        }
        public abstract void Skill(Enemy target);
        public abstract void Ultimate(Enemy target);

        public virtual void buffRemover() { }

        public void MaxHealthUp() 
        {
            if (LevelPoin > 0) { MaxHealth += 100; LevelPoin -= 1; }
            else { throw new Exception("Level Poin isn't enough"); }
        }
        public void EnergyUp()
        {
            if (LevelPoin > 0) { Energy += 10; LevelPoin -= 1; }
            else { throw new Exception("Level Poin isn't enough"); }
        }
        public void defenseUp()
        {
            if (LevelPoin > 0) { Defense += 10; LevelPoin -= 1; }
            else { throw new Exception("Level Poin isn't enough"); }
        }
        public void HappinessGainUp()
        {
            if (LevelPoin > 0) { HappinessGain += 1; LevelPoin -= 1; }
            else { throw new Exception("Level Poin isn't enough"); }
        }
        public void AtkSpeedUp()
        {
            if (LevelPoin > 0) { AtkSpeed += 0.05; LevelPoin -= 1; }
            else { throw new Exception("Level Poin isn't enough"); }
        }
        #endregion
    }
}