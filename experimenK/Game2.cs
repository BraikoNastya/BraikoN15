using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraikoN15
{
    class Game2 : Game
    {
        public Game2(int[] numbers)
            : base(numbers)
        {
            
        }
        public Game2(int size)
            : base(size)
        {
            ChangeNumbersOnField();
        }
        public void ChangeNumbersOnField() //поменять местами числа в массиве
        {
            Random gen = new Random();
            int[] numbers = new int[field.Length];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (i != numbers.Length - 1)
                {
                    numbers[i] = i + 1;
                }
            }
            int index = 0;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    index = gen.Next(0, field.Length);
                    for (int k = 0; k < field.Length; k++)
                    {
                        while ((numbers[index] == numbers[k]) && (numbers[index] == Int32.MaxValue))
                        {
                            index = gen.Next(0, numbers.Length);
                        }
                    }
                    field[i, j] = numbers[index];
                    numbers[index] = Int32.MaxValue;
                }
            }
        }
    }
}
