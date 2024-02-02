//Girilen sayıya kadar olan tek sayıları yazdırma
Console.WriteLine("Lütfen bir sayı giriniz : ");
int sayac = int.Parse(Console.ReadLine());
for (int i = 0; i <= sayac; i++)
{
    if(i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}
int teksayi = 0, ciftsayi =0 ;
for (int i = 1;i <= 1000; i++)
{
    if(i % 2 == 1)
    {
        teksayi += i;
    }
    else
    {
        ciftsayi += i;
    }
}
Console.WriteLine("Tek sayıların toplamı : "  + teksayi + "Çift sayıların toplamı : " + ciftsayi);
//break
for (int i = 1; i < 10; i++)
{
    if (i == 4)
        break;
        Console.WriteLine(i); // 3 e kadar yazar döngüden çıkar    
}
for (int i = 1; i < 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i); // sadece 4ü atlar devamını yazar    
}
// Sonsuz döngü :  for(; ; ) 