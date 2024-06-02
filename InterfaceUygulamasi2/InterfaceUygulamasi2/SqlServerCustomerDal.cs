using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi2
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
}
