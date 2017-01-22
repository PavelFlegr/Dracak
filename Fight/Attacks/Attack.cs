using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    class Attack : IAttack
    { 
        public string Name { get { return "Attack"; } }
        void IAttack.Attack(IEntity attacker, IEntity target)
        {
            target.DoDamage(attacker.Damage);
        }
    }
}
