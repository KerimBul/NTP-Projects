using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriYonetimi musteriyonet = new MusteriYonetimi();
            musteriyonet.Ekle();
            musteriyonet.Guncelle();

            MusteriBilgileri musteri1 = new MusteriBilgileri();
            musteri1.Id = 1;
            musteri1.Ad = "Evin";
            musteri1.Soyad = "Dağ";
            musteri1.Sehir = "Mardin";

            MusteriBilgileri musteri2 = new MusteriBilgileri
            {
                Id = 2,
                Ad = "Miray",
                Soyad = "Topaç",
                Sehir = "Konya"
            };
            Console.WriteLine(musteri2.Sehir);
            Console.ReadLine();
            
        }
    }
}
