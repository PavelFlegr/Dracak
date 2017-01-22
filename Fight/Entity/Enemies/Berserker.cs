using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    class Berserker : Enemy
    {
        public override string Name { get
            {
                return "Berserker";
            } }
        public override void Attack(IEntity target)
        {
            target.DoDamage(Damage);
        }

        public override void DoDamage(int damage)
        {
            Life -= damage;
        }

        public override Enemy GetInstance(int level)
        {
            return new Berserker { Damage = 10 * level, Defense = 0, Level = level, Life = 100 + level * 10, MaxLife = 100 + level * 10 };
        }
    }
}
