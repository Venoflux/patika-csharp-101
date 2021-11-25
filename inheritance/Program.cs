using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                       Canlilar
            //                          |
            //       Bitkiler                          Hayvanlar
            //    |             |                 |                |
            // Tohumlu      Tohumsuz        Surungeneler        Kuslar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();         
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("************");

            Kuslar marti = new Kuslar();
            marti.Ucmak();
        }
    }
}
