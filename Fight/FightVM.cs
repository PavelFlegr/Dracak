using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace Dracak.Fight
{
    class FightVM : IViewModel, INotifyPropertyChanged
    {
        bool end;
        public Player Player { get; set; }
        public IEntity Enemy { get; set; }
        List<Enemy> enemyTypes = new List<Enemy> { new Berserker(), new StoneGolem() };
        Random rnd = new Random();

        public event PropertyChangedEventHandler PropertyChanged;

        public FightVM(Player player)
        {
            //začne souboj s náhodným nepřítelem s úrovní hráče
            Player = player;
            Enemy = new Berserker().GetInstance(1);
            OnPropertyChanged("Enemy");
            //Enemy = enemyTypes[rnd.Next(0, enemyTypes.Count - 1)].GetInstance(player.Level);
        }

        public void HandleKeyPress(Key key)
        {
            if (!end)
            {
                switch (key)
                {
                    case Key.Enter:
                        HandleTurn();
                        break;
                    case Key.Up:
                        Player.Menu.Up();
                        break;
                    case Key.Down:
                        Player.Menu.Down();
                        break;
                }
            }
        }

        void HandleTurn()
        {
            Player.Attack(Enemy);
            if(CheckDeath(Enemy))
            {
                Player.LevelUp();
                EndFight();
                return;
            }

            Enemy.Attack(Player);
            if(CheckDeath(Player))
            {
                Player.Life = Player.MaxLife;
                EndFight();
                return;
            }
        }

        bool CheckDeath(IEntity entity)
        {
            return entity.Life <= 0;
        }

        void EndFight()
        {
            end = true;
            MsgQueue.Messages.Enqueue(new MapMessage());
        }

        public void Update()
        {
            
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
