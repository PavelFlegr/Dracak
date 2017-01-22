using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Fight
{
    //Uchovává seznam útoků a jejich výběr
    public class Menu
    {
        int i;
        public List<MenuItem> Attacks { get; set; } = new List<MenuItem>
        {
            new MenuItem{ Attack = new Attack(), Selected = true },
            new MenuItem{ Attack = new Bash(), Selected = false },
            new MenuItem{Attack = new ArmorBreak(), Selected = false}, 
            new MenuItem {Attack = new Overpower(), Selected = false }
        };
        public void Up()
        {
            Attacks[i].Selected = false;
            if (i > 0) i--;
            Attacks[i].Selected = true;
        }

        public void Down()
        {
            Attacks[i].Selected = false;
            if (i < Attacks.Count-1) i++;
            Attacks[i].Selected = true;
        }

        public void Execute(IEntity attacker, IEntity target)
        {
            Attacks[i].Attack.Attack(attacker, target);
        }
    }
}
