using System;

namespace GitHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Laskin laskimeni = new Laskin();
            Console.WriteLine("Laske lukujen 148 ja 56 erotus");
            int erotus = laskimeni.Erotus(148, 56);
            Console.WriteLine("Erotus on: " + erotus);
        }
    }
}
