﻿using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
Baseclass player ;
            Random rnd = new Random();
            Console.WriteLine("готовы Пойти в подземелья и поучаствовать в битвах ? ");
            Console.WriteLine("Напишите (да) и мы продолжим");
            string Start=Console.ReadLine();
            if (Start == "да")
            {


                Console.WriteLine("Ну давай выбирем расe,если человек напшии (человек)(Маг) ");
                string Rasa = Console.ReadLine();
Console.WriteLine("Ведите имя персонажа ");
                    string name = Console.ReadLine();
                if (Rasa == "человек")
                {
                  player = new Man(name, 0, 80, 1000, 80, 40, 0, 1);
                    
                }
else if(Rasa=="Маг")
                {player = new Magic(name, 0, 40, 1000, 80, 200, 0, 1);
 }
                
                    
                    
                    
                    
                    int lvl = 0;


                    while (100 > lvl&& Man1.lifeGeroi())
                    {

                        Console.WriteLine("ВЫ наткнулись на монстра ");
                        int p = 0, i = 0;
                        int power = rnd.Next(40,50);
                        int domag = rnd.Next(70,100);
                        int armour = rnd.Next(30,60);
                        int xp = rnd.Next(300,500);


                        var Monster1 = new Monster("kileer", 0, power, xp, domag ,armour, 0, 1);


                        

                        
                        if (0 == lvl % 10)
                        {
                            Console.WriteLine("ВЫ апнули статы");
                            player.lvlup();
                            Console.WriteLine("Монстор стал сильнее");
                            Monster1.lvlup();


                        }


                        while ( Monster1.lifeGeroi())
                        {

                                ++i;
                                Monster1.Zachita(Man1.Ataaka());
                                Console.WriteLine($"Вы бьете монстра {i}");
                                Monster1.proverka();

                            
                            if (Monster1.lifeGeroi())
                            {
                                
                                p++;
                                player.Zachita(Monster1.Ataaka());
                                Console.WriteLine($"Вас отакует монстер {p}");
                                player.proverka();

                            }

                            
                            
                        }

                        Console.WriteLine("Вы убили мностра ");
                        
                        lvl++;
                        Console.WriteLine("переходим на лвл выше");
                    }
                    Console.WriteLine("ВЫ мертвы");
                    Console.WriteLine("спасибо за игру ");

                }
                


            }
            


        }
    }
}
