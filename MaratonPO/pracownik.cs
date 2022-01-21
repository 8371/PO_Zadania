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
        public void Pracuj()
        {
            Console.WriteLine("Pracownik pracuje");
        }
    }
    class Programista: pracownik
    {
        //2. Stwórz klasę potomną Programista i użyj przesłaniania metody
        //(zaimplementuj metodę pracuj).
        public void Pracuj()
        {
            Console.WriteLine("Przyslaniam metode pracuj");
        }
    }
}
