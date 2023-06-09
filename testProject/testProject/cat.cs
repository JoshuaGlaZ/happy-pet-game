using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject
{
    public class cat : unit
    {
        public cat(string name, int health=100, int energy=0, int attack=200, int defense=100, int level=1) : base(name, health, energy, attack, defense, level)
        {

        }

        public override void basic(unit target)
        {
            base.basic(target);
            this.Health += (int)((this.Attack-target.Defense)*(0.1));
            this.Energy += 10;
        }
        public override void skill()
        {
            this.Attack += (int)(this.Attack * 0.25);
            this.Health -= (int)(this.Health * 0.2);
        }
        public override void ulti(unit target)
        {
            if(this.Energy >= 100)
            {
                target.Health -= (int)(this.Attack * 1.5);
                this.Energy -= 100;
            }
            else { throw new Exception("energy gak cukup"); }
        }
    }
}
