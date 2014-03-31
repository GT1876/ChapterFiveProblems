using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] num = new int[] {1, 5, 3, 2, 4};

            Array.Sort(num);
            for (int i = 0; i < 5; i++)
            {
                //
                Console.WriteLine(num[i]);
            }
            Array.Reverse(num);
            for (int i = 0; i < 5; i++)
            {
                //
                Console.WriteLine(num[i]);
            }
        }
    }
}
