using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    abstract class BassKlass
    {
        
        private protected string Name = null;

        private protected string rasa = null;
        private protected int lvl = 0;
        private protected int power = 0;
        private protected int xp = 0;

        private protected int domag = 0;
        private protected int armour = 0;
        private protected int money = 0;
        private protected int speedAtak = 0;
        private protected int MagicDomag = 0; //+урон для магия 
        private protected Random rnd = new Random();




        public BassKlass()
        {

        }
        public int LeavedXp() 
        {
            return xp;
        }
        public BassKlass(string name, int power, int xp, int domag, int armour,  int speedAtak)

        {
            this.Name = name;
            this.lvl = 0;
            this.power = power;
            this.xp = xp;

            this.domag = domag;
            this.armour = armour;
            this.money = 0;
            this.speedAtak = speedAtak;


        }
        public virtual int Ataaka()
        {


            
            int dop = rnd.Next(4, 8);
            int attaka = (domag + power + dop) * speedAtak;
            return attaka;



        }


        public virtual int Zachita(int attaka)
        {


           

            int armour1 = armour * rnd.Next(2, 4);

            if (attaka > armour1)
            {
                xp = (armour1 + xp) - attaka;
                if (xp < 0)
                    xp = 0;

                return attaka;
            }
            else { return 0; }
        }
        public bool IsAlive() { return xp > 0; }

        public void lvlup()
        {
            Random rnd = new Random();
            int lvlup = rnd.Next(1, 3);
            //если 1 то бро ,2 atta ,3 xp
            if (1 == lvlup)
                armour += 4;
            else if (2 == lvlup)
                domag += 4;
            else if (3 == lvlup)
                armour += 4;
        }
        public void proverka()
        {

            Console.WriteLine($"{this.xp}");
        }
        public string MameInfo()
        {
            return Name;
        }
        public virtual int Moneyplus(string rasamob)
        {
            return money;
        }
        public string InfoRasa()
        {
            return this.rasa;
        }
        


    }





}