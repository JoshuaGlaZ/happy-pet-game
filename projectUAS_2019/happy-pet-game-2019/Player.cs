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

        public Player(string name)
        {
            Name = name;
            Coins = 0;
            Lastplay = DateTime.Now;
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
        public void BuyToy(string name, Image inPicture, int price, int inBonusHealth, int inBonusEnergy, int inHappinessGain, double inAtkSpeedMultiplier)
        {
            if (this.Coins >= price) 
            {
                Toy NewToy = new Toy(name, inPicture, price, inBonusHealth, inBonusEnergy, inHappinessGain, inAtkSpeedMultiplier);
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
        public void BuyConsumable(string name, Image inPicture, int price, int healthBonus, int enerygBonus, int happinessBonus, int fullness)
        {
            if (this.Coins >= price)
            {
                Consumable NewConsumable = new Consumable(name, inPicture, price, healthBonus, enerygBonus, happinessBonus, fullness);
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
        public void AddPetFish(string inName, string inTrait, Image inIdle, Image inHurt, Image inDeath, Image inBasic, Image inSkill, Image inUlti, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense)
        {
            Fish newFish = new Fish(inName, inTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, inMaxHealth, inMaxHappiness, inEnergy, inDefense);
            ChoosenPet = newFish;
        }
        public void AddPetCat(string inName, string inTrait, Image inIdle, Image inHurt, Image inDeath, Image inBasic, Image inSkill, Image inUlti, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense)
        {
            Cat newCat = new Cat(inName, inTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, inMaxHealth, inMaxHappiness, inEnergy, inDefense);
            ChoosenPet = newCat;
        }
        public void AddPetChamaleon(string inName, string inTrait, Image inIdle, Image inHurt, Image inDeath, Image inBasic, Image inSkill, Image inUlti, int inMaxHealth, int inMaxHappiness, int inEnergy, int inDefense)
        {
            Chamaleon newChamaleon = new Chamaleon(inName, inTrait, inIdle, inHurt, inDeath, inBasic, inSkill, inUlti, inMaxHealth, inMaxHappiness, inEnergy, inDefense);
            ChoosenPet = newChamaleon;
        }
        public string DisplayPetStat()
        {
            string stat = "";
            if (ChoosenPet is Cat)
            {
                stat += "CAT" + "\n" + ChoosenPet.DisplayData();
            }
            else if (ChoosenPet is Fish)
            {
                stat += "FISH" + "\n" + ChoosenPet.DisplayData();
            }
            else if (ChoosenPet is Chamaleon)
            {
                stat += "CHAMALEON" + "\n" + ChoosenPet.DisplayData();
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

        public void Feed(Pet pet, Consumable food)
        {
            pet.Feed(food);
            consumableList.Remove(food);
        }
        public void GetToy(Toy equipment)
        {
            //ngapus efek toy lama
            ChoosenPet.MaxHealth -= ChoosenPet.Toy.BonusHealth;
            ChoosenPet.OriginalEnergy -= ChoosenPet.Toy.BonusEnergy;
            ChoosenPet.AtkSpeed -= ChoosenPet.Toy.AtkSpeedMultiplier;
            //ngasih efek toy baru
            ChoosenPet.Toy = equipment;
            ChoosenPet.MaxHealth += equipment.BonusHealth;
            ChoosenPet.OriginalEnergy += equipment.BonusEnergy;
            ChoosenPet.AtkSpeed += equipment.AtkSpeedMultiplier;
        }
        #endregion
    }
}