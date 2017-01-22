using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Dracak
{
    class MainVM : IViewModel
    {
        public IViewModel ViewModel { get; set; }

        public MainVM()
        {
            ViewModel = new Map.MapVM();
            //Event Rendering je volán před vykreslením každého snímku
            CompositionTarget.Rendering += (o, e) => Update();
        }

        public void HandleKeyPress(Key key)
        {
            ViewModel.HandleKeyPress(key);
        }

        public void Update()
        {
            ViewModel.Update();
        }
    }
}
