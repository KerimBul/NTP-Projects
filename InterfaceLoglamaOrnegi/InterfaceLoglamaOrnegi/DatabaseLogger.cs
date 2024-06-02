using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoglamaOrnegi
{
    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına kayıt edildi.");
        }
    }
}
