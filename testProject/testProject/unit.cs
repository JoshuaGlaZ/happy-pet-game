using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject
{
    public class unit
    {
        private string name;
        private int health;
        private int energy;
        private int attack;
        private int defense;
        private int level;

        public unit(string name, int health, int energy, int attack, int defense, int level)
        {
            Name = name;
            Health = health;
            Energy = energy;
            Attack = attack;
            Defense = defense;
            Level = level;
        }

        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Energy { get => energy; set => energy = value; }
        public int Attack { get => this.attack; set => this.attack = value; }
        public int Defense { get => this.defense; set => this.defense = value; }
        public int Level { get => level; set => level = value; }

        public virtual void basic(unit target) 
        { 
            target.Health -= (this.Attack-target.Defense);
        }

        public virtual void skill() { }
        public virtual void ulti(unit target) { }

        public virtual string display()
        {
            return "Name : " + Name +
                   "\nLevel :" + Level;
        } 

        public void levelUp()
        {
            this.Level  += 1;
            this.Health += 10;
            this.Attack += 10;
            this.Energy += 10;
        }
    }
}
