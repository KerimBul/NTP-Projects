using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPropUygulamasi
{
    public class MusteriBilgileri
    {
        //müşterinin özelliklerini tuutmak için Propertislerden yararlanılır.
        public int Id { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Sehir { get; set; }
    }
}
