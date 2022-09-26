using System;

namespace ArayüzÖrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus fc = new Focus();
            Console.WriteLine(fc.HangiMarka().ToString());
            Console.WriteLine(fc.HangiRenk().ToString());
            Console.WriteLine(fc.KacTeker());

            Civic cvc = new Civic();
            Console.WriteLine(cvc.HangiMarka().ToString());
            Console.WriteLine(cvc.HangiRenk().ToString());
            Console.WriteLine(cvc.KacTeker());


            NewFocus nfc = new NewFocus();
            Console.WriteLine(nfc.HangiMarka().ToString());
            Console.WriteLine(nfc.HangiRenk().ToString());
            Console.WriteLine(nfc.KacTeker());

            NewCivic ncvc = new NewCivic();
            Console.WriteLine(ncvc.HangiMarka().ToString());
            Console.WriteLine(ncvc.HangiRenk().ToString());
            Console.WriteLine(ncvc.KacTeker());

        }
    }
}
