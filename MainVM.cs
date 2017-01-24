using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.ComponentModel;

namespace Dracak
{
    class MainVM : IViewModel, INotifyPropertyChanged
    {
        IViewModel _viewModel;
        public IViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ViewModel"));
            }
        }
        Fight.Player player = new Fight.Player { Damage = 10, Defense = 2, Level = 1, Life = 100, MaxLife = 100, Menu = new Fight.Menu() };
        Map.MapVM map = new Map.MapVM();

        public event PropertyChangedEventHandler PropertyChanged;

        public MainVM()
        {
            ViewModel = map;
            //Event Rendering je volán před vykreslením každého snímku
            CompositionTarget.Rendering += (o, e) => Update();
        }

        public void Fight()
        {
            ViewModel = new Fight.FightVM(player);
        }

        public void Map()
        {
            ViewModel = map;
        }

        public void HandleKeyPress(Key key)
        {
            ViewModel.HandleKeyPress(key);
        }

        public void Update()
        {
            ViewModel.Update();
            CheckMsgQueue();
        }

        void CheckMsgQueue()
        {
            IMessage m;
            while(MsgQueue.Messages.TryDequeue(out m))
            {
                m.Execute(this);
            }
        }
    }
}
