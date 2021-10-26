using System;
using System.Collections.Generic;
using System.Linq;

namespace M14U1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, string[]>();

            companies.Add("Apple", new[] { "Mobile", "Desktop" });
            companies.Add("Samsung", new[] { "Mobile" });
            companies.Add("IBM", new[] { "Desktop" });

            //var result = from c in companies
            //             where c.Value.Contains("Mobile")
            //             select c.Key;

            var result = companies.Where(c => c.Value.Contains("Mobile"));

            foreach(var company in result)
                Console.WriteLine(company.Key);
        }
    }
}
