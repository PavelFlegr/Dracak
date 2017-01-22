using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace Dracak.Map
{
    class GameObject : INotifyPropertyChanged
    {
        public Collider Collider { get; set; }
        int _x;
        public int X
        {
            get { return _x; }
            set
            {
                GameObject collision = Collider?.CheckCollision(value, Y);
                if (collision == null)
                {
                    _x = value;
                    OnPropertyChanged("X");
                }
                else OnCollision(collision);
            }
        }

        int _y;
        public int Y
        {
            get { return _y; }
            set
            {
                GameObject collision = Collider?.CheckCollision(X, value);
                if (collision == null)
                {
                    _y = value;
                    OnPropertyChanged("Y");
                }
                else OnCollision(collision);
            }
        }

        string _sprite;
        public string Sprite
        {
            get { return _sprite; }
            set
            {
                _sprite = value;
                OnPropertyChanged("Sprite");
            }
        }

        public virtual void Update()
        {
            
        }

        public virtual void OnCollision(GameObject gameObject)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
