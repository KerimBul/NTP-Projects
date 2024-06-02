using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHayvanUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.Beslen();
            kedi.SesCikar();
            Console.WriteLine(" ");
            Kopek kopek = new Kopek();
            kopek.Beslen();
            kopek.SesCikar();
            Console.ReadLine();
        }
    }
}
