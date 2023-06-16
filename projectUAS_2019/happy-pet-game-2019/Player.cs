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
        private List<Toy> toyList;
        private List<Consumable> consumableList;
        private List<Pet> petList;

        public Player(string name, int coins, DateTime lastplay, List<Toy> toyList, List<Consumable> consumableList, List<Pet> petList)
        {
            Name = name;
            Coins = coins;
            Lastplay = lastplay;
            ToyList = new List<Toy>();
            ConsumableList = new List<Consumable>();
            PetList = new List<Pet>();
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
        public int Coins { get => coins; set => coins = value; }
        public DateTime Lastplay { get => lastplay; set => lastplay = value;  }
        public List<Toy> ToyList  {  get => toyList; set => toyList = value; }
        public List<Consumable> ConsumableList { get => consumableList; set => consumableList = value; }
        public List<Pet> PetList { get => petList; set => petList = value; }


        #region Methods
        public void BuyToy(Toy NewToy)
        {
            if (this.Coins >= NewToy.Price) 
            {
                toyList.Add(NewToy); Coins -= NewToy.Price; 
            }
            else { throw new Exception("Not enough coins.\nPrice = " + NewToy.Price); }
        }
        public void BuyConsumable(Consumable NewConsumable)
        {
            if (this.Coins >= NewConsumable.Price)
            {
                consumableList.Add(NewConsumable); Coins -= NewConsumable.Price;
            }
            else { throw new Exception("Not enough coins.\nPrice = " + NewConsumable.Price); }
        }
        #endregion
    }
}