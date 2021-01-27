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
            if (Start == "да")
            {


                Console.WriteLine("Ну давай выбирем расe,если человек напшии (человек)(Маг) ");
                string Rasa = Console.ReadLine();
                if (Rasa == "человек")
                {
                    Console.WriteLine("Ведите имя персонажа ");
                    string name = Console.ReadLine();
                    var Man1 = new Man(name, 0, 5, 1000, 80, 200, 0, 1);
                    
                    
                    int lvl = 0;

                    while (100 > lvl||!Man1.lifeGeroi())
                    {

                        Console.WriteLine("ВЫ наткнулись на монстра ");
                        int p = 0, i = 0;
                        var Monster1 = new Monster("kileer", 0, 30, 300, 300, 50, 0, 1);
                        if (0 == lvl % 10)
                        {
                            Console.WriteLine("ВЫ апнули статы");
                            Man1.lvlup();
                            Console.WriteLine("Монстор стал сильнее");
                            Monster1.lvlup();


                        }


                        while ( Monster1.lifeGeroi())
                        {
                            if (Monster1.lifeGeroi())
                            {


                                
                                ++i;
                                Monster1.Zachita(Man1.Ataaka());
                                Console.WriteLine($"Вы бьете монстра {i}");
                                Monster1.proverka();

                            }
                            if (Monster1.lifeGeroi())
                            {
                                
                                p++;
                                Man1.Zachita(Monster1.Ataaka());
                                Console.WriteLine($"Вас отакует монстер {p}");
                                Man1.proverka();

                            }

                            
                            
                        }
                        Console.WriteLine("Вы убили мностра ");
                        
                        lvl++;
                        Console.WriteLine("переходим на лвл выше");
                    }
                    Console.WriteLine("ВЫ мертвы");
                    Console.WriteLine("спасибо за игру ");

                }
                else if(Rasa=="Маг")
                {
                    Console.WriteLine("Ведите имя персонажа ");
                    string name = Console.ReadLine();
                    var Magic1 = new Magic(name, 0, 40, 1000, 80, 200, 0, 1);


                    int lvl = 0;

                    while (20 > lvl || !Magic1.lifeGeroi())
                    {
                        if(0==lvl%10)
                        Console.WriteLine("ВЫ наткнулись на монстра ");
                        int p = 0, i = 0;
                        var Monster1 = new Monster("kileer", 0, 30, 300, 300, 50, 0, 1);
                        if (0 == lvl % 10)
                        {
                            Console.WriteLine("ВЫ апнули статы");
                            Magic1.lvlup();
                            Console.WriteLine("Монстор стал сильнее");
                            Monster1.lvlup();


                        }
                        while (Monster1.lifeGeroi())
                        {
                            if (Monster1.lifeGeroi())
                            {



                                ++i;
                                Monster1.Zachita(Magic1.Ataaka());
                                Console.WriteLine($"Вы бьете монстра {i}");
                                Monster1.proverka();

                            }
                            if (Monster1.lifeGeroi())
                            {

                                p++;
                                Magic1.Zachita(Monster1.Ataaka());
                                Console.WriteLine($"Вас отакует монстер {p}");
                                Magic1.proverka();

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
