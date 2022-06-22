using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOPBF
{
    internal class Choices : ASCII
    {

        public void Choice()
        {
            int userInput = Int32.Parse(ReadLine());

            if (userInput == 1)
            {
                WriteLine("Fight");
                Actions();
            }

            if (userInput == 2)
            {
                WriteLine("Running");
                Clear();
                InsideCastle();
            }
        }

        public void Actions()
        {
            WriteLine("What to do ");
            int userAction = Int32.Parse(ReadLine());
            if (userAction == 1)
            {
                Att();
            }
            if (userAction == 2)
            {

            }
            if (userAction == 3)
            {

            }
            if (userAction == 4)
            {

            }
        }

        public void Continue1()
        {
            WriteLine("Next turn \nEnter");
            ReadKey();
            Clear();
        }

        public void Att()
        {
            Player player1 = new Player();
            player1.Hp = 10;
            player1.Attack = 10;
            player1.Stamina = 60;
            player1.StaminaCost = 10;
            player1.Attack = 10;
            
            player1.Mana = 50;
            player1.ManaRecovery = 5;
            player1.SpRecovery = 15;
            player1.ManaCost = 25;
            player1.Heal = 15;
            //Enemy

            Enemy enemy = new Enemy();
            enemy.Name = "Ejret";
            enemy.Hp = 120;
            enemy.Stamina = 60;
            enemy.StaminaCost = 0;
            enemy.Attack = 10;
            enemy.SpecialAttack = 25;
            Random rnd = new Random();
            ASCII hero = new ASCII();


            while (player1.Hp > 0 && enemy.Hp > 0)
            {
                hero.Hero();
                hero.EnemyKnight();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Your turn");
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine(@"
                                                                                                  ____________________________________
                                                                                                  | 1 to attack | 3 to recover stamina|
                                                                                                  |-------------|---------------------| 
                                                                                                  | 2 to heal   | 4 to recover mana   | 
                                                                                                   -----------------------------------
                                                                                                             Your HP: {1} 
                                                                                                             Stamina: {0}
                                                                                                             Mana: {2}   ", player1.Stamina,player1.Hp,player1.Mana);
                
                //attack
                int select = Int32.Parse(ReadLine());
                if (select == 1 && player1.Stamina > player1.StaminaCost)
                {
                    enemy.Hp -= player1.Attack;
                    player1.Stamina -= player1.StaminaCost;
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Stamina: {0}\n You HP: {1}", player1.Stamina,player1.Hp);
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("Enemy Hp: {0}",enemy.Hp);
                    Continue1();

                }
                else if (select == 1 && player1.Stamina < player1.StaminaCost || player1.Stamina == 10)
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("Restore your stamina \nStamina: {0}",player1.Stamina);
                    Continue1();
                }
                //heal
                if (select == 2 && player1.Mana >= player1.ManaCost)
                {
                    player1.Hp += player1.Heal;
                    player1.Mana -= player1.ManaCost;
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("You healed yourself for: {0}\n Health: {2}\nMana: {1}",player1.Heal,player1.Mana,player1.Hp);
                    Continue1();

                }
                else if (select == 2 && player1.Mana < player1.ManaCost || player1.Mana == 10)
                {Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    hero.Potion();
                    WriteLine("Restore your mana \nMana: {0}", player1.Mana);
                    Continue1();
                  
                  
                }
                //StaminaRecovery
                if (select == 3)
                {
                    player1.Stamina += player1.SpRecovery;
                    
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Restored: {0}\nStamina: {1}", player1.SpRecovery, player1.Stamina);
                    Continue1();

                }
                //ManaRecovery
                if (select == 4)
                {
                    player1.Mana += player1.ManaRecovery;

                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Restored: {0}\nMana: {1}", player1.ManaRecovery, player1.Mana);
                    Continue1();

                }
                //EnemyTurn
                int enemyTurn = rnd.Next(0, 3);
                if (enemy.Hp > 0)
                {
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("                                                                                                                                                                                 Enemy's turn");
                    
                    if (enemyTurn == 0)
                    {
                        WriteLine("                                                                                                                                                                                 {0} hits you for {1}", enemy.Name,enemy.Attack);
                        player1.Hp -= enemy.Attack;
                        ForegroundColor = ConsoleColor.Red;
                    }
                    else if (enemyTurn == 1)
                    {
                        WriteLine("                                                                                                                                                                                 {0} hits you for {1}", enemy.Name, enemy.SpecialAttack);
                       
                        player1.Hp -= enemy.SpecialAttack;
                        ForegroundColor = ConsoleColor.Red;
                    }
                    else if (enemyTurn == 2)
                    {
                        WriteLine("                                                                                                                                                                                 Enemy missed attack");
                        ForegroundColor = ConsoleColor.Red;
                    }

                    if (player1.Hp <= 0)
                    {
                        ForegroundColor = ConsoleColor.Red;
                        hero.GameOver();
                    }

                }

            }
        }
    }
}
