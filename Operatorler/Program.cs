int x = 3;
int y = 3;
y = y + 2;
Console.WriteLine(y);
y += 2;
Console.WriteLine(y);
y /= 1;
Console.WriteLine(y);
x *= 2;
Console.WriteLine(x);

//Mantıksal Operatörler
// || && !

bool isSuccess = true;
bool isCompleted = true;

if(isSuccess && isCompleted)
    Console.WriteLine("Perfect!");
if (isSuccess || isCompleted)
    Console.WriteLine("Great");
if (isSuccess &&  !isCompleted)
    Console.WriteLine("Fine");
//ilişkisel Operatörler
//< , > , <= >= !=
int a = 3;
int b = 4;
bool sonuc = a < b;
Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a >= b;
Console.WriteLine(sonuc);
sonuc = a == b;
Console.WriteLine(sonuc);
sonuc = a != b;
Console.WriteLine(sonuc);

//Aritmetik operatörler
// + , -, /, *

int sayi = 10;
int sayi1 = 5;
int sonuc1 = sayi / sayi1;
Console.WriteLine(sonuc1);
int sonuc2 = sayi * sayi1;
Console.WriteLine(sonuc2);
int sonuc3 = sayi + sayi1;
Console.WriteLine(sonuc3);
int sonuc4 = sayi - sayi1;
Console.WriteLine(sonuc4);
int sonuc5 = sayi1++;
Console.WriteLine(sonuc5);
int sonuc6 = ++sayi1;
Console.WriteLine(sonuc6);
// % mod alır;
int sonuc7= 20 % 3;
Console.WriteLine(sonuc7);