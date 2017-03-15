using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraikoN15
{
    static class Printt
    {
        public static void Print(Game game)
        {
            for (int i = 0; i < Math.Sqrt(game.field.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(game.field.Length); j++)
                {

                    Console.Write(game[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
