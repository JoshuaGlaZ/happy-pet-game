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
        private List<Consumable> consumablesList = new List<Consumable>();

        public Player(string name, DateTime lastplay)
        {
            Name = name;
            Coins = 0;
            Lastplay = lastplay;
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
                toyList.Add(NewToy); 
                Coins -= NewToy.Price; 
            }
            else { throw new Exception("Not enough coins.\nPrice = " + NewToy.Price); }
        }

        public void feed(Pet pet, Consumable food)
        {
            pet.Feed(food);
            consumablesList.Remove(food);
        }
        #endregion
    }
}