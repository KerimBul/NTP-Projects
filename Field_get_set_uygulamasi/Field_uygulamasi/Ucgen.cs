using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_uygulamasi
{
/* Field:Bir nesnenin özelliklerini veya veri 
    alanlarını(elemanlarını) temsil eden değişkenlerdir */
    class Ucgen
    {
        //field
        public int a; 
        public int b;
        public int c;
/*get:almak,elde etmek, getirmek anlamına gelir
  Bir değer döndürmek için kullanılır (return ile).
 get özelliği kullanılırsa bu özelliğe değer ataması
 yapılamaz. Bu özellik sadece okunabilir (readonly)
 özellik olur.*/

/*set: düzenlemek, ayarlamak anlamına gelir.
 Değişkene değer atamak için kullanılır. 
 Değer döndürmez, sadece değer alabilir.*/
        public int A
        {
            get 
            {
                return a;
            }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Hatalı Bilgi");
                }
                else
                {
                    a = value;
                }
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Bilgi");
                }
                else
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Bilgi");
                }
                else
                {
                    c = value;
                }
            }
        }
    }

}
