using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    public class Player : Entity
    {
        public override string Name
        {
            get { return "Player"; }
        }

        public Menu Menu { get; set; } = new Menu();

        public override void Attack(IEntity target)
        {
            Menu.Execute(this, target);
            Attacked?.Invoke(this, EventArgs.Empty);
        }

        public override void DoDamage(int damage)
        {
            Life -= damage - Defense;
        }

        public void LevelUp()
        {
            Damage += 1;
            Defense += 2;
            MaxLife += 10;
            Life = MaxLife;
            Level += 1;
        }

        public event EventHandler Attacked;
    }
}
