using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Man : BassKlass
    {


        public Man()
        {

        }
        public Man(string name,  int power, int xp, int domag, int armour, int speedAtak)
            : base(name, power, xp, domag, armour,  speedAtak) { rasa = "men"; }






    }
    class Magic : BassKlass
    {
        public Magic()
        {

        }
        public Magic(string name,  int power, int xp, int domag, int armour, int speedAtak)
           : base(name, power, xp, domag, armour, speedAtak) { rasa = "magic"; MagicDomag += 10; }
        public override int Ataaka()
        {


            Random rnd = new Random();
            int dop = rnd.Next(4, 8);
            int attaka = (domag + power + dop + MagicDomag) * speedAtak;
            return attaka;



        }

    }
    class Monster : BassKlass
    {
        public Monster()
        {
            rasa = "Monster ";

        }
        public Monster(string name,int power, int xp, int domag, int armour, int speedAtak)
            : base(name,  power, xp, domag, armour,  speedAtak) { }


    }

}