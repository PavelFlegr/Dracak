using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Dracak
{
    class MsgQueue
    {
        public static ConcurrentQueue<IMessage> Messages { get; set; } = new ConcurrentQueue<IMessage>();
    }
}
