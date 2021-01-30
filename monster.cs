using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Monster : BassKlass
    {
        public Monster()
        {


        }
        public Monster(string name, int power, int xp, int domag, int armour, int speedAtak)
            : base(name, power, xp, domag, armour, speedAtak) { this.rasa = "Monster"; }

        public int Moneyplus(int money, string rasa)
        {
            if (this.rasa == "Monster")
            {
                money += 50;
            }
            else if (this.rasa == "Bosmonster")
            {
                money += 200;
            }
            return money;

        }
    }
}
