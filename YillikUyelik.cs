using System;
namespace GymLib
{
    public class YillikUyelik : Uyelik
    {
        public YillikUyelik()
        {

        }

        public YillikUyelik(double yillikUcret, int yilSayisi, double indirimOrani, string adSoyad, int yas, double kilo, string hedef)
            : base(adSoyad, yas, kilo, hedef)
        {
            YillikUcret = yillikUcret;
            YilSayisi = yilSayisi;
            IndirimOrani = indirimOrani;
            Hedef = hedef;
        }

        public double YillikUcret { get; set; }
        public int YilSayisi { get; set; }
        public double IndirimOrani { get; set; }
        public double IndirimliUcret
        {
            get => YillikUcret - (YillikUcret * IndirimOrani / 100);
        }

        public override string UyelikBilgileri()
        {
            return $"{base.UyelikBilgileri()}\nÜyelik Türü: Yıllık Üyelik\nYıl Sayısı: {YilSayisi}\nYıllık Ücret: {YillikUcret}\nİndirim Oranı: %{IndirimOrani}\nİndirimli Ücret: {IndirimliUcret}";
        }
    }
}