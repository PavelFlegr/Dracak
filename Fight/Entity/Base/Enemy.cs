using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    public abstract class Enemy : Entity
    {
        //Vytvoří novou instanci daného nepřítele se staty podle vybraného levelu
        public abstract Enemy GetInstance(int level);
    }
}
