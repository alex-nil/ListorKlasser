using System;
using System.Collections.Generic;

namespace ovning2
{
    public class Animal {
        public int ålder;
        public string namn;
        public virtual void Talk() {
            
        }
    }
    //Skapar klass för katt
     public class Katt : Animal {         
        public override void Talk () {         //om man katt ropar på talk så skriver den ut följande
        Console.WriteLine(namn + " " + ålder + " mjao");
    }
    }
    public class Hund : Animal {
        public override void Talk () {
        Console.WriteLine(namn + " " + ålder + " voff");
    }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Katt katt = new Katt();
            Hund hund = new Hund();
            katt.namn = "Gustaf";
            katt.ålder = 55;

            hund.namn = "Alexander";
            hund.ålder = 65;
    
            List<Animal> mittDjur = new List<Animal>();

            mittDjur.Add(katt);
            mittDjur.Add(hund);

            foreach (var item in mittDjur)
            {
                item.Talk();
            }
            

        }
    }
}
