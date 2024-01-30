// Ipmlicit Conversion (Bilinçsiz Dönüşüm) Küçük kapasiteliden büyük kapasiteliye çevirmek

byte a = 5;
sbyte b = 30;
short c = 10;
int d = a + b + c;
Console.WriteLine("d: " + d);
long h = d;
Console.WriteLine("h :" + h);
float i = h;
Console.WriteLine("i:" + i);
string e = "Hasibe Azra";
char f = 'f';
object g = e + f + d;
Console.WriteLine(g);

// Explicit Conversion(Bilinçli Tür Dönüşüm) // Büyük kapasiteliden küçük kapasiteliye çevirmek - Veri kaybı olabilir
int x = 4;
byte y = (byte)x;
Console.WriteLine("y:" + y);

int z = 100;
byte t = (byte)z;
Console.WriteLine("t:" + t);

float w = 10.3f;
byte v= (byte)w;
Console.WriteLine("v:" + v);
//ToString Metodu
int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy : " + yy);

string zz = 12.5f.ToString();
Console.WriteLine("zz : " + zz );

//System Convert

string s1 = "19", s2 = "20";
int sayi1 = Convert.ToInt32(s1);
int sayi2 = Convert.ToInt32(s2);
int toplam = sayi1 + sayi2;
Console.WriteLine("Toplam:" + toplam);

//Parse --Parse metodu yalnızca string verileri dönüştürebilir.
string metin1 = "10";
string metin2 = "10.23";

int rakam1 = Int32.Parse(metin1);
double d1 = Double.Parse(metin2);
Console.WriteLine("rakam1 : " + rakam1);
Console.WriteLine("d1" + d1);

//******************************************************************************

int deneme1 = 23092302;
short denemeVeriKaybi = (short)deneme1;

int deneme2 = 23423324;
short deneme2VeriKaybi = Convert.ToInt16(deneme2);

//Sayı dönüşümleri 2 şekilde de yapılabilir ancak görüldüğü üzere sadece ConvertTo dönüşümü veri kaybında hata veriyor.