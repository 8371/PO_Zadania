using System;

namespace MaratonPO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            pracownik p = new pracownik();
            p.Pracuj();
            Programista p1 = new Programista();
            p1.Pracuj();
        }
    }
}
