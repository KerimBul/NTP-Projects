// See https://aka.ms/new-console-template for more information


int sayi1 = 20; //bu değer tip : aslında sayi1 hala 20 ancak metodun içindeki değişken 30 değerini tutmakta
int sayi2 = 100;
int sonuc = Topla(sayi1, sayi2);
//int sonuc2 = DegerTip(ref sayi1, sayi2); // bu ise referans tiptir.
//Console.WriteLine(sayi1);
Console.WriteLine(sonuc);
//Console.WriteLine(sonuc2);
//Console.WriteLine(sayi1); 
static int Topla(int sayi1, int sayi2)
{
    // sayi1 ' 20 değerini gönderdik ancak sayi1 değeri sonra 30 olarak değiştirildi.
    sayi1 = 30;
    int toplam = sayi1 + sayi2;
    return toplam;
}
static int DegerTip(ref int sayi1, int sayi2)
{
    // ref parametresini ekleyerek değişkenimizin değeri değişse dahi bu referansı kullan demiş olduk.
    sayi1 = 50;
    int toplam = sayi1 + sayi2;
    return toplam;
}
static int Out(out int sayi1, int sayi2)
{
    // out parametresinin ref'ten farkı ise metotun içinde tanımlanan değeri sadece alır.
    // dışarıdan göndeerilen referansı almaz.
    sayi1 = 50;
    int toplam = sayi1 + sayi2;
    return toplam;
}


