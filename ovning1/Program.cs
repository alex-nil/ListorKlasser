using System;
using System.Collections.Generic;

namespace ovning
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv in ett djurnamn: ");
                var usrIn = Console.ReadLine();
                myList.Add(usrIn);
                Console.WriteLine(usrIn + " Addat till listan");
            }
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
