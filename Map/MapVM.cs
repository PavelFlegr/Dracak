using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Dracak.Map
{
    class MapVM : IViewModel
    {
        public ObservableCollection<GameObject> GameObjects { get; set; } = new ObservableCollection<GameObject>(); 
        public string Root
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
        public void HandleKeyPress(Key key)
        {
            
        }

        public MapVM()
        {
            GameObject temp = new Player { Sprite = "/square.png" };
            temp.Collider = new Collider(50, 50, temp);
            GameObjects.Add(temp);
            temp = new Enemy { Sprite = "/square.png", X = 100, Y = 100 };
            temp.Collider = new Collider(50, 50, temp);
            GameObjects.Add(temp);
        }

        public void Update()
        {
            foreach (GameObject o in GameObjects)
                o.Update();   
        }
    }
}
