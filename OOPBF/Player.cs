using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOPBF
{
    internal class Player
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Stamina { get; set; }
        public int Mana { get; set; }
        public int Heal { get; set; }
        public int Attack { get; set; }
        public int SpecialAttack { get; set; }
        public int StaminaCost { get; set; }
        public int SpRecovery { get; set; }
        public int ManaRecovery { get; set; }
        public int ManaCost { get; set; }

        public Player(string name, int hp, int stamina, int mana, int heal, int attack, int specialAttack, int staminaCost, int spRecovery, int manaRecovery, int manaCost)
        {
            Name = name;
            Hp = hp;
            Stamina = stamina;
            Mana = mana;
            Heal = heal;
            Attack = attack;
            SpecialAttack = specialAttack;
            StaminaCost = staminaCost;
            SpRecovery = spRecovery;
            ManaRecovery = manaRecovery;
            ManaCost = manaCost;
        }

        public Player(int hp, int stamina, int mana, int heal, int attack, int specialAttack, int staminaCost, int spRecovery, int manaRecovery, int manaCost)
        {
            
        }

        public Player()
        {
            
        }


    }
}
