using System;
using System.Collections.Generic;
using System.Linq;

namespace M14U2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student{Name = "Андрей", Age = 23, Languages = new List<string>{"английский", "немецкий"} },
                new Student{Name = "Сергей", Age = 27, Languages = new List<string>{"английский", "французский"}},
                new Student{Name = "Дмитрий", Age = 29, Languages = new List<string>{"английский", "испанский"}},
                new Student{Name = "Василий", Age = 24, Languages = new List<string>{"испанский", "немецкий"}}
            };

            var choosed = from s in students
                          where s.Age < 27
                          let year = DateTime.Today.Year - s.Age
                          select new Application { Name = s.Name, YearOfBirth = year };

            foreach(var student in choosed)
                Console.WriteLine($"{student.Name} {student.YearOfBirth} года рождения");
        }
    }

    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Languages { get; set; }
    }
    class Application
    {
        public string Name { get; set; }

        public int YearOfBirth { get; set; }
    }
}
