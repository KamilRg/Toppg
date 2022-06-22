using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOPBF
{
    internal class Beginning : Player
    {
        public void Start()
        {
            ASCII ascii = new ASCII();
            ascii.CityGuard();
            WriteLine(@"
                                                                                                                         Hello bladventurer, tell me whats your name?");
            ascii.Hero();
            Name = ReadLine();
            ResetColor();
            Clear();
            ascii.CityGuard();
            WriteLine(@"
                                                                                                                            Welcome to the City {0}",Name);
            ascii.Hero();
            Choices startCity = new Choices();
            ReadKey();
            Clear();
            ascii.City();
            City1 city1 = new City1();
            city1.InCity();
        }
    }
}
