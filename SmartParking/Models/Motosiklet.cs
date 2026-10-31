using SmartParking.Interfaces;
using SmartParking.Models;

namespace SmartParking.Araclar
{
    public class Motosiklet : Arac, IParkEdilebilir
    {
        public Motosiklet(string plaka, string marka, string model, int otoparkSaat)
            : base(plaka, marka, model, otoparkSaat)
        {
        }

        public override decimal UcretHesapla()
        {
            decimal saatlikOtomobil = 20m;

            decimal toplamUcret = OtoparkSaat * saatlikOtomobil;

            if (OtoparkSaat > 6)
            {
                toplamUcret = toplamUcret * 0.90m;
            }

            return toplamUcret;
        }
        public void GirisYap()
        {
            Console.WriteLine("Arac giriş yapıyor...");
        }
        public void CikisYap()
        {
            Console.WriteLine("Araç çıkış yapıyor");
        }
    }
}
