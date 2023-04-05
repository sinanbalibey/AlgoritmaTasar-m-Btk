namespace Degiskenler2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double pi = 3.1428;//sabit deger 
            double alan, r;

            Console.WriteLine("r =");
            r=Convert.ToDouble(Console.ReadLine());

            alan = pi * r * r;
            Console.WriteLine("r={0} icin alan={1}",r,alan);
                
            Console.WriteLine("----------------");
            Program _tarih=new Program();
            Console.WriteLine("----------------");

            int sayi = 5;
            const int c1 = 3;

            Console.WriteLine(c1);
            Console.WriteLine("-----------------");

            var mC=new SampleClass(11,22);
            Console.WriteLine($"x={mC.x},y={mC.y}");
            Console.WriteLine($"C1={SampleClass.C1},C2={SampleClass.C2}");






            Console.Read();
        }
        class SampleClass
        {
            public int x;
            public int y;

            public const int C1 = 5;
            public const int C2 = C1 + 5;

            public SampleClass(int p1,int p2)
            {
                x = p1;
                y = p2;
            }

        }
        readonly DateTime tarih;//değiştirelibilir sabit
        public Program()
        {
            tarih = DateTime.Now;
            Console.WriteLine(tarih);
        }
    }
}
/*
--> static const berar kullanılamaz.
-->consta ilk değer verilmelidir.
-->sabitler sabitlerle kullanılır.(toplama çıkarma)
-->
 */