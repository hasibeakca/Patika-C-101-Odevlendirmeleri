using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Koleksiyonlar_2_Generic_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(1);
            sayiListesi.Add(2);
            sayiListesi.Add(3);
            sayiListesi.Add(4);
            sayiListesi.Add(5);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Mavi");
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Yeşil");

            //Count : Eleman sayısını verir

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (int i in sayiListesi)
            {
                Console.WriteLine(i);
            }
            foreach (string i in renkListesi)
            {
                Console.WriteLine(i);
            }
            // Kısa foreach gösterimi
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            // RemoveAt ile 0. elemanı çıkar:
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            //Contains ile liste içinde arama
            if (sayiListesi.Contains(8))
            {
                Console.WriteLine("3 sayı listesi içerisinde var");
            }
            else
            {
                Console.WriteLine("Bu sayı liste içinde bulunamadı.");
            }

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Mavi")); // büyük küçük harf duyarlı
            // Diziyi liste çevirme : 
            string[] hayvanlar = { "kedi", "köpke", "aslan", "ejderha" };
            List<string> hayvanlarLİstesi = new List<string>(hayvanlar);

            // Listeyi nasıl temizleriz?
            hayvanlarLİstesi.Clear();
            // List içerisinde nesne tutmak

            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Hasibe";
            kullanici1.Soyisim = "Akca";
            kullanici1.Yas = 23;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Furkan";
            kullanici2.Soyisim = "Akca";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Ares",
                Soyisim = "Akca",
                Cins = "Tekir"
            });

            foreach (Kullanicilar item in yeniListe)
            {
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.Soyisim);
                Console.WriteLine(item.Cins);

            }
            foreach (Kullanicilar item in kullaniciListesi)
            {
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.Soyisim);
                Console.WriteLine(item.Yas);




            }
        }


        public class Kullanicilar
        {
            private string isim;
            private string soyisim;
            private int yas;
            private string cins;
            public string Isim { get; set; }
            public string Soyisim { get; set; }
            public string Cins { get; set; }
            public int Yas { get; set; }
        }
    }
}
