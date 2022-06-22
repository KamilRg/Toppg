using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOPBF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "Boss Fight";
           
            Menu.Logo();
            Menu.startMenu();
            Player player = new Player();
            //WriteLine(player.Hp);
            
          /* Choices choices = new Choices();
           choices.Att();*/




            ASCII ascii = new ASCII();
            ascii.Hero();
            WriteLine(player.Name);
            ResetColor();
           
          
            ReadKey();
            Clear();
            


        }
    }
}
