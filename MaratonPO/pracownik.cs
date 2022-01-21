using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonPO
{
    class pracownik
    {
        // Zad 1
        public void Pracuj()
        {
            Console.WriteLine("Pracownik pracuje");
        }
    }
    class Programista: pracownik
    {
        public void Pracuj()
        {
            Console.WriteLine("Przyslaniam metode pracuj");
        }
    }
}
