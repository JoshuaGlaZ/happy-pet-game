using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projectUAS
{
    public class toy
    {
        #region dataMember
        private string name;
        private string benefit;
        private Image image;
        private int price;
        #endregion

        #region constructor
        public toy(global::System.String name, global::System.String benefit, Image image, global::System.Int32 price)
        {
            Name = name;
            Benefit = benefit;
            Image = image;
            Price = price;
        }
        #endregion

        #region property
        public string Name { get => name; set => name = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public Image Image { get => image; set => image = value; }
        public int Price { get => price; set => price = value; }
        #endregion

        #region method
        public string DisplayDate()
        {
            return this.Name +"\n"+
                   this.Price+"\n"+
                   this.Benefit+"%";
        }
        #endregion
    }
}
