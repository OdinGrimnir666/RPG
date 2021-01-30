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
        public Man(string name, int power, int xp, int domag, int armour, int speedAtak)
            : base(name, power, xp, domag, armour, speedAtak) { rasa = "men"; }
        public override int Moneyplus(string rasamob)
        {
            if(rasamob=="Monster")
            {
                this.money += 50;
            }
            else if(rasamob== "Bosmonster")
            {
                this.money += 200;
            }
            return this.money;
            
            
        }







    }
    class Magic : Man
    {
        public Magic()
        {

        }
        public Magic(string name, int power, int xp, int domag, int armour, int speedAtak)
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
            

        }
        public Monster(string name, int power, int xp, int domag, int armour, int speedAtak)
            : base(name, power, xp, domag, armour, speedAtak) { rasa = "Monster "; }


    }
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
        public virtual int Zachita(int attaka)
        {




            int armour1 = armour * rnd.Next(2, 4);

            if (attaka > armour1)
            {
                xp = (armour1 + (xp*2)) - attaka;
                if (xp < 0)
                    xp = 0;

                return attaka;
            }
            else { return 0; }
        }

    }
}