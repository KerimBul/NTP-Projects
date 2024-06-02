using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi
{
    class Worker:IWorker,ISalary,IEat
    {
        public void Work()
        {
            Console.WriteLine("Worker çalışır.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker maaş alır.");
        }

        public void Eat()
        {
            Console.WriteLine("Worker yemek yer.");
        }
    }
}
