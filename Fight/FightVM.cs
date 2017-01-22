using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dracak.Fight
{
    class FightVM : IViewModel
    {
        public Player Player { get; set; }
        public IEntity Enemy { get; set; }
        Random rnd = new Random();

        public FightVM(Player player, IEntity enemy)
        {
            Player = player;
            Enemy = enemy;
            Player.Attacked += (o, e) => enemy.Attack(Player);
        }

        public void HandleKeyPress(Key key)
        {
            switch (key)
            {
                case Key.Enter:
                    Player.Attack(Enemy);
                    break;
                case Key.Up:
                    Player.Menu.Up();
                    break;
                case Key.Down:
                    Player.Menu.Down();
                    break;
            }
        }

        public void Update()
        {
            
        }
    }
}
