using System;

namespace GymLib
{
    public class Uyelik
    {
        public static int Sayac { get; private set; }

        public Uyelik()
        {
            Sayac++;
        }

        public Uyelik(string adSoyad, int yas, double kilo, string hedef = "Genel Fitness")
        {
            AdSoyad = adSoyad;
            Yas = yas;
            Kilo = kilo;
            Hedef = hedef;
            Sayac++;
        }

        private string adSoyad;
        private int yas;
        private double kilo;

        public string Seviye { get; private set; }

        public string AdSoyad
        {
            get => adSoyad;
            set => adSoyad = value.ToUpper();
        }

        public int Yas
        {
            get => yas;
            set => yas = Math.Abs(value);
        }

        public double Kilo
        {
            get => kilo;
            set
            {
                if (value < 30)
                {
                    throw new Exception("Kilo değeri 30'dan küçük olamaz.");
                }

                kilo = value;

                if (kilo < 60)
                {
                    Seviye = "Zayıf";
                }
                else if (kilo >= 60 && kilo <= 90)
                {
                    Seviye = "Normal";
                }
                else
                {
                    Seviye = "Kilolu";
                }
            }
        }

        public string Hedef { get; set; }

        public virtual string UyelikBilgileri()
        {
            return $"Ad Soyad: {AdSoyad}\nYaş: {Yas}\nKilo: {Kilo}\nHedef: {Hedef}\nSeviye: {Seviye}";
        }
    }
}
