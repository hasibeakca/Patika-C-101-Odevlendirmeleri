// 1 ile girilen sayı arasındaki sayı arasındaki sayıların ortalamasını hesaplama.

int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while (sayac <= sayi)
{
   toplam += sayac;
    sayac++;
}
Console.WriteLine(toplam/sayi);


char karakter = 'a';
while (karakter <= 'z')
{
    Console.Write(karakter);
    karakter++;
}
Console.WriteLine("***********************Foreach*************");
string[] arabalar = { "bmw", "toyota", "nissan", "ford" };
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}