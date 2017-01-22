using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    class Overpower : IAttack
    {
        public string Name
        {
            get
            {
                return "Overpower";
            }
        }

        public void Attack(IEntity attacker, IEntity target)
        {
            target.DoDamage(attacker.Damage /2+ target.Damage);
        }
    }
}
