using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoglamaOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            //customerManager.Logger = new FileLogger();
            //customerManager.Logger = new SmsLogger();
            customerManager.Ekle();
            Console.ReadLine();
        }
    }
}
