using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioClassi
{
    public class Person
    {
        //Campi

        //Inizializzare un campo con valore di default
        private string firstName = "Pippo"; //Camel
        private string lastName = "Sconosciuto";

        //Dichiarazione di un campo con inizializzazione implicita
        private int age;

        //Proprietà per accedere alla classe
        public string FirstName //Pascal
        {
            get { return firstName; } //accede al campo privato
            set { firstName = value; } //convenzione
        }
        public string LastName //Pascal
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //public Address Address { get; set; }
        public Contacts Contacts { get; set; }


        //Metodi
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
