using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    [Serializable]
    public class Chamaleon : Pet
    {
        #region DataMembers
        private Color currentColor;
        #endregion

        #region Constructors
        public Chamaleon(string inName, string inTrait, Image inIdle, Image inHurt, Image inDeath, Image inBasic, Image inSkill, Image inUlti, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense) : base(inName, inTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, inMaxHealth, inMaxHappiness, inEnergy, inDefense)
        {
            CurrentColor = Color.Green;
        }
        #endregion

        #region Properties
        public Color CurrentColor 
        { 
            get => currentColor;
            set
            {
                if (value == Color.Blue || value == Color.Green || value == Color.Red || value == Color.Yellow)
                {
                    currentColor = value;
                }
                else
                {
                    throw new Exception("Chameleon only has green, blue, red, and yellow color");
                }
            }
        }
        #endregion 

        #region Methods
        public override string DisplayData()
        {
            return base.DisplayData() + "\nCurrent color :" + this.CurrentColor + "\n";
        }

        Random random = new Random();
        int tipe;
        public override void Skill(Enemy target)
        {
            if (SkillPoin > 0)
            {
                this.buffRemover(target);
                tipe = random.Next(1, 3);
                if (tipe == 1) { CurrentColor = Color.Red; Energy += Energy/2; }
                else if (tipe == 2) { CurrentColor = Color.Blue; Defense = Defense * 2; }
                else { CurrentColor = Color.Yellow; AtkSpeed = AtkSpeed * 1.5; }
                StatusDuration = 3;
            }
            else { throw new Exception("skill point isn't enough"); }
        }
        public override void Ultimate(Enemy target)
        {
            if (base.Happiness == base.MaxHappiness)
            {
                target.StatusDuration = 0;
                CurrentColor = Color.White;
                Energy += Energy / 2;
                Defense = Defense*2;
                AtkSpeed = AtkSpeed * 1.5;
                StatusDuration = 3;
            }
            else { throw new Exception("ultimate not ready"); }
        }
        public override void buffRemover(Enemy enemy)
        {       
            if (CurrentColor == Color.Red)
            {
                if (enemy.StatusDuration > 0 && enemy is EnemyDebuffer) { Energy = OriginalEnergy - enemy.getDebuffEffect(); }
                else { Energy = OriginalEnergy; }
            }
            else if (CurrentColor == Color.Blue) { Defense = Defense/2; }
            else if (CurrentColor == Color.Yellow) { AtkSpeed = AtkSpeed / 1.5; }

            else if (CurrentColor == Color.White)
            {
                if(enemy.StatusDuration > 0 && enemy is EnemyDebuffer) { Energy = OriginalEnergy - enemy.getDebuffEffect(); }
                else { Energy = OriginalEnergy; }
                Defense = Defense/2;
                AtkSpeed = AtkSpeed / 1.5;
            }
            CurrentColor = Color.Green;
        }

        public override string GetColor()
        {
            if(CurrentColor == Color.White) { return "white"; }
            else { return "not white"; }
        }
        #endregion
    }
}