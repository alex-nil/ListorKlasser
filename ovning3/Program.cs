using System;
using System.Collections.Generic;

namespace ovning3
{

    public class Person {

        public string firstname;
        public string birth;
        public string country;
        public string work;
        public string lastname;

        List <Person> info = new List<Person>();
        public void presentera() {
            Console.WriteLine($"Du heter {firstname} och föddes år {birth}. Du bor i {country} och jobbar som {work} och heter {lastname} i efternamn!");
        }
   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            List<Person> info = new List<Person>();


            //Hämtar info från användare
            Console.WriteLine("Skriv in förnamn: ");
            person.firstname = Console.ReadLine();

            Console.WriteLine("Skriv in vilket år du föddes: ");
            person.birth = Console.ReadLine();

            Console.WriteLine("Skriv in vilket land du bor i: ");
            person.country = Console.ReadLine();

            Console.WriteLine("Skriv in vad du jobbbar med: ");
            person.work = Console.ReadLine();

            Console.WriteLine("Skriv in ditt efternamn: ");
            person.lastname = Console.ReadLine();

            //lägger till info i lista
            info.Add(person);

            //Kallar på metoden
            person.presentera();

            foreach (var item in info)
            {
                Console.Clear();
                person.presentera();
            }
        }
    }
}
