namespace KMOSP_R
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak İster\n");

            Console.Write("İsim Giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Soyisim Giriniz: ");
            string soyisim = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hoşgeldiniz " + isim + " " + soyisim);

            Console.Write("Kuralları Biliyor Musunuz? : ");
            char kuralCevap = char.Parse(Console.ReadLine().ToUpper());

            if (kuralCevap != 'E')
            {
                // TODO: Kurallar eklenecek.
                Console.WriteLine("Kurallar: asdfasdaads");
            }

            Console.Write("Hazır Mısınız? : ");
            char hazirCevap = char.Parse(Console.ReadLine().ToUpper());

            if (hazirCevap != 'E')
            {
                Console.WriteLine("Hazır olmananız bekleniyor.");
                Console.WriteLine("Hazır olduğunuzda Enter'a Basın");
                Console.ReadLine();
            }
        }
    }
}