using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayi_dizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("***** Sırasız Dizi *****");
            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Sırasız Dizi *****");
            Array.Sort(sayi_dizisi);
            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }


            // Clear
            Console.WriteLine("***** Array Clear *****");
            // sayi_dizisi elemanlarını kullanarak 2. index ten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayi_dizisi,2,2);
            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }


            // Reverse
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayi_dizisi);
            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }

            
            // IndexOf
            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayi_dizisi, 23));


            // Resize
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayi_dizisi, 9);
            sayi_dizisi[8] = 99;
            foreach (var sayi in sayi_dizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
