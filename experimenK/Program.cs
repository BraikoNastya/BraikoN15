using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BraikoN15
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            size = int.Parse(Console.ReadLine());

            Game game2 = new Game(size);
            Random Gen = new Random();
            game2.Filling(Gen);
            while (game2.CheckWIN() == false)
            {
                Console.Clear();
                Console.WriteLine("Игра началась!\n");
                Printt.Print(game2);

                Console.WriteLine("ВВедите число которое хотите передвинуть");
                int value = Convert.ToInt32(Console.ReadLine());
                while (!game2.Shift(value))
                {
                    Console.WriteLine("Введите другое число");
                    value = Convert.ToInt32(Console.ReadLine());
                }
            }
            Printt.Print(game2);


            {
                var game = new Game(5, 6, 1, 4, 3, 7, 2, 8, 0);
                while (game.CheckWIN() == false)
                {
                    Console.Clear();
                    Console.WriteLine("Игра началась!\n");
                    Printt.Print(game);

                    Console.WriteLine("ВВедите число которое хотите передвинуть");
                    int value = Convert.ToInt32(Console.ReadLine());
                    while (!game.Shift(value))
                    {
                        Console.WriteLine("Введите другое число");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Printt.Print(game);
                /* while (!game.CheckWIN())
                 {
                     Printt.Print(game);

                     Console.WriteLine("ВВедите число которое хотите передвинуть");
                     int value = Convert.ToInt32(Console.ReadLine());
                     while (!game.Shift(value))
                     {
                         Console.WriteLine("Введите другое число");
                         value = Convert.ToInt32(Console.ReadLine());
                     }
                 }
                 Printt.Print(game);*/

                //var game2 = new Game(ReaderFile.read(@"C:\Users\User\Desktop\2 семестр\a"));
                //  Printt.Print(game2);
                Console.ReadLine();
            }
        }
    }
}