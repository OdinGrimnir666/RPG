using System;

namespace RPG
{
    class Man : BassKlass
    {


        public Man()
        {

        }
        public Man(string name, int power, int xp, int domag, int armour, int speedAtak)
            : base(name, power, xp, domag, armour, speedAtak) { this.rasa = "men"; money = 200; }
        public int MoneyWin()
        {

            return money;

 

        
    }
}
