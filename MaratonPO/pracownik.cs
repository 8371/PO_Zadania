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
            Console.WriteLine("Pracownik pracuje");
        }
    }
    class Programista: pracownik
    {
        //2. Stwórz klasę potomną Programista i użyj przesłaniania metody
        //(zaimplementuj metodę pracuj). 
        public override void Pracuj()
        {
            Console.WriteLine("Przyslaniam metode pracuj");
        }
    }
}
