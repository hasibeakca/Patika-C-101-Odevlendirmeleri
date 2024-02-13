using System.Collections;

namespace Koleksiyonlar_3_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add(1);
            //liste.Add("Ayşe");
            //liste.Add(true);
            //liste.Add('A');

            // içerisindeki verilere erişim
            //foreach(var i in liste)
            //{
            //    Console.WriteLine(i);
            //}

            // AddRange
            string[] renkler = { "Mavi", "kırmızı", "yeşil" };
            List<int> sayilar = new List<int>() { 1,3,5,2,5,7,9,0};
            
           // liste.AddRange(renkler);
            liste.AddRange(sayilar);
            Console.WriteLine("Sıralanmamış liste: ");
            foreach (var i in liste)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // Sort işleminde patlayabilir çünkü içerisinde her türden veri var listelerin dezavantajı budur. Yalnızca sayılar kalacak şekilde yorum satırına aldık:
            liste.Sort();
            Console.WriteLine("Sıralanmış liste: ");
            foreach (var i in liste)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // BinarySearch -- Bunu kullanabilmek için önce sıralamamız sonra indexini istediğimiz veriyi yazmamız gerekmektedir.
            Console.WriteLine("9. sayını indexi : "  +  liste.BinarySearch(9));

            Console.WriteLine("Reverse ile tersine sıralama");
            liste.Reverse();
            foreach(var i in liste)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Clear ile listeyi temizleme : ");
            liste.Clear();
            foreach(var i in liste)
            {
                Console.WriteLine(i);
            }
        }
    }
}
