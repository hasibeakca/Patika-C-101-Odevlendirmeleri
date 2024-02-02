// Saate göre selamlama mesajı
int time = DateTime.Now.Hour;

if (time < 12)
{
    Console.WriteLine("Günaydın!");
}
else if (time >= 12 || time < 17)
{
    Console.WriteLine("İyi öğlenler!");
} else if( time > 17)
{
    Console.WriteLine("İyi akşamlar!");
}
string sonuc = time < 12 ? "Günaydın" : time < 17 || time >= 12 ? "İyi Öğlenler" : "iyi Akşamlar";
Console.WriteLine(sonuc);