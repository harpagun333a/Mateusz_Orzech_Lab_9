using System;

namespace Cwiczenie_03_Delegaty
{
    class Program
    {
        delegate float delegata(int n1, int n2);

        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 3\n");

            delegata d = new delegata(dodaj);
            d += new delegata(odejm);
            d += new delegata(pomnoz);
            d += new delegata(podziel);

            int n1 = 5;
            int n2 = 3;

            d(n1, n2);
        }

        public static float dodaj(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
            return n1 + n2;
        }

        public static float odejm(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
            return n1 - n2;
        }

        public static float pomnoz(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
            return n1 * n2;
        }

        public static float podziel(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
            return n1 / n2;
        }
    }
}
