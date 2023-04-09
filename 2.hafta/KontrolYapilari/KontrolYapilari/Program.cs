namespace KontrolYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir karekter girin");
            char ch=Convert.ToChar(Console.ReadLine());

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("Girilen karekter büyük bir karekterdir");
            }
            else if(Char.IsLower(ch))
            {
                Console.WriteLine("Girilen karekter kücük bir karekter");
            }
            else if(Char.IsDigit(ch))
            {
                Console.WriteLine("Karekter bir rakamdır");
            }
            else
            {
                Console.WriteLine("Karekter alfanumerik bir ifade değildir");
            }
            Console.WriteLine("------------------");

            bool result=true;

            if (!result)
            {
                Console.WriteLine("sonuc1");
            }
            else
            {
                Console.WriteLine("sonuc2");
            }
            Console.WriteLine("------------------");

            int m = 9;
            int n = 7;
            int p = 5;

            if(m>=n&&m>p)
            {
                Console.WriteLine("En büyük M");
            }

            if (m >= n && !(p > m))
            {
                Console.WriteLine("En büyük M");
            }
            
            if(m>n || m>p)
            {
                Console.WriteLine("m en kücük değil");
            }
        }
    }
}