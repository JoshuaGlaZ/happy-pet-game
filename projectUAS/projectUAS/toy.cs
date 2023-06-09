using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectUAS
{
    public class toy
    {
        private string name;
        private string benefit;
        private Image image;
        private int price;

        public string Name { get => name; set => name = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public Image Image { get => image; set => image = value; }
        public int Price { get => price; set => price = value; }
    }
}
