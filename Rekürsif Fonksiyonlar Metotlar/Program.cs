// rekürsif metot ile faktör programı
// Başlangıç el alışkanlığı için farklı bir class oluşturup onun içinde fonksiyonu yazıp yukarıda onu çağırmak.

Metotlar ornek = new();
int faktor = ornek.Faktor(3);
Console.WriteLine(faktor);

int sonuc = ornek.UsAlma(2,5);
Console.WriteLine(sonuc);
//extencion metotlar
string ad = "Hasibe Akca";
//bir extension metodu çağırmak için bir nesne örneği oluşturmanıza gerek yoktur çünkü extension metodu zaten bir nesne örneği üzerinde çalışacak şekilde tasarlanmıştır : ad.CheckSpaces(); şeklinde çağırılması yeterlidir.
Console.WriteLine(ad.CheckSpaces());
string bosluksuz = ad.RemoveWhiteSpaces();
Console.WriteLine(bosluksuz);
Console.WriteLine(ad.MakeLowerCase());
Console.WriteLine(ad.MakeUpperCase());
int[] dizi = { 1, 4, 2, 4, 5, 3, 8, 9, 8 };
dizi.SortArray();
dizi.EkranaYazdir();

int sayi = 5;
Console.WriteLine(sayi.IsEvenNumber());

Console.WriteLine(ad.GetFirstCharacter());
class Metotlar
{
    public int Faktor(int x)
    {
        if (x == 0) 
            return 1;
        else
        {
            return x * Faktor(x - 1);
        }
    }
    public int UsAlma(int x, int y)
    {
        if (y > 1)
        {
            return UsAlma(x, y - 1) * x;
        }
        else if (y == 0)
        {
            return 1;
        }
        else if (y == 1)
        {
            return x;
        }
        return 0;
          
        
    }
}

public static class Extensions
{
    public static bool CheckSpaces( this string s)
    {
        return s.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string s)
    {
        string[] dizi = s.Split(" ");
        return string.Join("", dizi); // "" demek boşluk yerine konulacak şey demektir."*" yazarak boşluk yerine yıldız yazar
    }
    public static string MakeUpperCase( this string s)
    {
        return s.ToUpper();
    }
    public static string MakeLowerCase(this string s)
    {
        return s.ToLower();
    }
    public static int [] SortArray(this int [] s)
    {
       Array.Sort(s);
        return s;
    }
    public static void EkranaYazdir(this int[] s)
    {
        foreach(int i in s)
        {
            Console.WriteLine(i);
        }
    }
    public static bool IsEvenNumber(this int s)
    {
        return s % 2 == 0;
    }
    public static string GetFirstCharacter(this string s)
    {
        return s.Substring(0, 1);
    }
}