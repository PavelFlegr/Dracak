using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak
{
    class FightMessage : IMessage
    {
        public void Execute(MainVM vm)
        {
            vm.Fight();
        }
    }
}
