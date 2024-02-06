

int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
Console.WriteLine("Sırasız dizi :");
foreach (int item in sayiDizisi)
{
    Console.WriteLine(item);
}


// Dizilerde sıralama için kullanılan 'sort' metodu
Console.WriteLine("Sıralı dizi: ");
Array.Sort(sayiDizisi);
foreach (int item in sayiDizisi)
{
    Console.WriteLine(item);
}



//Dizilerde belli bir sayıdan başka bir sayıya kadar silme işlemi için kullanılan 'clear' metodu
// 2. indexten itibaren iki elemanı sıralama
Console.WriteLine("İstenilen elemanların silindiği dizi");
Array.Clear(sayiDizisi,2,2);
foreach (int item in sayiDizisi)
{
    Console.WriteLine(item);
}

//Reverse
//sayiDizisi elemanlarını tersten sıralar
Console.WriteLine("Tersten sıralanmış dizi (reverse)");
Array.Reverse(sayiDizisi);
foreach (int item in sayiDizisi)
{
    Console.WriteLine(item);
}

//ındexOf verilen elemanın indexini döner

// 23 değerinin kaçıncı indexte olduğunu gösterir.,
Console.WriteLine("23 sayısının indexi : ");
Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

//Resize 
Console.WriteLine("Dizinin eleman sayısını artırıp o elemana 99 eklendikten sonraki hali:");
Array.Resize<int>(ref sayiDizisi, 9);
sayiDizisi[8] = 99;
foreach (int item in sayiDizisi)
{
    Console.WriteLine(item);
}
