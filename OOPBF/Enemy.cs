using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOPBF
{
    internal class Enemy : Player
    {
        public Enemy(string name, int hp, int stamina, int mana, int heal, int attack, int specialAttack, int staminaCost, int spRecovery, int manaRecovery) :base(150,120,60,40,25,10,25,20,30,30)
        {
            
        }

        public Enemy()
        {
            
        }
    }
}
