namespace Static_Sınıf_ve_Üyeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static sınıfına yalnızca 1 kere uğrar oda en başta uğradı eğer aşağıdaki satırı yazdırmasaydık atama yapılırken cağırılan calisan adlı metot static olan olacaktı
            Console.WriteLine("Başlangıçtaki çalışan sayısı : {0}", Calisan.Calisansayisi);
            Calisan calisan = new Calisan("Hasibe", "Akca", "IT");
            Console.WriteLine("Şimdiki çalışan sayısı : {0}", Calisan.Calisansayisi);
            Calisan calisan1 = new Calisan("Ares", "Akca", "KIM");
            Calisan calisan2 = new Calisan("Hades", "Akca", "KIM");
            Calisan calisan3 = new Calisan("Pistoş", "Akca", "KIM");

            Console.WriteLine("Toplama işlemi sonucu : {0}", Islemler.Topla(300,200));
            Console.WriteLine("Çıkarma işlemi sonucu : {0}", Islemler.Cikar(300,200));


        }
    }
    class Calisan
    {
        private static int calisansayisi;
        public static int Calisansayisi { get => calisansayisi; }
        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan()
        {
            calisansayisi = 0;
        }
        public Calisan(string ısim, string soyisim, string departman)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Departman = departman;
            calisansayisi++;
        }
    }
    // Static sınıfın üyelerine sınıfadı. diyerek erişebilirsiniz nesne üzerinden erişim sağlanamaz.
    static class Islemler
    {
        public static int Topla(int x, int y)
        {
            return x + y;
        }
        public static int Cikar(int x, int y)
        {
            return x - y;
        }
    }
}
