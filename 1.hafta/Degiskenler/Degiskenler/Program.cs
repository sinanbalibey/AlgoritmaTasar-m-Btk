namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 4;
            sayi = sayi * 2;

            Console.WriteLine(sayi);

            int maks, min;

            //boxing--unboxing
            int i = 23;
            object o = i;

            i *= 2;//i=i*2
            Console.WriteLine("i :" + i);
            i = (int)o;
            Console.WriteLine("i :" + i);
            Console.WriteLine("o :"+o);

          
        }
    }
}
//Değişkeni Adı,Türü ve Değeri olmalıdır.
/*
-->Değişken ismi Anahtar kelime olmamalıdır.(abstract , expilict vs)
-->Değişken isimleri harf ile başlamalıdır.Rakam ile başlayan değişken
isimleri programın hata vermesine neden olur.
-->
 */