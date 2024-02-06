// Dizi tanımlama

//1 Boyut belirterek eleman atamadan tanımlama
string[] renkler = new string[5];
//2 Başlangıçta eleman tanımlayarak oluşturma
string[] hayvanlar = { "kedi", "köpek", "kuş", "ejderha" };
//3
int[] dizi;
dizi = new int[3];

// Değer atama ve erişim
renkler[0] = "Siyah";
dizi[2] = 5;
Console.WriteLine(renkler[0]);
Console.WriteLine(dizi[2]);
Console.WriteLine(hayvanlar[0], hayvanlar[3]);
//Döngülerde dizi kullanımı

//Kullanıcıdan girilen 10 adet sayının ortalamasını alan program

Console.WriteLine("Dizinin uzunluğunu giriniz:");
int n = int.Parse(Console.ReadLine());
int[] sayilar = new int[n];
int eleman;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Dizinin {0}. elemnını giriniz.", i+1);
    eleman = int.Parse(Console.ReadLine());
    sayilar[i] = eleman;
}

int toplam = 0;
foreach (int s in sayilar)
{
   // Console.WriteLine(s);
    toplam += s;
}
Console.WriteLine(toplam/n);