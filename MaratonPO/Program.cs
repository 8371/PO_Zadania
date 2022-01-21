using System;

namespace MaratonPO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadania 1 - 6.
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

            // Zadania 7 - XYZ
            double a = 2.1, b = 3.4;
            Figura kwadrat = new Kwadrat(a, b);
            Console.WriteLine("Pole kwadratu o bokach {0}, {1} wynosi: {2}", a, b, kwadrat.Pole());
            double c = 5.1;
            Figura trojkat = new Trojkat(a, b, c);
            Console.WriteLine("Pole trojkata o bokach {0}, {1}, {2} wynosi: {3:F2}", a, b, c, trojkat.Pole());
        }
    }
}
