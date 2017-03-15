using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BraikoN15
{
    static class ReaderFile 
    {
        public static int[] read(string path)
        {          
            var stringvalue = File.ReadAllText(path).Split(',');
            var gets = new int[stringvalue.Length];
            for (int i = 0; i < gets.Length; i++)
            {
                gets[i] = Convert.ToInt32(stringvalue[i]); 
            }
            return gets;
        }
    }
}
