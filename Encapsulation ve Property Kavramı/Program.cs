namespace Encapsulation_ve_Property_Kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci("hasibe" ,"Akca", 2019 ,3 );
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Elçin", "Akca", 2018, 1);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();




            
    }
        class Ogrenci
        {
            private string isim;
            private string soyisim;
            private int ogrenciNo;
            private int sinif;

            public string  Isim { get; set; }
            public string  Soyisim { get; set; }
            public int  OgrenciNo { get; set; }
            public int Sinif { 
                get => sinif;

                set
                {
                    if(value < 1)
                    {
                        Console.WriteLine("Sınıf en az 1 olabilir");
                        Sinif = 1;
                    }else
                    sinif = value;
                }
                

            } // Eger set olmasaydı bir değer tanamaz yalnızca readonly olurdu yani sadece okunabilir. Sınıf degeri en düşük 1 olması için set değerine bir koşul eklemeliyiz:

            public Ogrenci() { } // Hiç değer almayan kurucu metot
            public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
            {
                Isim = isim;
                Soyisim = soyisim;
                Sinif = sinif;
                OgrenciNo = ogrenciNo;
                
            }

            public void OgrenciBilgileriniGetir()
            {
                Console.WriteLine("*********Öğrenci Bilgileri****************");
                Console.WriteLine("Öğrenci Adı :    {0}", this.Isim);
                Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyisim);
                Console.WriteLine("Öğrenci Numarası: {0}", this.OgrenciNo);
                Console.WriteLine("Öğrenci sınıfı : {0}", this.Sinif);
            }
            public void SinifAtla()
            {
                this.Sinif += 1;
            }
            public void SinifDusur()
            {
                this.Sinif -= 1;
            }
        }
    }
}
