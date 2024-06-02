class Musteri
{
    // class içinde tanımlanan değişkenin değeri varsayılan olarak private 'tir.
     int id;
    // private bir değşken sadece tanımlandığıı blok içerisinde geçerlidir.
    public void Degisken()
    {
        int deger;
        // id = 0; kendi bloğunun içeriisinde olduğu için id private de olsa görür.
    }

    public void Sil() 
    { 
        // deger değişkenine ulaşamıyoruz.
    }
}
class Ogrenci
{
   public void Kaydet()
    {
        Musteri musteri = new Musteri();
        //musteri. dediğimizde id private olduğu için gelmez.
    }
}
// internal bir değişken ise bağlı olduğu proje içinde bir referans gerekmeden kullanılmasını sağlar..
internal class KisiEkle
{
    public string Ad { get; set; }
}
// public herhangi bir kısıtlama koymak istenmediği durumlarda kullanılır.

