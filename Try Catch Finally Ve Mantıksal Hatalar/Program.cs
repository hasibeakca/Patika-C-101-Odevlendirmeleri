try
{
    // Hataya neden olabilecek kod buraya yazılır
    string ad = Console.ReadLine();

    Console.WriteLine("Adınız: " + ad);
}
catch (Exception ex)
{
    // ex bir değişken adıdır ve bu değişken adını farklı şekilde yazabiliriz Sonucunda yine farklıdeger.Message dediğimizde çalışır.
    // Exception yazılma sebebi tüm hataları içermesidir örneğin ben burada sıfıra bölünmeme hatasını kontrol ettirmek istersem exception kısmına dividebyzero yazarım

    Console.WriteLine("Hata : " + ex.Message.ToString()); // tostring gereksiz yazmak zorunlu değil.
}
finally
{
    //Ne olursa olsun try catch den  sonra program hatayı fırlatır ama çalışmaya devam eder bu kısımda devam ederken ne olursa olsun çalışacak kısım.
}


try
{
    //  int a = int.Parse(null);
    // int a = int.Parse("test");
    int a = int.Parse("-200000000000");

}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz.");
    Console.WriteLine(ex.Message);
}
catch(FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil" + ex.Message);
  //  Console.WriteLine(ex);
}
catch(OverflowException ex)
{
    Console.WriteLine("Çok küçük ya da cok büyük değer girilmiş " + ex.Message);
}
finally
{
    Console.WriteLine("İşlem başarıyla tamamlandı");
} 