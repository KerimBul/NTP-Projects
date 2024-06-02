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
            Console.WriteLine("A değeri gir : ");
            ucgen.A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B değeri gir : ");
            ucgen.B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C değeri gir : ");
            ucgen.C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A kenarının uzunluğu : " +ucgen.A);
            Console.WriteLine("B kenarının uzunluğu : " + ucgen.B);
            Console.WriteLine("C kenarının uzunluğu : " + ucgen.C);
            Console.ReadLine();
        }
    }
}
