using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_pet_game_2019
{
    public class EnemyPhysical : Enemy
    {
        #region data member
        #endregion

        #region constructor
        public EnemyPhysical(string inName, Image inIdle, Image inHurt, Image inDeath, Image inAttack, int inHealth, int inEnergy, double inAtkSpeed, int inMaxRage, int level) : 
            base(inName, inIdle, inHurt, inDeath, inAttack, inHealth, inEnergy, inAtkSpeed, inMaxRage, level)
        {

        }
        #endregion

        #region property
        #endregion

        #region method
        public override void attack(Pet target)
        {
            base.attack(target);
        }
        public override void specialAttack(Pet target)
        {
            base.specialAttack(target);
        }
        #endregion
    }
}
