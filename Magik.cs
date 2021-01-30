using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Magic:Man
    {
         
        public Magic()
        {

        }
        public Magic(string name, int power, int xp, int domag, int armour, int speedAtak)
           : base(name, power, xp, domag, armour, speedAtak) { this.rasa = "magic"; MagicDomag += 10; }
        public override int Ataaka()
        {


            Random rnd = new Random();
            int dop = rnd.Next(4, 8);
            int attaka = (domag + power + dop + MagicDomag) * speedAtak;
            return attaka;


        }
    }
}
