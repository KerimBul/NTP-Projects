using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableKoleksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable nesnesi oluşturma
            Hashtable ogrenciler = new Hashtable();
            ogrenciler.Add(550, "Evin"); // veri ekleme 1. yol
            ogrenciler.Add("Enes", 1944); // veri ekleme 2. yol
            ogrenciler.Add(551, "Ufuk");
            ogrenciler.Add(552, "Alper");
            ogrenciler.Add(553, "Ehad");
            ogrenciler.Add(554, "Semih");
            ogrenciler.Add(555, "Taha");

            //silme
            ogrenciler.Remove(550);
            ogrenciler.Remove("Ehad");

            //güncelleme
            ogrenciler[554] = "Kerim";

            foreach (var anahtar in ogrenciler.Keys)
            {
                Console.WriteLine(anahtar);
            }
            foreach (var deger in ogrenciler.Values)
            {
                Console.WriteLine(deger);
            }

            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key + " - " + eleman.Value);
            }
            Console.ReadLine();
        }
    }
}
