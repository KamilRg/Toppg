using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOPBF
{
    internal class City1
    {
        
        public void InCity()
        {
            ASCII ascii = new ASCII();
            int userInput = Int32.Parse(ReadLine());

            if (userInput == 1)
            {
                WriteLine("Blacksmith is currently closed");
                ReadKey();
                Clear();
                
                ascii.City();
                
                InCity();
            }

            if (userInput == 2)
            {

                Clear();
                ascii.MerchantShop();
                WriteLine("Merchant is currently closed");
                ReadKey();
                Clear();
                ascii.City();

                InCity();
            }
            if (userInput == 3)
            {
                WriteLine("You are leaving 'City'");
                ReadKey();
                Clear();
                
                ascii.Forest();
                WriteLine("Waling in to the forest");
                ReadKey();
                Clear();
                InForest();

            }
        }

        public void InForest()
        {
                WriteLine("Go to the caslte Press 1\nGo back to the City Press 2 ");
            int userInput = Int32.Parse(ReadLine());

               
            if (userInput == 1)
            {
                ASCII ascii = new ASCII();
                ascii.Castle();
                if (userInput == 1)
                {

                    ReadKey();
                    Clear();
                    WriteLine("Enemy aproach!");
                    ascii.EnemyKnight();
                    
                }


            }
              /*  if (userInput == 2)
                {
                    InCity();
                }*/

          
        }
    }
}
