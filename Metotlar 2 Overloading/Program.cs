// Out parametreler
using System.Data;

string sayi = "999";
// String ifadeyi int'e çevirebilir mi çeviremez mi buna göre bool sonuç döndür.

bool sonuc = int.TryParse(sayi, out int outsayi);
Console.WriteLine(sonuc);

string sayi2 = "232sss";
bool sonuc2 = int.TryParse(sayi2, out int outsayi2);
Console.WriteLine(sonuc2);

Metotlar instance = new Metotlar();
instance.Topla(4, 5, out int toplam);
Console.WriteLine(toplam);


//Metot Overloading - Aşırı yükleme
int ifade = 2312;
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir(ifade);
// Metot imzası :  MetotAdı + parametre sayisi+ parametre ile oluşur eğer parametre değişirse isim aynı olsa dahi farklı bir metot olarak sayar. Böylece overloading olur.
instance.EkranaYazdir("Hasibe", "Akca");

class Metotlar
{
    public void Topla(int a , int b , out int toplam)
    {
        toplam = a + b;
        
    }
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1 , string veri2)
    {
        Console.WriteLine(veri1 + veri2 );
    }
}