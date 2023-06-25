using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace happy_pet_game_2019
{
    [Serializable]
    public class Player
    {
        private string name;
        private int coins;
        private DateTime lastplay;
        private List<Toy> toyList;
        private List<Consumable> consumableList;
        private Pet choosenPet;

        public Player(string name, Pet pet )
        {
            Name = name;
            Coins = 100;
            Lastplay = DateTime.Now;
            ToyList = new List<Toy>();
            ConsumableList = new List<Consumable>();
            ChoosenPet = pet;
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
        public List<Toy> ToyList  {  get => toyList; private set => toyList = value; }
        public List<Consumable> ConsumableList { get => consumableList; private set => consumableList = value; }
        public Pet ChoosenPet { get => choosenPet; set => choosenPet = value; }


        #region Methods
        public void BuyToy(Toy NewToy)
        {
            if (this.Coins >= NewToy.Price) 
            {
                toyList.Add(NewToy); Coins -= NewToy.Price; 
            }
            else { throw new Exception("Not enough coins.\nPrice = " + NewToy.Price); }
        }
        public string DisplayToy()
        {
            string data = "";
            foreach (Toy toyInList in ToyList)
            {
                data += toyInList.ToString();
            }
            return data;
        }
        public void BuyConsumable(Consumable NewConsumable)
        {
            if (this.Coins >= NewConsumable.Price)
            {
                consumableList.Add(NewConsumable); Coins -= NewConsumable.Price;
            }
            else { throw new Exception("Not enough coins.\nPrice = " + NewConsumable.Price); }
        }
        public string DisplayConsumable()
        {
            string data = "";
            foreach (Consumable consumableInList in ConsumableList)
            {
                data += consumableInList.ToString();
            }
            return data;
        }
        public void ChangePet(Pet petToChange)
        {
            this.ChoosenPet = petToChange;
        }
        #endregion
    }
}