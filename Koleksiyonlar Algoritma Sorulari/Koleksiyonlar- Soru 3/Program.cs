using System.Collections;
string cumle = "";

try
{
	cumle = Console.ReadLine();
}
catch (NullReferenceException)
{

    Console.WriteLine("Lütfen geçerli bir cümle giriniz!");
}

char [] cumleDizi = cumle.ToCharArray();
ArrayList sesliler = new ArrayList();

foreach(char c in cumleDizi)
{
    if(c == 'a' || c =='e' || c== 'o' || c== 'ö' || c== 'ı' || c == 'i' || c == 'u' || c == 'ü')
    {
        sesliler.Add(c);
    }
}
sesliler.Sort();
foreach(char c in sesliler)
{ Console.WriteLine(c); }