using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonPO
{
    class Osoba
    {
        string imie;
        string nazwisko;
        public Osoba () { }
        public Osoba (string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imie = {0} Nazwisko = {1}", this.imie, this.nazwisko);
        }
    }
    class Student: Osoba
    {
        int rokStudiów;
        int numerGrupy;
        int numerAlbumu;
        Student() { }
        public Student(int rokStudiów, int numerGrupy, int numerAlbumu)
        {
            this.rokStudiów = rokStudiów;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok = {0} Nr grupy = {1} Nr albumu = {2}", this.rokStudiów, this.numerGrupy, this.numerAlbumu);
        }
    }
}
