namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine(Gunler.Cuma); // Cumaya 23 değerini atadıktan sonra bir sonraki güne ardındaki sayıyı ekleyecek
            Console.WriteLine((int)Gunler.Cumartesi);
            // Pzt 1 olduğundan salı 2 çarş 3 diye devam edecek ancak cumadan sonra yeni değerler alacak
            Console.WriteLine((int)Gunler.Salı);


            int sicaklik = int.Parse(Console.ReadLine());
            if(sicaklik <= (int)HavaSicakligi.soguk)
            {
                Console.WriteLine("Sıkı giyin hava soğuk");
            }else if(sicaklik <= (int)HavaSicakligi.normal && sicaklik >= (int)HavaSicakligi.normal)
                    {
                Console.WriteLine("Hava normal");
            }else if(sicaklik < (int)HavaSicakligi.sicak && sicaklik > (int)HavaSicakligi.normal)
            {
                Console.WriteLine("Hava sıcak");
            }else
            {
                Console.WriteLine("Dışarısı kaynıyor! Dşkkat et güneş kremini unutma.");
            }



        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }
    enum HavaSicakligi
    {
        soguk = 5,
        normal = 25,
        sicak = 35
    }
}
