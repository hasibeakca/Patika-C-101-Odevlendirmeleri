using System.Collections;

ArrayList liste = new ArrayList();
int sayi;
while(liste.Count != 20)
{
	try
	{
		sayi = int.Parse(Console.ReadLine());
		if(sayi < 0)
		{
            Console.WriteLine("Lütfen pozitif bir sayı giriniz");
        }
		else
		{
            liste.Add(sayi);
        }

	}
	catch (FormatException)
	{

        Console.WriteLine("Lütfen bir tamsayı giriniz");
    }
}
ArrayList asallar = new ArrayList();
ArrayList asalOlmayanlar = new ArrayList();
foreach(int item in liste)
{
	bool sonuc = AsalMi(item);

	if (sonuc == true)
	{
		asallar.Add(item);
	}
	else
	{
		asalOlmayanlar.Add(item);
	}
}

asallar.Sort();
asalOlmayanlar.Sort();

asallar.Reverse();

Console.WriteLine("Asal sayılar");
int asalToplam = 0;
foreach (int item in asallar)
{
    Console.Write(item + " ");
	asalToplam += item;
}
Console.WriteLine();
asalOlmayanlar.Reverse();

Console.WriteLine("Asal olmayan sayılar");
int asalOlmayanToplam = 0;
foreach(int item in asalOlmayanlar)
{
    Console.Write(item + " ");
	asalOlmayanToplam += item;
}
Console.WriteLine();


Console.WriteLine("Asal sayılar listesinin eleman sayısı : " + asallar.Count);
// DİKKAT! EĞER HİÇ ASAL SAYI GİRİLMEDİYSE BÖLÜM ESNASINDA DIVIDE BY ZERO HATASI VEREBİLİR.
Console.WriteLine("Asal sayılar listesinin ortalaması : " + (asalToplam/asallar.Count));

Console.WriteLine("Asal olmayan sayılar listesinin eleman sayısı :" + asalOlmayanlar.Count);
Console.WriteLine("Asal olmayan sayılar listesinin ortalaması :" + (asalOlmayanToplam/asalOlmayanlar.Count));













static bool AsalMi(int x)
{
	int bolunen = 0;
	for(int i = 1; i <= x; i++)
	{
		if(x%i==0)
		{
			bolunen++;
		}
	}

	if (bolunen == 2)
	{
		return true;
	}
	else
	{
        return false;
    }
	
}