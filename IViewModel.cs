using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dracak
{
    public interface IViewModel
    {
        void HandleKeyPress(Key key);
        void Update();
    }
}
