using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.a = 5;
            ucgen.b = 12;
            ucgen.c = 13;
            Console.WriteLine("Üçgenin a kenarı : " + ucgen.a);
            Console.WriteLine("Üçgenin b kenarı : " + ucgen.b);
            Console.WriteLine("Üçgenin c kenarı : " + ucgen.c);
            Console.ReadLine();
        }
    }
}
