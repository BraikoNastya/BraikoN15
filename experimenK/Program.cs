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
            {
                var game = new Game(5,6,1,4,3,7,2,8,0);
                while (!game.CheckWIN())
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
                Printt.Print(game);

                var game2 = new Game(ReaderFile.read(@"C:\Users\User\Desktop\2 семестр\a"));
                Printt.Print(game2);
                Console.Read();
            }
        }
    }
}