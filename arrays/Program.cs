using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            // Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            // Döngülerle Dizi Kullanımı
            // Klavyeden girilen n tane sayının ortalaması
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int dizi_uzunlugu = int.Parse(Console.ReadLine());
            int[] sayi_dizisi = new int[dizi_uzunlugu];

            for (int i = 0; i < dizi_uzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayi_dizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayi_dizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama: " + toplam/dizi_uzunlugu);


            Console.ReadKey();
        }
    }
}
