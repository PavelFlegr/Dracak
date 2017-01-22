using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    class Bash : IAttack
    {
        public string Name
        {
            get { return "Bash"; }
        }

        public void Attack(IEntity attacker, IEntity target)
        {
            target.DoDamage(80);
        }
    }
}
