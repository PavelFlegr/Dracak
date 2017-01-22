using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    public interface IEntity
    {
        string Name { get; }
        int Life { get; set; }
        int MaxLife { get; set; }
        int Damage { get; set; }
        int Defense { get; set; }
        int Level { get; set; }

        //Voláno při obraně
        void DoDamage(int damage);

        void Attack(IEntity target);
    }
}
