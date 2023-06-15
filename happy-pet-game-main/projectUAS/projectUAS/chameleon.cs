using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projectUAS
{
    public class chameleon : pet
    {
        #region dataMember
        private Color currentColor;
        #endregion

        #region constructor
        public chameleon(string inName, Image inPict, player inOwner, Color currentColor):base(inName,inPict,inOwner)
        {
            CurrentColor = currentColor;
        }
        #endregion

        #region property
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion

        #region method
        public override global::System.String DisplayData()
        {
            return base.DisplayData()+
                   "\nCurrent color :"+this.CurrentColor+"\n";
        }

        public void changeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }

        public void sleep()
        {
            base.Health += 60;
            base.Energy += 60;
            base.Owner.Coins += (int)(0.5 * 60 * 100);
            base.Owner.Coins += (int)(0.5 * 60 * 100);
        }
        #endregion
    }
}
