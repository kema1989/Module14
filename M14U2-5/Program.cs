using System;
using System.Collections.Generic;
using System.Linq;

namespace M14U2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
                new Contact() { Name = "Андрей", Phone = 7999945005 },
                new Contact() { Name = "Сергей", Phone = 799990455 },
                new Contact() { Name = "Иван", Phone = 79999675 },
                new Contact() { Name = "Игорь", Phone = 8884994 },
                new Contact() { Name = "Анна", Phone = 665565656 },
                new Contact() { Name = "Василий", Phone = 3434 }
            };

            while (true)
            {
                var keyChar = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (keyChar)
                {
                    case '1':
                        contacts.Take(2);
                        break;
                    case '2':
                        contacts.Skip(2).Take(2);
                        break;
                    case '3':
                        contacts.Skip(4).Take(2);
                        break;
                }

                foreach (var contact in contacts)
                    Console.WriteLine(contact.Name + " " + contact.Phone);
            }
        }
    }

    class Contact
    {
        public string Name { get; set; }

        public long Phone { get; set; }
    }
}
