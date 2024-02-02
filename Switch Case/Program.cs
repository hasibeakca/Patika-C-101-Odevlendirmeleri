int month = DateTime.Now.Month;
switch (month)
{
    case 1:
        Console.WriteLine("Ocak");
        break;
    case 2:
        Console.WriteLine("Şubat");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    case 4:
        Console.WriteLine("Nisan");
        break;
    case 5:
        Console.WriteLine("Mayıs");
        break;
    case 6:
        Console.WriteLine("Haziran");
        break;
    case 7:
        Console.WriteLine("Temmuz");
        break;
    case 8:
        Console.WriteLine("Ağustos");
        break;
    case 9:
        Console.WriteLine("Eylül");
        break;
    case 10:
        Console.WriteLine("Ekim");
        break;
    case 11:
        Console.WriteLine("Kasım");
        break;
    case 12:
        Console.WriteLine("Aralık");
        break;
   // default: Değeri kullanıcıdan alsaydık böyle bir defaul yazabilirdik.
     //   Console.WriteLine("Yanlış değer girdiniz");
       // break;
}
//Sıranın veya defaultun nerede olduğunun bir önemi yok.
switch(month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış ayındasınız.");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlk bahar ayındasınız.");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz ayındasınız");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar ayındasınız");
        break;
    default:
        Console.WriteLine("Yanlış bir değer girdiniz.");
        break;

}