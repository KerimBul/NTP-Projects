using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Classes
{
    public class Musteri
    {
        // müşteri operasyonları
        // bir class içinde o class ile ilgili metotları barındırır.
        public void Ekle() 
        {
            Console.WriteLine("Müşteri Eklendi.");
        }
        
        public void Guncelle() 
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
}
