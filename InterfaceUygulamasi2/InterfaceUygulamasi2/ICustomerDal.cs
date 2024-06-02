using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi2
{
    //DAL - Data Access Layer
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
}
