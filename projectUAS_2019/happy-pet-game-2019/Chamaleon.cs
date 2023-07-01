using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    public class Chamaleon : Pet
    {
        #region DataMembers
        private Color currentColor;
        #endregion

        #region Constructors
        public Chamaleon(string inName, Image inPict, Player inOwner, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense) : base(inName, inPict, inOwner, inMaxHealth, inMaxHappiness, inEnergy, inDefense)
        {
            CurrentColor = Color.Green;
        }
        #endregion

        #region Properties
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion 

        #region Methods
        public override string DisplayData()
        {
            return base.DisplayData() + "\nCurrent color :" + this.CurrentColor + "\n";
        }

        public void Sleep()
        {
            base.Happiness = base.MaxHappiness;
            base.Health = base.MaxHealth;
        }

        Random random = new Random();
        int tipe;
        public override void Skill(Enemy target)
        {
            if (SkillPoin > 0)
            {
                if (BuffStatus) { buffRemover(); }
                tipe = random.Next(1, 3);
                if (tipe == 1) { CurrentColor = Color.Red; Energy = (int)(Energy * 1.25); }
                else if (tipe == 2) { CurrentColor = Color.Blue; Defense = (int)(Defense * 1.2); }
                else { CurrentColor = Color.Yellow; AtkSpeed = AtkSpeed * 1.5; }
                BuffStatus = true;
                StatusDuration = 3;
            }
            else { throw new Exception("skill point isn't enough"); }
        }
        public override void Ultimate(Enemy target)
        {
            if (base.Happiness == base.MaxHappiness)
            {
                CurrentColor = Color.White;
                Energy = (int)(Energy * 1.25);
                Defense = (int)(Defense * 1.2);
                AtkSpeed = AtkSpeed * 1.5;
                this.Happiness = 0;
            }
            else { throw new Exception("Ultimate not ready"); }
        }

        public override void buffRemover()
        {
            if(CurrentColor == Color.Red) { Energy = (int)(Math.Ceiling(Energy/1.25)); CurrentColor = Color.Green; }
            else if(CurrentColor == Color.Blue) { Defense = (int)(Math.Ceiling(Defense / 1.2)); CurrentColor = Color.Green; }
            else if(CurrentColor == Color.Yellow) { AtkSpeed = AtkSpeed/1.5; CurrentColor = Color.Green; }
            else if(CurrentColor == Color.White)
            {
                Energy = (int)(Math.Ceiling(Energy / 1.25));
                Defense = (int)(Math.Ceiling(Defense / 1.2));
                AtkSpeed = AtkSpeed / 1.5;
                CurrentColor = Color.Green;
            }
            BuffStatus = false;
        }
        #endregion
    }
}