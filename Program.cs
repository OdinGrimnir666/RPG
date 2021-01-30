using System;
using System.Threading;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            BassKlass Player = null;
            BassKlass Monster1 = null;
            Console.WriteLine("готовы Пойти в подземелья и поучаствовать в битвах ? ");
            Console.WriteLine("Напишите (да) и мы продолжим");
            string Start = Console.ReadLine();
            if (Start == "да")
            {


                Console.WriteLine("Ну давай выбирем расe,если человек напшии (человек)(Маг) ");
                string Rasa = Console.ReadLine();
                Console.WriteLine("Ведите имя персонажа ");
                string name = Console.ReadLine();
                if (Rasa == "человек")
                {


                    Player = new Man(name, rnd.Next(80, 120), rnd.Next(800, 1500), rnd.Next(60, 180), rnd.Next(70, 160), 1);
                }
                else if (Rasa == "Маг")
                {

                    Player = new Magic(name, 40, 1000, 80, 200, 1);
                }

                int lvl = 0;


                while (100 > lvl && Player.IsAlive())
                {

                    Console.WriteLine("ВЫ наткнулись на монстра ");
                    lvl++;
                    int p = 0, i = 0;



                    if (0 == lvl % 10)
                    {
                        Console.WriteLine("ВЫ апнули статы");
                        Player.lvlup();
                        Console.WriteLine("Монстор стал сильнее");
                       
                        Console.WriteLine("Вы наппали на боса монстров");
                        Monster1 = new Bosmonster("Bosskiller", rnd.Next(40,50), rnd.Next(300,500), rnd.Next(70,100), rnd.Next(30,60), 1);
                        Monster1.lvlup();
                    }
                    else
                    {
                        Monster1 = new Monster("kileer", rnd.Next(50, 60), rnd.Next(400, 600), rnd.Next(120,160), rnd.Next(40,70), 1);
                    }


                    while (Monster1.IsAlive())
                    {

                        ++i;
                        var PlayerAtack = Player.Ataaka();
                        Console.WriteLine($"Вы бьете {Monster1.MameInfo()} монстра {i} c атакой {PlayerAtack}");
                        var Def = Monster1.Zachita(PlayerAtack);
                        if (Def == 0)
                        {
                            Console.WriteLine($"Монстр поглотил вашу атаку");

                        }
                        else
                        {
                            if (!Monster1.IsAlive())
                            {

                                Console.WriteLine($"Монстр убит!");
                            }
                            else
                            {

                                Console.WriteLine($"Монстр получил урон {Def} оставшиеся жизни {Monster1.LeavedXp()}");
                            }

                        }

                        //  Monster1.proverka();
                        Thread.Sleep(4000);//замедление

                        if (Monster1.IsAlive())
                        {

                            p++;
                            Player.Zachita(Monster1.Ataaka());
                            Console.WriteLine($"Вас атакует монстер {p}");
                            Thread.Sleep(1000);
                            Player.proverka();

                        }



                    }

                    Console.WriteLine("Вы убили мностра ");
                    Console.WriteLine($"Вознаграждение за убийство{}");
                   

                    
                    Console.WriteLine("переходим на лвл выше");
                }
                Console.WriteLine("ВЫ мертвы");
                Console.WriteLine("спасибо за игру ");
            }




        }


    }
}