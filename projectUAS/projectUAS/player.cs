using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectUAS
{
    public class player
    {
        private string name;
        private int coins;
        private DateTime lastplay;
        private List<toy> toyList = new List<toy>();

        public player(string inName)
        {
            Name = inName;
            Coins = 100;
            Lastplay = DateTime.Now;
        }

        public string Name { get => name; set { if (value == "") { throw new Exception("nama tidak boleh kosong"); } else { name = value; } } }
        public int Coins { get => coins; set => coins = value; }
        public DateTime Lastplay { get => lastplay; set => lastplay = value; }

        public void BuyToy(toy NewToy)
        {
            if(this.Coins >= NewToy.Price) { toyList.Add(NewToy);Coins -= NewToy.Price; }
            else {  throw new Exception("uang tidak cukup"); }
        }
    }
}
