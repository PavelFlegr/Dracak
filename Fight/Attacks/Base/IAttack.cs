using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    //Určuje funkci konkrétních útoků
    public interface IAttack
    {
        void Attack(IEntity attacker, IEntity target);
        string Name { get; }
    }
}
