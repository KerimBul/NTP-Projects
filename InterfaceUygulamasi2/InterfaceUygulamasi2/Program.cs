using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(sqlServerCustomerDal);
            Console.ReadLine();
        }
    }
}
