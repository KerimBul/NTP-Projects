
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dont Repeat Yourself");
Kaydet();
Kaydet();
Kaydet();
int sonuc = Topla(2,3);
Console.WriteLine(sonuc);
Console.ReadLine();

static void Kaydet()
{
    Console.WriteLine("Kaydedildi");
}

//Parametreli Metod
static int Topla(int sayi1,int sayi2)
{
    // bu metodu kullanabilmek için iki adet veri girişi gerekir
    int result = sayi1 + sayi2;
    return result;  
}

//default (varsayılan) parametre
static int Topla2(int sayi1, int sayi2=20)
{
    // sayi2 için herhangi bir değer girilmezse, varsayılan olarak 20 alınır.
    int result = sayi1 + sayi2;
    return result;
}
//orneğin kdv oranı seçilmezse varsayılan olarak %18 belirlenir.



