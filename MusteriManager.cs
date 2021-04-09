using System;
using System.Collections.Generic;
using System.Text;

namespace MetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Müşteri Ekleme");
            Console.WriteLine("-------------------");
            Console.WriteLine("Müşteri Adı : " + musteri.Ad);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            Console.WriteLine("Müşteri İkameti : " + musteri.Sehir);
            Console.WriteLine("Müşteri TcNo : " + musteri.TcNo);
            Console.WriteLine("Tebrikler Hesabınız Eklendi");
        }


        public void Listesi(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listeleme");
            Console.WriteLine("-------------------");
            Console.WriteLine("Müşteri Adı : " + musteri.Ad);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silme");
            Console.WriteLine("---------------");
            Console.WriteLine("Müşteri Ad Soyad : " + musteri.Ad + musteri.Soyad);
            Console.WriteLine("Müşteri TcNo : " + musteri.TcNo);
            Console.WriteLine("Hesabınız Silindi");

        }
    }
}
