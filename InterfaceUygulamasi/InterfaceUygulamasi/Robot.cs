using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi
{
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Çalışır.");
        }
    }

}
