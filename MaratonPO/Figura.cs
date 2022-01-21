using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonPO
{
    // 7. Stwórz nowy projekt. Dodaj do niego abstrakcyjną klasę Figura,
    // oraz dwie zwykłe klasy dziedziczące po niej – Kwadrat i Trójkąt.
    // W klasie Figura umieść 3 zabezpieczone pola typu int, a następnie zadeklaruj
    // abstrakcyjną metodę Pole().
    public abstract class Figura
    {
        private int a;
        private int b;
        private int h;

        public abstract double Pole();
    }
    public class Kwadrat: Figura
    {
        private double a;
        private double b;
        
        public Kwadrat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Pole()
        {
            // 8. W klasach Kwadrat i Trójkąt nadpisz metodę wyliczając odpowiednie pole (a*a, ½*a*b)
            // 9. Nie miała by sensu, ponieważ Kwadrat i Trójkąt
            // Posiadają różne pola.
            return this.a * this.b;
        }
    }
    public class Trojkat: Figura
    {
        private double a;
        private double b;
        private double c;

        public Trojkat(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double Pole()
        {
            double p = (this.a + this.b + this.c) / 2;
            return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
        }
    }

}
