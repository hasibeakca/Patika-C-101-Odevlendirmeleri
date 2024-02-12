string degisken = "Dersimiz CSharp , Hoşgeldiniz";
string degisken2 = "Dersimiz CSharp ";
//Length stringin uzunluğunu verir
Console.WriteLine(degisken.Length);

//ToUpper ToLower //Tüm harfleri büyütme, küçültme
Console.WriteLine(degisken.ToLower());
Console.WriteLine(degisken.ToUpper());
//Concat
Console.WriteLine(String.Concat(degisken, " Merhaba"));
//Compare , CompareTo // karşılaştırm sonucu birinci değişken karakter sayısı > ikinci degisken krk sayısı ise 1 , eşitse 0 , küçükse -1 döner

Console.WriteLine(degisken.CompareTo(degisken2));
//Compare yazımı farlıdır dikkat.
Console.WriteLine(String.Compare(degisken, degisken2, true)); // ture amacı büyük küçük harf duyarlı olsun
Console.WriteLine(String.Compare(degisken, degisken2, false)); // önemli değil duyarsız olsun

//Contains birinin içinde bir veri arama - İster başka bir değişken olsun ister bir stringi yazarak arama

Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.Contains("Merhaba"));
//IndexOf aranan verinin bulduğun andaki basladığı index(bulamazsa -1 döner)

Console.WriteLine(degisken.IndexOf("CS"));
Console.WriteLine(degisken.IndexOf("Hasibe"));
//String içinde geçen son i'nin index numarasını vermek.
Console.WriteLine(degisken.LastIndexOf("i"));
//Insert index konumunu vererek veri girmek
Console.WriteLine(degisken.Insert(0, "Merhaba"));
//PadLeft, PadRight
//degisken 2 nin soluna  karakter sayısı 30 oluncaya kadar boşluk ekle
Console.WriteLine(degisken + degisken2.PadLeft(30));
//degisken 2 nin soluna karakter sayısı 30 oluncaya kadar yıldız ekle
Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
//Sağına
Console.WriteLine(degisken + degisken2.PadRight(30, '*'));
Console.WriteLine(degisken.PadLeft(50,'?') + degisken2.PadRight(30, '*'));

//Remove

Console.WriteLine(degisken.Remove(10)); // 10. indexten sonrasını sil
Console.WriteLine(degisken.Remove(5,4)); // 5. indexten sonra 4 adet sil
Console.WriteLine(degisken.Remove(0,1)); // en baştakini sil

//replace
Console.WriteLine(degisken.Replace("CSharp", "C#")); // CSharp'ı C#'a çevir
Console.WriteLine(degisken.Replace(" ", "*")); // Boşlukları yıldıza çevir

//Split 
Console.WriteLine(degisken.Split(' ')[1]); // Boşluklara göre bir diziye ata 1. elemanı getir.

//Substring
Console.WriteLine(degisken.Substring(4)); // 4. indexten başlayarak sonuna kadar getir
Console.WriteLine(degisken.Substring(4,6)); // 4. indexten başla 6 adet getir