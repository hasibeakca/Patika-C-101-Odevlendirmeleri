namespace Kurucu_Fonksiyonlar_Constructor_Kavramı
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
            // Constructor ile kolay atama:
            Calisan calisan3 = new Calisan("Ares", "Akca");
            calisan3.CalisanBilgileri();
            // CalisanBilgileri metodu 4 veriyide getirecek şekilde ayarlandı ancak yalnızca 2 sini setlediğimiz için boş kalanlar değişken türüne göre default dönecekler
            Calisan calisan4 = new Calisan("Hades", "Akca", "Kedi İşleri Müdürlüğü");
            calisan4.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        //Constructor'lar program çalışırken arka planda çalışan yapıcı metotlardır.
        //İstersen yazabilir istersen aşırı yükleme yapabilirsin.
        //Geri dönüş tipi olmaz (yoktur değil void 'de yazılmaz)
        //Herkese açık olmak zorundadır
        //Class adıyla aynı olmak zorundadır
        //İster bu classtaki tüm verilere ulaşır ister hiçbirini parametre olarak almaz isterse bir kısmını alır
        public Calisan()
        {
        }
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad; // Ad = ad; şeklinde gösterim de doğrudur.
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        //İster parametre olarak yalnızca 2 veri alsın
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            Soyad = soyad;
        }
        public Calisan(string ad, string soyad, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            Departman = departman;
        }


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }

    }
}
    

