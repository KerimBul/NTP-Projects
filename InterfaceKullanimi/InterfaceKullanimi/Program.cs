interface IInsan
{
 // interface kullanımının temel amacı bir temel operasyon, temel nesne oluşturup bütün nesneleri ndan aktarmaktır.      
// interfaceler soyut nesnelerdir, class lar somuttur.
//Soyut nesneler ise tek başlarına hiç bir anlam ifade etmezler.

    string isim { get; set; }
}

class Ogrenci : IInsan
{
    int okulNo;
}
class Ogretmen : IInsan
{
    
}
