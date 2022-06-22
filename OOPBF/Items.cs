using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOPBF
{
    internal class Items : ASCII
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public bool EquipSword { get; set; }
        public Items()
        {

        }
        
       
            
   

        public void Equip()
        {
            int UserActions = Int32.Parse(ReadLine());
            if (UserActions == 1)
            {
                EquipSword = true;
                Name = "Cool looking sword";
                Descriptions = "Looking sharp +5 dmg";
                ASCII ascii = new ASCII();
                ascii.Sword();
                WriteLine("You equiped {0} and its {1}", Name,Descriptions);
            }
        }
    }
}
