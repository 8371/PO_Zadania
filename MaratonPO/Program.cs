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
            // 3. W kodzie programu dodaj
            // Pracownik p = new Programista();
            // p.Pracuj();
            pracownik p2 = new Programista();
            p2.Pracuj();
        }
    }
}
