using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    public class Player
    {
        private string name;
        private int coins;
        private DateTime lastplay;
        private List<Toy> toyList = new List<Toy>();

        public Player(string name, int coins, DateTime lastplay, List<Toy> toyList)
        {
            Name = name;
            Coins = coins;
            Lastplay = lastplay;
            ToyList = toyList;
        }

        public string Name 
        {
            get => name;
            set
            {
                if (value == "")
                {
                    throw new Exception("Name cannot be empty");
                }
                else { name = value; }
            }
        }
        public int Coins 
        {
            get => coins; set => coins = value; 
        }
        public DateTime Lastplay 
        {
            get => lastplay; set => lastplay = value; 
        }
        public List<Toy> ToyList 
        {
            get => toyList; set => toyList = value; 
        }

        #region Methods
        public void BuyToy(Toy NewToy)
        {
            if (this.Coins >= NewToy.Price) 
            {
                toyList.Add(NewToy); Coins -= NewToy.Price; 
            }
            else { throw new Exception("Not enough coins.\nPrice = " + NewToy.Price); }
        }
        #endregion
    }
}