using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi
{
    class Manager:IWorker,ISalary,IEat
    {
        public void Work()
        {
            Console.WriteLine("Yonetici Çalışır.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Yonetici maaş alır.");
        }

        public void Eat()
        {
            Console.WriteLine("Yönetici yemek yer");
        }
    }
}
