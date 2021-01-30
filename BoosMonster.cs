using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Bosmonster : BassKlass
    {
        public Bosmonster()
        {

        }
        public Bosmonster(string name, int power, int xp, int domag, int armour, int speedAtak)
            : base(name, power, xp, domag, armour, speedAtak) { rasa = "Bosmonster"; }
        public override int Ataaka()
        {


            Random rnd = new Random();
            int dop = rnd.Next(10, 16);
            int attaka = ((domag * 2) + (power * 2) + dop) * speedAtak;
            return attaka;


        }
        public override int Zachita(int attaka)
        {




            int armour1 = armour * rnd.Next(2, 4);

            if (attaka > armour1)
            {
                xp = (armour1 + (xp * 2)) - attaka;
                if (xp < 0)
                    xp = 0;

                return attaka;
            }
            else { return 0; }
        }


    }
}