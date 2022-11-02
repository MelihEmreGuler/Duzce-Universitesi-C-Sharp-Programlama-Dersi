using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_siniflar_
{
    enum Bolumler
    {
        Muhendislik, Tip, Egitim, Besyo, 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1;
            ogr1 = new Ogrenci();
            ogr1.Adi = "Melih";
            ogr1.Yas = 21;
            ogr1.Cinsiyet = true; //erkek
            ogr1.Bolum = Bolumler.Muhendislik; //atamasaydik varsayilan degeri ilk indisi.
            ogr1.Velisi = new Veli();
            ogr1.Velisi.Adi = "Hatice";
            ogr1.Velisi.Yas = 48;

            ogr1.OgrenciYaz();

            Ogrenci ogr2;
            ogr2 = new Ogrenci();
            ogr2.Adi = "Melike";
            ogr2.Yas = 20;
            ogr2.Cinsiyet = false; //erkek
            ogr1.Bolum = Bolumler.Muhendislik;
            ogr2.Velisi = new Veli()
            {
                Adi = "Mustafa",
                Yas = 48,
            };

            Veli veli1 = new Veli()
            {
                Adi = "Mustafa",
                Yas = 50,
            };
            

            Console.ReadLine();
        }
    }
    class Ogrenci
    {
        public int Yas;
        public string Adi;

        public bool Cinsiyet { get; set; }
        public Bolumler Bolum { get; set; }
        public Veli Velisi { get; set; }

        public void OgrenciYaz()
        {
            Console.WriteLine("Ogrencinin Adi : " + Adi);
            Console.WriteLine("Ogrencinin Yasi : " + Yas);
            Console.WriteLine("Ogrencinin Cinsiyeti : " + Cinsiyet);
            Console.WriteLine("Ogrencinin Bolum : " + Bolum);
            Console.WriteLine("Ogrencinin Velisinin Adi: " + Velisi.Adi);
            Console.WriteLine("Ogrencinin Velisinin Yasi: " + Velisi.Yas);
        }
    }
}
