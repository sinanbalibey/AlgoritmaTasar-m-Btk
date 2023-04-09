using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TemelProgramlama
{
    public class Sayi
    {
        public static bool TekMi(int n)
        {
            if (n % 2 == 1)
            {
                return true;
            }
            return false;
        }

        public static bool CiftMi(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static int MutlakDeger(int n)
        {
            if (n >= 0)
            {
                return n;
            }
            else
            {
                return -1 * n;
            }
        }

        public static bool AsalMi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("En küçük asal sayi 2 dir");
                return false;
            }
            bool kontrol = true;

            for(int i = 2;i<n;i++)
            {
                if(n%i==0)
                {
                    kontrol = false;
                    break;
                }
            }

            return kontrol;
        }

        public static int RakamlariToplami(int n)
        {
            int toplam = 0, rakam = 0;

            while(n>0)
            {
                rakam = n % 10;
                toplam += rakam;
                n=n/10;
            }
            return toplam;
        }

        public static int SayilarinToplami(int n)
        {
            int toplam = 0;
            for(int i=1;i<=n;i++)
            {
                toplam = toplam + i;
            }
            return toplam;
        }

        public static int SayilarinToplamiFormul(int n)
        {

            return (n) * (n + 1) / 2;
        }

        public static int TekSayilarinToplami(int n)
        {
            int toplam = 0;

            for(int i=1;i<=n;i++)
            {
                if(i%2==1)
                {
                    toplam = toplam + i;
                }
            }
            return toplam;
        }

        public static int TekSayilarinToplami2(int n)
        {
            int toplam = 0;

            for (int i = 1; i <= n; i=i+2)
            {
               toplam=toplam + i;
            }
            return toplam;
        }

        public static int TekSayilarinToplami3(int n)
        {
            n=n+1;
            n = n / 2;
            return n*n;
        }

        public static int CiftSayilarinToplami(int n)
        {
            int toplam = 0;
            for(int i = 0; i <= n; i++)
            {
                if(i%2==0)
                {
                    toplam=toplam+i;
                }
            }
            return toplam;
        }

        public static int CiftSayilarinToplami2(int n)
        {
            int toplam = 0;
            for(int i = 0; i <= n; i = i + 2)
            {
                toplam = toplam + i;
            }
            return toplam;
        }

        public static int CiftSayilarinToplami3(int n)
        {
            n = n / 2;
            return n*(n+1);
        }

        public static int NeredenNereyeCiftSayilar(int n,int m)
        {
            int toplam = 0;

            for(int i=n;i<=m;i=i + 2)
            {
                toplam = toplam + i;
            }

            return toplam;
        }

        public static double CemberCevreHesapla(int n)
        {
            //n=yarıçap==r
            const double pi = 3.14;

            double cevre = 2 * (pi) * n;

            return cevre;
            
        }

        public static double CemberAlanHesapla(int n)
        {
            //n=r=yarıcap
            const double pi = 3.14;
            
            double cevre=pi*(n*n);

            return cevre;
        }
    }
}
