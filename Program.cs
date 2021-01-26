using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("готовы Пойти в подземелья и поучаствовать в битвах ? ");
            Console.WriteLine("Напишите (да) и мы продолжим");
            string Start=Console.ReadLine();
            if(Start=="да")
            {
                Console.WriteLine("Ну давай выбирем расe,если человек напшии (человек) ");
                string Rasa = Console.ReadLine();
                if(Rasa=="человек")
                {
                    Console.WriteLine("Ведите имя персонажа ");
                    string name= Console.ReadLine();
                    var Man1 = new Man(name, 1, 40, 1000, 80, 200, 0, 1);
                    var Monster1 = new Monster("kileer", 0, 50, 5000, 20, 50, 0, 1);
                    int lvl = 0;

                    while (10>lvl)
                    {
                        Console.WriteLine("ВЫ наткнулись на монстра ");
                        while (false != Monster1.lifeGeroi())
                        {
                            if (Man1.lifeGeroi() != false)
                            {

                            
                            int i = 0;
                            ++i;
                            Monster1.Zachita(Man1.Ataaka());
                            Console.WriteLine($"Вы бьете монстра{i}");
                            if (false != Monster1.lifeGeroi())
                            {
                                int p = 0;
                                p++;
                                Man1.Zachita(Monster1.Ataaka());
                                Console.WriteLine($"Вас отакует монстер {p}");

                            }
                            }
                            else
                            {
                                Console.WriteLine("Вы мертвы !");
                                goto end;
                            }

                            
                            Console.WriteLine("Вы убили мностра ");
                        }

                        
                        lvl++;
                        Console.WriteLine("переходим на лвл выше");
                    }
                end:
                    Console.WriteLine("спасибо за игру ");





                    Console.ReadKey();


                }

            }
            


        }
    }
}
