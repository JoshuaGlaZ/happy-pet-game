using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Player(string name, DateTime lastplay, Pet pet )
        {
            Name = name;
            Coins = 0;
            Lastplay = lastplay;
            ToyList = new List<Toy>();
            ConsumableList = new List<Consumable>();
            ChoosenPet = choosenPet;
            //PetList = new List<Pet>();
        }

        public string Name 
        {
            get => name;
            set
            { 
                if (value == "") { throw new Exception("Player name cannot be empty"); }
                else { name = value; }
            }
        }
        public int Coins { get => coins; set => coins = value; }
        public DateTime Lastplay { get => lastplay; set => lastplay = value;  }
        public List<Toy> ToyList  {  get => toyList; private set => toyList = value; }
        public List<Consumable> ConsumableList { get => consumableList; private set => consumableList = value; }
        public Pet ChoosenPet { get => choosenPet; private set => choosenPet = value; }

        //public List<Pet> PetList { get => petList; set => petList = value; }



        #region Methods
        public void BuyToy(string name, string benefit, int price, Image toyPicture)
        {
            if (this.Coins >= price) 
            {
                Toy NewToy = new Toy(name, benefit, price, toyPicture);
                toyList.Add(NewToy); Coins -= NewToy.Price; 
            }
            else { throw new Exception("Not enough coins.\nPrice = " + price); }
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
        public void BuyConsumable(string name, int price, int healthBonus, int enerygBonus, int happinessBonus, Image consumablePicture)
        {
            if (this.Coins >= price)
            {
                Consumable NewConsumable = new Consumable(name, price, healthBonus, enerygBonus, happinessBonus, consumablePicture);
                consumableList.Add(NewConsumable); Coins -= NewConsumable.Price;
            }
            else { throw new Exception("Not enough coins.\nPrice = " + price); }
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
        public void AddPetFish(string name, string trait, Image inPict)
        {
            Fish newFish = new Fish(name, trait, inPict);
            ChoosenPet = newFish;
        }
        public void AddPetCat(string name, string trait, Image inPict)
        {
            Cat newCat = new Cat(name, trait, inPict);
            ChoosenPet = newCat;
        }
        public void AddPetChamaleon(string name, string trait, Image inPict, Color currentColor)
        {
            Chamaleon newChamaleon = new Chamaleon(name, trait, inPict, currentColor);
            ChoosenPet = newChamaleon;
        }
        public string DisplayPetStat()
        {
            string stat = "";
            if (ChoosenPet is Cat)
            {
                stat += "CAT" + "\n" + ChoosenPet.ToString();
            }
            else if (ChoosenPet is Fish)
            {
                stat += "FISH" + "\n" + ChoosenPet.ToString();
            }
            else if (ChoosenPet is Chamaleon)
            {
                stat += "CHAMALEON" + "\n" + ChoosenPet.ToString();
            }
            else
            {
                return "Empty";
            }
            return stat;
        }
        public void RemovePet(/*Pet removedPet*/)
        {
            ChoosenPet = null;
            //PetList.Remove(removedPet)
        }

        public void feed(Pet pet, Consumable food)
        {
            pet.Feed(food);
            consumableList.Remove(food);
        }
        #endregion
    }
}