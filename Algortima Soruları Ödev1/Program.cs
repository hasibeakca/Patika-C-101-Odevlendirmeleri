#region SORU 1
// Soru 1 : Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
int sayi;
do
{
    //Pozitif bir sayı girilene kadar sormaya devam eder
    Console.WriteLine("Lütfen pozitif bir tam sayı giriniz : ");
    sayi = int.Parse(Console.ReadLine());
} while (sayi <= 0);
int[] dizi = new int[sayi];

for (int i = 0; i < sayi; i++)
{
    Console.WriteLine("Dizinin {0}. elemanını giriniz.", i+1);
    dizi[i]= int.Parse(Console.ReadLine());
}

foreach (int i in dizi)
{
    if(i%2==0)
    {
        Console.WriteLine("Dizi içerisindeki pozitif sayılar: ");
        Console.WriteLine(i);
    }
}

#endregion

#region SORU 2
//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
int n , m, girilenDeger;

do
{
    Console.WriteLine("Pozitif bir n değeri giriniz:");
    n = int.Parse(Console.ReadLine());

}while(n <= 0);
do
{
    Console.WriteLine("Pozitif bir m değeri giriniz:");
    m = int.Parse(Console.ReadLine());

} while (m <= 0);
int[] dizi2 = new int[n];
for (int i = 0; i < n; i++)
{
    do
    {
        Console.WriteLine("Dizinin pozitif elemanlarını giriniz:");
        girilenDeger = int.Parse(Console.ReadLine());
    } while (girilenDeger <= 0);
    dizi2[i] = girilenDeger;

}
foreach(int i in dizi2)
{
    if(i == m || i%m == 0)
    {
        Console.WriteLine("Bu sayı m'e eşit ya da tam bölünebilmektedir : " + i);
    }
}

#endregion

#region SORU 3
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
int n2;
do
{
    Console.WriteLine("Dizinin kaç elemanlı olmasını istersiniz : ");
    n2 = int.Parse(Console.ReadLine());
} while (n2 <= 0);
string[] kelimeler = new string[n2];
string degisken;
for(int i = 0; i < n2; i++)
{
    Console.WriteLine("Dizinizin {0}. kelimesini giriniz: ", i + 1);
    do
    {
        degisken = Console.ReadLine();
    } while (degisken == null);
   
    kelimeler[i] = degisken;
}
Array.Sort(kelimeler);
Console.WriteLine("Cümlenizin tersten yazılmş hali : ");
foreach (string i in kelimeler)
{
    Console.Write(i + " ");
}

#endregion

#region SORU 4
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        Console.WriteLine("Lütfen bir cümle yazın:");
        string cumle = Console.ReadLine();

      
        int kelimeSayisi = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

      
        int karakterSayisi = cumle.Length;

        int harfSayisi = 0;
        foreach (char karakter in cumle)
        {
            if (char.IsLetter(karakter)) // IsLetter karakterin boşluk mu özel karakter mi olup olmadığını kontrol eder
            {
                harfSayisi++;
            }
        }

        Console.WriteLine("Cümledeki toplam kelime sayısı: " + kelimeSayisi);
        Console.WriteLine("Cümledeki toplam harf sayısı: " + harfSayisi);
    


#endregion