using System;
using System.Collections;

namespace EsercizioClassi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona = new Person();

            persona.FirstName = "Matilde";
            persona.LastName = "Pluto";
            persona.Age = 30;

            Console.WriteLine(persona.GetFullName());

            //array di person di 5 elementi del tipo person
            //Pippo1 Cognome2 Age random
            //Pippo2 Cognome4

            Random numRandom = new Random();
            Person[] persone = new Person[5];

            for (int i = 0; i < 5; i++)
            {
                Person personaDaInserire = new Person()
                {
                    FirstName = "Pippo" + (i + 1),
                    LastName = "Cognome" + 2 * (i + 1),
                    Age = numRandom.Next(0, 101)
                };
                persone[i] = personaDaInserire;
            }

            foreach(Person p in persone)
            {
                Console.WriteLine(p.GetFullName());
            }

            persona.Contacts = new Contacts
            {
                PhoneNumber = 123,
                Email = "flo",
                Address = new Address
                {
                    City = "Milano",
                    State = "Italy",
                    ZipCode = 20100
                }
            };
            Console.WriteLine(persona.GetFullName() + persona.Contacts.Address.City);
        }
    }
}