namespace TemelProgramlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz ");
            int n=Convert.ToInt32(Console.ReadLine());

            /*   Console.WriteLine("2.Sayı giriniz ");
               int m = Convert.ToInt32(Console.ReadLine());*/

            /* if(Sayi.TekMi(n))
                 Console.WriteLine("Girilen sayı tekdir :" +n);

             if (Sayi.CiftMi(n))
                 Console.WriteLine("Sayı çifdir :" + n);*/

            //Console.WriteLine("Mutlak değeri :"+"|"+n+"|"+"="+Sayi.MutlakDeger(n));

            /*   Console.WriteLine("{0}",
                   Sayi.AsalMi(n)?"Asal sayi":"Asal sayı değildir");*/

            //Console.WriteLine("{0} sayinin rakmalari toplami={1}", n, Sayi.RakamlariToplami(n));

            // Console.WriteLine("{0} Sayısının 1den kendine olan kadar sayıların toplamı={1}",n,Sayi.SayilarinToplami(n));

            // Console.WriteLine("{0} Sayısının 1den kendine olan kadar sayıların toplamı={1}",n,Sayi.SayilarinToplamiFormul(n));

            // Console.WriteLine("{0}",Sayi.TekSayilarinToplami(n));

            // Console.WriteLine("{0}", Sayi.TekSayilarinToplami2(n));

            // Console.WriteLine("{0}", Sayi.TekSayilarinToplami3(n));

            // Console.WriteLine("{0}", Sayi.CiftSayilarinToplami(n));

            // Console.WriteLine("{0}", Sayi.CiftSayilarinToplami2(n));

            // Console.WriteLine("{0}", Sayi.CiftSayilarinToplami3(n));

            // Console.WriteLine(Sayi.NeredenNereyeCiftSayilar(n, m));

            // Console.WriteLine(Sayi.CemberCevreHesapla(n));

            Console.WriteLine(Sayi.CemberAlanHesapla(n));
        }
    }
}