using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHayvanUygulamasi
{
    class Kopek:IHayvan , IBeslen
    {
        public void SesCikar()
        {
            Console.WriteLine("Köpek : hav hav");
        }

        public void Beslen()
        {
            Console.WriteLine("Köpek et yedi");
        }
    }
}
