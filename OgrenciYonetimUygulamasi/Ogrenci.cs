using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciYonetimUygulamasi
{
    internal class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public string Sube;
        public int No;
        public int Yas;
        public int DogumYili;

        public int MatematikNotu;
        public int TurkceNotu;
        public int FenNotu;
        public int SosyalNotu;

        public Ogrenci() // kurucu metot , constructor method
        {
            Console.WriteLine("Öğrenci oluşturuldu");
        }

        public Ogrenci(int no, string ad, string soyad)
        {
            No = no;
            Ad = ad;
            Soyad = soyad;
            Console.WriteLine("Öğrenci oluşturuldu. Bilgiler eklendi");

        }

        // bu sınıfta ekrana yazı yazdırma işleri yapmayı tercih etmeyeceğiz.
        public void OrtalamaYazdir()
        {
            int toplam = MatematikNotu + TurkceNotu + FenNotu + SosyalNotu;
            float ortalama = (float)toplam / 4;

            Console.WriteLine(No + " numaralı öğrencinin ortalamsı : " + ortalama);
        }

        public float OrtalamaGetir()
        {
            int toplam = MatematikNotu + TurkceNotu + FenNotu + SosyalNotu;
            float ortalama = (float)toplam / 4;

            return ortalama;

        }

        public void YasHesapla()
        {
            Yas = 2023 - DogumYili;
        }

        public int YasHesapla(int yil)
        {
            return 2023 - yil;
        }

    }
}
