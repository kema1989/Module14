using System;
using System.Collections.Generic;
using System.Linq;

namespace M14U1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            //var longCities = from longCity in russianCities
            //                 where longCity.Name.Length < 10
            //                 orderby longCity.Name
            //                 select longCity;

            //foreach(var longCity in longCities)
            //    Console.WriteLine(longCity);
            var longCities = russianCities.Where(city => city.Name.Length < 10).OrderBy(city => city.Name.Length);
        }

        // Создадим модель класс для города
        public class City
        {
            public City(string name, long population)
            {
                Name = name;
                Population = population;
            }

            public string Name { get; set; }
            public long Population { get; set; }
        }
    }
}
