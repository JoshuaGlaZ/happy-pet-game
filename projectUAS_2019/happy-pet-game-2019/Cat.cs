using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    public class Cat : Pet
    {
        #region DataMembers
        private bool vaccStatus;
        #endregion

        #region Constructors
        public Cat(string inName, Image inPict, Player inOwner, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense) : base(inName, inPict, inOwner,inMaxHealth,inMaxHappiness,inEnergy, inDefense)
        {
            VaccStatus = false;
        }
        #endregion

        #region Properties
        public bool VaccStatus { get => vaccStatus; set => vaccStatus = value; }
        #endregion

        #region Methods
        public override string DisplayData()
        {
            string condition = VaccStatus ? "True" : "False"; //if (VaccStatus) { condition = "True"; } else { condition = "False"; }
            return base.DisplayData() + "\nVaccine Status : " + condition;
        }

        public void Play()
        {
            base.Happiness += (int)(base.MaxHappiness/2);
        } 
        public void Sleep()
        {
            base.Happiness = base.MaxHappiness;
            base.Health = base.MaxHealth;
        } 
        public void Bath()
        {
            base.Health = base.MaxHealth;
        }

        public void Vaccinate()
        {
            if (VaccStatus)  { throw new Exception("already vaccinated"); }
            else if (base.Owner.Coins < 1000) { throw new Exception("not enough coins.\nVaccinate = 1000Coins"); }
            else{ base.Owner.Coins -= 1000; }
        }

        public override void Skill(Enemy target)
        {
            if (SkillPoin > 0)
            {
                if (BuffStatus) { buffRemover(); }
                Energy = (int)(Energy * 1.5);
                StatusDuration = 3;
                if (VaccStatus == false) { Health -= (int)(0.05 * Health); }
                Happiness = Happiness + HappinessGain;
                BuffStatus = true;
                SkillPoin -= 1;
            }
            else { throw new Exception("skill point isn't enough"); }
        }
        public override void Ultimate(Enemy target)
        {
            if(base.Happiness == base.MaxHappiness)
            {
                target.Health -= this.Energy * 4;
                this.Happiness = 0;
                if (this.VaccStatus) { base.Health += (int)(MaxHealth / 5); }
            }
            else { throw new Exception("Ultimate not ready"); }
        }

        public override void buffRemover()
        {
            Energy = (int)(Math.Ceiling(Energy/1.5));
            BuffStatus = false;
        }
        #endregion
    }
}