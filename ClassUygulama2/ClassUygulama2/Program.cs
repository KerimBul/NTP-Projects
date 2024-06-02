using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(5,6);
            Console.WriteLine("Dikdortgenin Alanı:  " + dikdortgen.AlanHesapla());
            Console.WriteLine("Dikdortgenin Çevresi: " + dikdortgen.CevreHesapla());
            Console.ReadLine();
        }
    }
}
