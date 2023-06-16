using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projectUAS
{
    public class fish : pet
    {
        #region dataMember
        private bool envStatus;

        public fish(System.Boolean envStatus)
        {
            EnvStatus = envStatus;
        }

        public global::System.Boolean EnvStatus { get => envStatus; set => envStatus = value; }
        #endregion

        #region method
        public override string DisplayData()
        {
            return base.DisplayData()+"\nEnvirment :"+this.envStatus ;
        }

        public override void Feed()
        {
            base.Health += 20;
            base.Energy += 40;
            base.Owner.Coins += (int)(0.5*20*100);
            base.Owner.Coins += (int)(0.5 * 40 * 100);
        }

        public void Clean()
        {
            if(base.Owner.Coins >= 500)
            {
                base.Health += 60;
                base.Happiness += 50;
                base.Owner.Coins -= 500;
                base.Owner.Coins += (int)(0.5 * 60 * 100);
                base.Owner.Coins += (int)(0.5 * 50 * 100);
            }
            else { throw new Exception("Not Enough coins.\nClean = 500 Coins"); }
        }
        #endregion
    }
}
