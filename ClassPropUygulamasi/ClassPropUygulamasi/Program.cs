// See https://aka.ms/new-console-template for more information
using ClassPropUygulamasi;

Console.WriteLine("Hello, World!");

MusteriYonet musteriyonet = new MusteriYonet();
musteriyonet.Ekle();
musteriyonet.Guncelle();

MusteriBilgileri musteri1 = new MusteriBilgileri();
//set
musteri1.Id = 1;
musteri1.Ad = "Evin";
musteri1.Soyad = "Dağ";
musteri1.Sehir = "Mardin";

MusteriBilgileri musteri2 = new MusteriBilgileri
{
    //ctrl+space
    Id = 2,Ad="Ali",Soyad="Yılmaz",Sehir="İstanbul"
};
Console.WriteLine(musteri1.Ad); //get