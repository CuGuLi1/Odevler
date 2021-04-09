using System;

namespace MetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri = new Musteri();

            Console.Write("Lütfen Adınızı Girin :");
            musteri.Ad = Console.ReadLine();

            Console.Write("Lütfen Soyadınızı Girin :");
            musteri.Soyad = Console.ReadLine();



            Console.Write("Lütfen İkametinizi Girin :");
            musteri.Sehir = Console.ReadLine();

            Console.WriteLine("------------------");
            Console.WriteLine("Tebrikler Hesabınız Eklendi");

            Console.WriteLine("------------------");
            musteriManager.Listesi(musteri);
            Console.WriteLine("------------------");
            musteriManager.Silme(musteri);
        }
    }
}
