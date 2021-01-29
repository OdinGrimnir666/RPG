using System;

namespace RPG
{
    class Program
    {


        static void Main(string[] args)
        {
            BassKlass player;
            Random rnd = new Random();
            Console.WriteLine("готовы Пойти в подземелья и поучаствовать в битвах ? ");
            Console.WriteLine("Напишите (да) и мы продолжим");

            Console.WriteLine("Ну давай выбирем расe,если человек напшии (человек)(Маг) ");
            string Rasa = Console.ReadLine();
            Console.WriteLine("Ведите имя персонажа ");
            string name = Console.ReadLine();
            if (Rasa == "человек")
            {

                player = new Man(name, 0, 80, 1000, 80, 40, 0, 1);

            }
            else if (Rasa == "Маг")
            {
                player = new Magic(name, 0, 40, 1000, 80, 200, 0, 1);
            }



            //var Man1 = new Man(name, 0, 80, 1000, 80, 40, 0, 1);


            int lvl = 0;
            if (0 == lvl % 10)
            {
                Console.WriteLine("ВЫ апнули статы");

                player.lvlup();
                Console.WriteLine("Монстор стал сильнее");
                Monster1.lvlup();

                {

                    p++;
                    Man1.Zachita(Monster1.Ataaka());
                    player.Zachita(Monster1.Ataaka());
                    Console.WriteLine($"Вас отакует монстер {p}");
                    Man1.proverka();
                    player.proverka();

                }

                Console.WriteLine("спасибо за игру ");

            }
        }
    }
}
