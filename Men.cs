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
    class Magic : Man
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
    class Monster : BassKlass
    {
        public Monster()
        {
            

        }
        public Monster(string name, int power, int xp, int domag, int armour, int speedAtak)
            : base(name, power, xp, domag, armour, speedAtak) { this.rasa = "Monster"; }

        public int Moneyplus(int money,string rasa)
        {
            if(this.rasa=="Monster")
            {
                money += 50;
            }
            else if(this.rasa== "Bosmonster")
            {
                money += 200;
            }
            return money;
            
            
        }



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
        public override int Zachita(int attaka)
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