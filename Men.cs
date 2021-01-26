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
        public Man(string name, int lvl, int power, int xp, int domag, int armour, int money, int speedAtak) 
            : base(name,lvl,power, xp, domag, armour,  money, speedAtak) { }






    }
    class Monster :BassKlass
    {
        public Monster()
        {
            rasa = "Monster ";

        }
        public Monster(string name, int lvl, int power, int xp, int domag, int armour, int money, int speedAtak)
            : base(name, lvl, power, xp, domag, armour, money, speedAtak) { }

    }
}
