using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        byte b = 5;
        sbyte sb = 5;
        // Byte türü bellekte 1 byte yer kaplar. Aynı değeri farklı değişkenlere verebiliriz. Ancak aynı isimde 2 farklı değer tanımlayamayız. 
        short a = 5;
        ushort us = 5;
        // 'u' harfi 'unsigned' (imzalanmamış) anlamına gelir ve 0'dan yukarı pozitif sayıları içerir.
        Int16 i16 = 2; // 2 byte    
        int i = 2; // 4 byte
        Int32 i32 = 3; // 4 byte
        Int64 i64 = 3; // 8 byte

        uint ui = 5; // pozitif int'ler  
        long l = 2;
        ulong ul = 4;
        float f = 2;
        double d = 23;
        decimal dec = 121;
        // Dünyanın en gereksiz ödevi.
         object o = "Object türü içerisinde her türden veriyi tutabilir.";
        char c = 'a';
        string str = "abcd";
        bool b1 = true; // 'true' kelimesinin doğru yazımı
        
        
      
        // Datetime
        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);
        string dt1 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(dt1);
        string dt2 = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(dt2);
        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
    }
}
