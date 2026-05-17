using System;
using GymLib;
namespace GymLib
{
    public class AylikUyelik : Uyelik
    {
        public AylikUyelik()
        {

        }

        public AylikUyelik(double aylikUcret, int aySayisi, string adSoyad, int yas, double kilo, string hedef)
            : base(adSoyad, yas, kilo, hedef)
        {
            AylikUcret = aylikUcret;
            AySayisi = aySayisi;
        }

        public double AylikUcret { get; set; }
        public int AySayisi { get; set; }

        public double ToplamUcret
        {
            get => AylikUcret * AySayisi;
        }

        public override string UyelikBilgileri()
        {
            return $"{base.UyelikBilgileri()}\nÜyelik Türü: Aylık Üyelik\nAylık Ücret: {AylikUcret}\nAy Sayısı: {AySayisi}\nToplam Ücret: {ToplamUcret}";
        }
    }
}
