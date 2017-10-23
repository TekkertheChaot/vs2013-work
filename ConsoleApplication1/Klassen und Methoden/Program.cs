using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_und_Methoden
{
    class Program
    {
        static void Main(string[] args)  // Programmstart
        {
            Geldautomat ga1 = new Geldautomat();  // Erzeugung eines Objekts ga1 der Klasse Geldautomat
            ga1.Initialisieren(245);
            ga1.Einzahlen(1000);         // Aufruf der Methode einzahlen() des Objekts ga1
            Console.WriteLine(ga1.GetGABalance());
            Console.WriteLine(ga1.Auszahlen(1001));
            Console.ReadLine();
        }
    }

    class Geldautomat                      // Klassendefinition
    {
        private double geldMenge;          // gekapselte Eigenschaft
        public double Auszahlen(double betrag)   // Methodendefinition
        {
            if (geldMenge >= betrag)
            {
                geldMenge -= betrag;
                return betrag;
            }
            else
                return -1;                 // Fehlercode
        }
        public void Einzahlen(double betrag)
        {
            geldMenge += betrag;
        }
        public void Initialisieren(double initbetrag)
        {
            geldMenge = initbetrag;
        }
        public double GetGABalance()
        {
            return geldMenge;
        }
    }
}
