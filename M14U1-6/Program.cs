using System;
using System.Collections.Generic;
using System.Linq;

namespace M14U1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
                new[]{2, 3, 7, 1},
                new[]{45, 17, 88, 0},
                new[]{23, 32, 44, -6},
            };

            var newList = from m in numsList
                          from n in m
                          orderby n
                          select n;

            foreach(var number in newList)
                Console.WriteLine(number);

        }
    }
}
