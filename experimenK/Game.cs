using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraikoN15
{
    class Game
    {
        public readonly int[,] field;

        public Game(int size)
        {
            this.field = new int[size, size];
            
        }
        public void Filling(Random Gen) //Заполнение массива
        {
            int[] numbers = new int[field.Length];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (i != numbers.Length - 1)
                {
                    numbers[i] = i + 1;
                }
            }
            int measure = 1;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (measure != field.Length)
                    {
                        field[i, j] = measure;
                        measure++;
                    }
                    else
                    {
                        field[i, j] = 0;
                    }
                }
            }
        }
        public Game(params int[] gets)
        {

            if (TestFile(gets))
            {

                int temp = 0;
                field = new int[Convert.ToInt32(Math.Sqrt(gets.Length)), Convert.ToInt32(Math.Sqrt(gets.Length))];
                for (int i = 0; i < Math.Sqrt(gets.Length); i++)
                {
                    for (int j = 0; j < Math.Sqrt(gets.Length); j++)
                    {
                        field[i, j] = gets[temp];
                        temp++;
                    }
                }

            }
            else
            {
                throw new Exception();
            }
        }
         public int this [int x,int y]
        {
            get { return field[x, y]; }
            
        }
        public virtual bool Shift(int val)
        {
            int i1 = 0;
            int j1 = 0;
            int i2 = 0;
            int j2 = 0;
            for (int i = 0; i < Math.Sqrt(field.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(field.Length); j++)
                {
                    if (field[i, j] == 0)
                    {
                        i1 = i;
                        j1 = j;
                    }
                    if (field[i, j] == val)
                    {
                        i2 = i;
                        j2 = j;
                    }
                }
            }
            if ((Math.Abs(i2 - i1) + Math.Abs(j2 - j1)) == 1)
            {
                field[i1, j1] = val;
                field[i2, j2] = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

       
        
        private bool TestFile(int[] gets)
        {
            bool ret = true;
            int gameline = (int)Math.Sqrt(gets.Length);
            if (gameline % 1 == 0)
            {
                int zerocount = 0;
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 1; j < gets.Length; j++)
                    {
                        if (gets[i] == gets[j])
                        {
                            ret = false;
                        }
                    }
                }
                foreach (var item in gets)
                {
                    if (item == 0)
                    {
                        zerocount++;
                    }
                }
                if (zerocount > 1 || zerocount == 0)
                {
                    ret = false;
                }
            }
            else
            {
                ret = false;
            }
            return ret;
        }

    }
}