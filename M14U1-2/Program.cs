using System;
using System.Linq;
using System.Collections.Generic;

namespace M14U1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Раз два три", "четыре пять шесть", "семь восемь девять" };

            var digits = from p in text
                         from t in p.Split(' ')
                         select t;

            foreach(var digit in digits)
                Console.WriteLine(digit);
            Console.ReadKey();
        }
    }
}
