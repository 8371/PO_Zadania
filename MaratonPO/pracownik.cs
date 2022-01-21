using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonPO
{
    class pracownik
    {
        // 1. Stwórz klasę pracownik zawierającą publiczną metodę Pracuj()
        // wypisującą w konsoli stwierdzenie „Pracownik pracuje”.

        // 4. Wszystkie metody opatrzone modyfikatorem override automatycznie stają się wirtualne. Metodę
        // z klasy bazowej można przesłonić tylko wtedy, jeśli jest wirtualna.Dlatego przesłaniająca metoda
        // także jest wirtualna.
        public virtual void Pracuj()
        {
            Console.WriteLine("pracownik pracuje");
        }
    }
    class Programista: pracownik
    {
        // 2. Stwórz klasę potomną Programista i użyj przesłaniania metody
        //(zaimplementuj metodę pracuj). 
        // 5. Nie podkreśla się metoda pracuj, świadomie nadpisujemy
        // metodę Pracuj z klasy rodzica

        // 6. Zmień metodę Pracuj w klasie pracownik na wirtualną, a następnie zamień wyświetlane dane na „logowanie”. W klasie Programista zmień kod metody Pracuj na następujący:
        // base.Pracuj();
        // Console.WriteLine("Obowiazki programisty");
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Obowiazki programisty");
        }
    }
    class Projektant: pracownik
    /*
    11. Następnie dodaj 3 klasy pracowników dziedziczących po klasie 
    Pracownik: Programista, Projektant i Księgowy. W każdej z tych klas 
    nadpisz (override) metodę pracuj wyświetlając informację o tym kto pracuje.
     */
    {
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Projektant projektuje");
        }
    }
    class Księgowy: pracownik
    {
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Księgowy pracuje");
        }
    }
}
