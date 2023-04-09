namespace KontrolYapilariSwitch
{
    internal class Program
    {
        public enum Renkler
        {
            Kirmizi,
            Yesil,
            Mavi
        }
        static void Main(string[] args)
        {
            Renkler r=(Renkler)(new Random()).Next(0,3);
            
            switch (r)
            {
                case Renkler.Kirmizi:
                    Console.WriteLine("Renk kırmızıdır");
                    break;

                case Renkler.Yesil:
                    Console.WriteLine("Renk Yeşildir");
                    break;

                case Renkler.Mavi:
                    Console.WriteLine("Renk Mavidir");
                    break;
                default:
                    Console.WriteLine("Renk bilinmiyor");
                    break;
            }

            Console.WriteLine("-----------------------------");

            Random rnd =new Random();

            int caseSwitch = rnd.Next(1, 4);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"Case{caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"Beklenmeyen durum{caseSwitch}");
                    break;
            }
        }
    }
}
/*
-->Break kullanmak zorunlu her durumdan sonra.
-->
 */