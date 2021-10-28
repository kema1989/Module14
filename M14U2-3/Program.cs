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

            var courses = new List<Course>()
            {
                new Course(){Name = "Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                new Course(){Name = "Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)}
            };

            // Задание 14.2.3
            //var choosed = from s in students
            //              where s.Age < 27
            //              let year = DateTime.Today.Year - s.Age
            //              select new Application { Name = s.Name, YearOfBirth = year };

            //foreach(var student in choosed)
            //    Console.WriteLine($"{student.Name} {student.YearOfBirth} года рождения");

            //Задание 14.2.4
            var newStudents = from stud in students
                              where stud.Age < 29 && stud.Languages.Contains("английский")
                              from c in courses
                              where c.Name.Contains("C#")
                              let birthYear = DateTime.Today.Year - stud.Age
                              select new { Name = stud.Name, BirthYear = birthYear, Course = c.Name };

            foreach(var stud in newStudents)
                Console.WriteLine($"Студент {stud.Name} {stud.BirthYear} года рождения записан на курс {stud.Course}");
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

    class Course
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }
}
