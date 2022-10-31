
using Practicheskaya_5;

namespace _5
{

    internal class Program
    {
        static public ConsoleKeyInfo knopka;
        static public int position = 3;
        static public int cena;
        static public string tort;

        static void Main(string[] args)
        {
            nachalo();
        }
        static void nachalo()
        {
                Console.Clear();
                Console.WriteLine("Заказ тортов у ПИПИБАУ. Торты на любой вкус! \nВыберите параметры торта \n--------------------------------------------");
                Console.Write("  Форма торта  \n  Размер торта  \n  Вкус коржей  \n  Количество коржей  \n  Глазурь  \n  Декор  \n  Конец заказа");
                Console.Write("\n\n Цена:"+ cena +"\n  Ваш торт:" + tort );
            strelka();
            vibor();
        }
        static void strelka()
        {
            position = 3;
            do
            {
                if (knopka.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                }
                else if (knopka.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                }
                Console.Write("\r" + new string(' ', 2));
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                knopka = Console.ReadKey();
                if (knopka.Key == ConsoleKey.Escape)
                {
                    break;
                }
            } while (knopka.Key != ConsoleKey.Enter);
        }
        static void vibor()
        {
            Console.Clear();
            Console.WriteLine("Чтобы выйти нажмите Esc\nВыберите пункт из меню\n---------------------------------------");
            if(knopka.Key == ConsoleKey.Enter)
            {
                switch (position)
                {
                    case 3:
                        Forma forma = new Forma();
                        Console.WriteLine("  " + forma.zvezda );
                        Console.WriteLine("  " + forma.krug );
                        Console.WriteLine("  " + forma.kvadrat );
                        position = 3;
                        strelka();
                        if (knopka.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + forma.zvezda_1;
                                    tort = tort + forma.zvezda;
                                    break;
                                case 4:
                                    cena = cena + forma.krug_1;
                                    tort = tort + forma.krug;
                                    break;
                                case 5:
                                    cena = cena + forma.kvadrat_1;
                                    tort = tort + forma.kvadrat;
                                    break;
                            }
                        }
                        if (knopka.Key == ConsoleKey.Escape)
                        {
                            nachalo();
                            return;
                        }
                        nachalo();
                        return;
                    case 4:
                        Razmer Razmer = new Razmer();
                        Console.WriteLine("  " + Razmer.big + " - " + Razmer.big_1);
                        Console.WriteLine("  " + Razmer.medium + " - " + Razmer.medium_1);
                        Console.WriteLine("  " + Razmer.small + " - " + Razmer.small_1);
                        position = 3;
                        strelka();
                        if (knopka.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + Razmer.big_1;
                                    tort = tort + Razmer.big;
                                    break;
                                case 4:
                                    cena = cena + Razmer.medium_1;
                                    tort = tort + Razmer.medium;
                                    break;
                                case 5:
                                    cena = cena + Razmer.small_1;
                                    tort = tort + Razmer.small;
                                    break;
                            }
                        }
                        if (knopka.Key == ConsoleKey.Escape)
                        {
                            nachalo();
                            return;
                        }
                        nachalo();
                        return;
                    case 5:
                        Vkus Vkus = new Vkus();
                        Console.WriteLine("  " + Vkus.klubnika + " - " + Vkus.klubnika_1);
                        Console.WriteLine("  " + Vkus.chocolate + " - " + Vkus.chocolate_1);
                        Console.WriteLine("  " + Vkus.vanile + " - " + Vkus.vanile_1);
                        position = 3;
                        strelka();
                        if (knopka.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + Vkus.klubnika_1;
                                    tort = tort + Vkus.klubnika;
                                    break;
                                case 4:
                                    cena = cena + Vkus.chocolate_1;
                                    tort = tort + Vkus.chocolate;
                                    break;
                                case 5:
                                    cena = cena + Vkus.vanile_1;
                                    tort = tort + Vkus.vanile;
                                    break;
                            }
                        }
                        if (knopka.Key == ConsoleKey.Escape)
                        {
                            nachalo();
                            return;
                        }
                        nachalo();
                        return;
                    case 6:
                        position = 3;
                        Kolichestvo kolichestvo = new Kolichestvo();
                        Console.WriteLine("  " + kolichestvo.one + " - " + kolichestvo.one_1);
                        Console.WriteLine("  " + kolichestvo.two + " - " + kolichestvo.two_1);
                        Console.WriteLine("  " + kolichestvo.three + " - " + kolichestvo.three_1);

                        position = 3;
                        strelka();
                        if (knopka.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + kolichestvo.one_1;
                                    tort = tort + kolichestvo.one;
                                    break;
                                case 4:
                                    cena = cena + kolichestvo.two_1;
                                    tort = tort + kolichestvo.two;
                                    break;
                                case 5:
                                    cena = cena + kolichestvo.three_1;
                                    tort = tort + kolichestvo.three;
                                    break;
                            }
                        }
                        if (knopka.Key == ConsoleKey.Escape)
                        {
                            nachalo();
                            return;
                        }
                        nachalo();
                        return;
                    case 7:
                        position = 3;
                        Glazur Glazur = new Glazur();
                        Console.WriteLine("  " + Glazur.yagodi + " - " + Glazur.yagodi_1);
                        Console.WriteLine("  " + Glazur.krem + " - " + Glazur.krem_1);
                        Console.WriteLine("  " + Glazur.draje + " - " + Glazur.draje_1);

                        position = 3;
                        strelka();
                        if (knopka.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + Glazur.yagodi_1;
                                    tort = tort + Glazur.yagodi;
                                    break;
                                case 4:
                                    cena = cena + Glazur.krem_1;
                                    tort = tort + Glazur.krem;
                                    break;
                                case 5:
                                    cena = cena + Glazur.draje_1;
                                    tort = tort + Glazur.draje;
                                    break;
                            }
                        }
                        if (knopka.Key == ConsoleKey.Escape)
                        {
                            nachalo();
                            return;
                        }
                        nachalo();
                        return;
                    case 8:
                        position = 3;
                        Decor Decor = new Decor();
                        Console.WriteLine("  " + Decor.bukvi + " - " + Decor.bukvi_1);
                        Console.WriteLine("  " + Decor.yagodnaya + " - " + Decor.yagodnaya_1);
                        Console.WriteLine("  " + Decor.cifri + " - " + Decor.cifri_1);
                        position = 3;
                        strelka();
                        if (knopka.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + Decor.bukvi_1;
                                    tort = tort + Decor.bukvi;
                                    break;
                                case 4:
                                    cena = cena + Decor.yagodnaya_1;
                                    tort = tort + Decor.yagodnaya;
                                    break;
                                case 5:
                                    cena = cena + Decor.cifri_1;
                                    tort = tort + Decor.cifri;
                                    break;
                            }
                        }
                        if (knopka.Key == ConsoleKey.Escape)
                        {
                            nachalo();
                            return;
                        }
                        nachalo();
                        return;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Спасибо за заказ! Чтобы сделать еще один нажмите Esc");
                        string data = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                        File.AppendAllText("C:\\Users\\Илья\\Desktop\\2 КУРС\\c# основа\\c#\\Practicheskaya 5\\Заказ.txt", "Текущая дата: " + data + "\n" + "Ваш заказ: " + tort + "\n" + "Цена: " + cena + "\n");
                        knopka = Console.ReadKey();
                        if (knopka.Key == ConsoleKey.Escape)
                        {
                            cena = 0;
                            tort = " ";
                            nachalo();
                            return;
                        }
                        return;
                }
            }         
        }
    }
}



