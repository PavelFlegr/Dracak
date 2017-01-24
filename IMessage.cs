using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak
{
    interface IMessage
    {
        void Execute(MainVM vm);
    }
}
