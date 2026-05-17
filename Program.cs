using GymLib;

namespace GymApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AylikUyelik au1 = new AylikUyelik(900, 1, "Kaan Çakmak", 20, 75, "Kas kazanmak");
            AylikUyelik au2 = new AylikUyelik(850, 3, "Ahmet Yılmaz", 22, 82, "Kilo vermek");
            AylikUyelik au3 = new AylikUyelik(800, 6, "Mehmet Demir", 25, 95, "Yağ yakmak");

            YillikUyelik yu1 = new YillikUyelik(9000, 3, 10, "Ali Kaya", 21, 70, "Genel fitness");
            YillikUyelik yu2 = new YillikUyelik(10000, 4, 15, "Ayşe Arslan", 24, 58, "Form korumak");
            YillikUyelik yu3 = new YillikUyelik(12000, 5, 20, "Zeynep Şahin", 27, 65, "Sıkılaşmak");

            Uyelik[] uyelikler = { au1, au2, au3, yu1, yu2, yu3};

            for (int i = 0; i < uyelikler.Length; i++)
            {
                Console.WriteLine(uyelikler[i].UyelikBilgileri());
                Console.WriteLine("------------------");
            }

            Console.WriteLine($"Toplam üye sayısı: {Uyelik.Sayac}");
        }
    }
}