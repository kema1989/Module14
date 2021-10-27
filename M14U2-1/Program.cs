using System;
using System.Linq;

namespace M14U2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var newWords = words.Select(s => new { Name = s, Length = s.Length }).OrderBy(s => s.Length);

            foreach(var word in newWords)
                Console.WriteLine(word.Name);
        }
    }
}
