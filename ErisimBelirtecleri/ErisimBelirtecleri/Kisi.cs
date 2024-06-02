using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirtecleri
{
    internal class Kisi
    {
        public void KisiKaydet()
        {
            KisiEkle kisi = new KisiEkle();
            //KisiEkle class'ı internal olduğu için aynı projeden çağrılabildi.
        }
    }
}
