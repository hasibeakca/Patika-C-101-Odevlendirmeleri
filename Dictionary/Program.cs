using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1, "Hasibe Akca");
            kullanicilar.Add(2, "Furkan Akca");
            kullanicilar.Add(3, "Ares Akca");
            kullanicilar.Add(4, "Hades Akca");
           // Uniq olması gerekir aynı eleman tekrar eklenemez
           //kullanicilar.Add(4, "Hades Akca");


            // elemanlara erişim

            Console.WriteLine(kullanicilar[3]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine(kullanicilar.ContainsKey(6));
            Console.WriteLine(kullanicilar.ContainsValue("Ares Akca"));

            // Remove
            kullanicilar.Remove(1);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }
            //Just Values
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }
            //Just keys
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

        }
    }
}
