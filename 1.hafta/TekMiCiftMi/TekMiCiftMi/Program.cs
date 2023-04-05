namespace TekMiCiftMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            while (true)
            {
                Console.WriteLine("Sayı giriniz?");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a % 2 == 0)
                {
                    Console.WriteLine("Sayı çift");
                }
                else if (a % 2 == 1)
                {
                    Console.WriteLine("Sayı tek");
                }
                else if (a % 2 == -1)
                {
                    Console.WriteLine("Sayı tek");
                }
                else
                {
                    Console.WriteLine("Sayı negatif");
                }
                Console.WriteLine("-----------------------");
            } 

           
        }
    }
}

/*
-->Her bir algoritmanın bir başlangıç ve bitiş noktası olmalıdır
-->Algoritmalar herhangi bir teknik kavram içermemelidir.
-->Problemin çözümü adım adım anlatılmalıdır.
-->Kullanılan ifadeler sade ve anlaşılır olmalıdır.
-->Hiçbir çözüm aşamasında algoritma kararsız kalmamalıdır.
-->Çözüme giden en kısa ve en az maliyete sahip yol tercih edilmelidir.
-->C# genel amaçlı, tür-güvenli (type-safe) ve nesne yönelimli bir
programlama (object-oriented programming)dilidir.
-->Temel hedefi üretkenliktir.
-->Bu amaçla basitlik, program tabanlı söz dizili ve performans
arasında bir denge kurmaya çalışır.
-->Platform bağımsızdır.
-->Dinamik hafıza yönetimi(Garbage Collector)
 */

/*
     PASCAL CASE
        FontColor,MessageBox
     CAMEL CASE
        foreColor,messegeBox
     UPPER CASE
        System.IO,System.Web.UI
 */