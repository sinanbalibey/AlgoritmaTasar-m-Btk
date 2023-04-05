using System.Linq;
namespace VarObjectDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var x = 23;//impicitly type
            int y = 23;//expilicityl type

            string[] meyveler = { "elma","armut","muz","üzüm","seftali" };

            var meyve=from m in meyveler
                      where m[0]=='a'
                      select m;
            foreach (string m in meyve) 
                Console.Write(m);
            
           
        }
    }
}

/*
-->Değişken tanımı yapılırken tip belirlemeden
var deyimi kullanılabilir.
-->var i adesi ile tanımlanan değişkenler için ilk değer ataması
yapılmalıdır.
-->Değişkenin tipi kullanılan veri türüne bağlı olarak C# tarafından
otomatik olarak belirlenecektir.
-->Kullanılan ya da tanımlanan veri türünün tipi almak üzere GetType deyimi
kullanılmaktadır.
 */