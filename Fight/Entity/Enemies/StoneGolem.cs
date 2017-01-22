using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    public class StoneGolem : Enemy
    {
        public override string Name
        {
            get { return "Stone Golem"; }
        }

        public override void Attack(IEntity target)
        {
            target.DoDamage(Damage);
        }

        
        public override void DoDamage(int damage)
        {
            Life -= (damage - Defense) / 2;            
        }
       
        public override Enemy GetInstance(int level)
        {
            return new StoneGolem { Damage = 5 * (level + 1), Defense = 4 + level, Level = level, Life = 30 + level * 5, MaxLife = 30 + level * 5 };
        }
    }
}
