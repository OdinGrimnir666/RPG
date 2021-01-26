using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Man : BassKlass
    {
      
       
        public Man()
        {
           rasa= "Men";
        }
        public Man(string name, int lvl, int power, int xp, int domag, int armour, int money, int speedAtak, int magArmour) 
            : base(name,lvl,power, xp, domag, armour,  money, speedAtak,magArmour)
        {


        }



    }
}
