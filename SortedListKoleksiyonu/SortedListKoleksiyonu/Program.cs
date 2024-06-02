using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListKoleksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            // sortedlist artan şekilde sıralanır
            //sortedlist koleksiyonunun nesnesini oluşturma
            SortedList ogrenciler = new SortedList();
            ogrenciler.Add(368, "Ahmet"); //veri ekleme
            ogrenciler.Remove(388); // veri silme
            ogrenciler[368] = "Mehmet"; //güncelleme
            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key+ " - " + eleman.Value);
            }


        }
    }
}
