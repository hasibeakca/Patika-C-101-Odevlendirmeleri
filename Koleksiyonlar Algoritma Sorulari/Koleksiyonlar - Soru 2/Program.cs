using System.Collections;

ArrayList liste = new ArrayList();
int sayi;
while(liste.Count != 10)
{
    try
    {
        sayi = int.Parse(Console.ReadLine());
        liste.Add(sayi);
    }
    catch(FormatException) 
    {
        Console.WriteLine("Lütfen int türünde bir değer giriniz.");
    }
}

ArrayList enBuyukler = new ArrayList();
ArrayList enKucukler = new ArrayList();

liste.Sort();
for (int i = 0; i < 3; i++)
{
    enKucukler.Add(liste[i]);
}
liste.Reverse();
for (int i = 0;i < 3; i++)
{
    enBuyukler.Add(liste[i]);
  
}
Console.WriteLine("Listedeki en büyükler: ");
int buyukToplam=0;
foreach (int item in enBuyukler)
{
    Console.WriteLine(item + " ");
    buyukToplam +=item ;
}
Console.WriteLine();
Console.WriteLine("Listedeki en küçükler");
int kucukToplam = 0;
foreach (int item in enKucukler)
{
    Console.WriteLine(item + " ");
    kucukToplam += item;
}

Console.WriteLine();
double kOrtalama= (kucukToplam / enKucukler.Count);
double bOrtalama = (buyukToplam / enBuyukler.Count);

Console.WriteLine("Listedeki en küçük sayıların ortalaması : " + kOrtalama);
Console.WriteLine("Listedeki en büyük sayıların ortalaması : " + bOrtalama);
Console.WriteLine("Ortalamalar toplamı : " + (kOrtalama+bOrtalama));