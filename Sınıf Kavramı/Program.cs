using System.Diagnostics.Contracts;

namespace Sınıf_Kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            //class SinifAdi
            //
            //{
            //    [Erişim Belirleyicisi][Veri Tipi] ÖzellikAdi;
            //    [Erişim Belirleyicisi][Geri Dönüş Tipi] MetodAdi(Parametre Listesi);
               // {
               //    Metot Komutları
               //}
            //}


            // Erişim Belirleyiciler
            //* Public : Heryerden erişilebilen
            //* Private : Sadece tanımlandığı sınıf tarafından erişilebilen
            //*Internal : Sadece tanımlandığı proje içerisinde erişilebilen metotlar ve proportyler
            //*Protected : sadece tanımlandığı sınıfta ve o sınıftan kalıtım alan sınıflarda kullanılabilir.

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Hasibe";
            calisan1.Soyad = "Akca";
            calisan1.No = 1;
            calisan1.Departman = "IT";

            calisan1.CalisanBilgileri();


            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Furkan";
            calisan2.Soyad = "Akca";
            calisan2.No = 2;
            calisan2.Departman = "IT Destek";
            calisan2.CalisanBilgileri();
            
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
       
    }
}
