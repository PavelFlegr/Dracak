using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    class ArmorBreak : IAttack
    {
        public string Name { get { return "Armor Break"; } }

        public void Attack(IEntity attacker, IEntity target)
        {
            target.Life -= attacker.Damage - 5;
        }
    }
}
