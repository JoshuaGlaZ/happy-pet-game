using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace projectUAS
{
    public class pet
    {
        #region dataMember
        private string name;
        private Image image;

        private int health;
        private int happiness;
        private int energy;

        private toy toy;
        private player owner;
        #endregion

        #region constructor
        public pet(string inName, Image inPict, player inOwner)
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

        public string Name { get => name; set { if (value == "") { throw new Exception("Nama tidak boleh kosong"); } else { name = value; } } }
        public Image Image { get => image; set => image = value; }
        public int Health { get => health; set { if (value >= 10 && value <= 100) { health = value; } else if (value < 10) { value = 10; } else { value = 100; } } }
        public int Happiness { get => happiness; set { if (value >= 10 && value <= 100) { happiness = value; } else if (value < 10) { value = 10; } else { value = 100; } } }
        public int Energy { get => energy; set { if (value >= 10 && value <= 100) { energy = value; } else if (value < 10) { value = 10; } else { value = 100; } } }
        public toy Toy { get => toy; set => toy = value; }
        public player Owner { get => owner; set => owner = value; }

        #region method
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
            string condition = "";
            if (this.Health > 80) { condition = "very good"; }
            else if (this.Health >= 61) { condition = "good";  }
            else if (this.Health >= 26) { condition = "poor"; }
            else { condition = "very poor"; }
            return condition;
        }

        public string GetEnergyCondition()
        {
            string condition = "";
            if(this.Energy > 76) { condition = "strong"; }
            else if(this.Energy >= 51) { condition = "moderate"; }
            else { condition = "weak"; }
            return condition;
        }

        public string GetHappinessCondition()
        {
            if (this.Happiness > 60) { return "happy"; }
            else { return "unhappy"; }
        }

        public void getToy()
        {

        }
        #endregion
    }
}
