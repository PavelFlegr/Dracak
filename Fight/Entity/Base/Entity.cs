using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dracak.Fight
{
    //defaultní chování
    public abstract class Entity : IEntity, INotifyPropertyChanged
    {
        public int Damage { get; set; }

        public int Defense { get; set; }

        int _level;
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }

        int _life;
        public int Life
        {
            get { return _life; }
            set
            {
                _life = value;
                OnPropertyChanged("Life");
            }
        }

        public int MaxLife { get; set; }

        public abstract string Name { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void Attack(IEntity target)
        {
            target.DoDamage(Damage);
        }

        public virtual void DoDamage(int damage)
        {
            Life -= damage - Defense;           
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
