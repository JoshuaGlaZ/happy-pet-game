using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectUAS
{
    public class cat : pet
    {
        #region dataMember
        private bool vaccStatus;
        #endregion

        #region constructor
        public cat(string name, Image image, player owner):base(name,image,owner)
        {
            VaccStatus = false;
        }
        #endregion

        #region property
        public bool VaccStatus { get => vaccStatus; set => vaccStatus = value; }
        #endregion

        #region method
        public override string DisplayData()
        {
            string condition;
            if (VaccStatus) { condition = "true"; }
            else { condition = "false"; }
            return base.ToString() + 
                   "\nVaccine Status : " + condition;
        }

        public void Play()
        {
            base.Happiness += 50;
            base.Energy -= 30;
            base.Owner.Coins += (int)(0.5*50*100);
        }

        public void Sleep()
        {
            base.Happiness += 20;
            base.Energy += 70;
            base.Owner.Coins += (int)(0.5 * 20 * 100);
            base.Owner.Coins += (int)(0.5 * 70 * 100);
        }

        public void Bath()
        {
            base.Health += 30;
            base.Owner.Coins += (int)(0.5 * 30 * 100);
        }
        #endregion
    }
}
