using System;
using System.Linq;
using System.Collections.Generic;

namespace Module14
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
                1,
                "Сергей",
                "Андрей",
                300,
            };

            var result = from p in objects
                         where p is string
                         orderby p
                         select p;
            
            foreach(var name in result)
            {
                Console.WriteLine(name);
            }

            foreach (var name in objects.Where(p => p is string).OrderBy(p => p))
                Console.WriteLine(name);

        }
    }
}
