using SmartParking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.Models
{
    public class Otomobil: Arac, IParkEdilebilir
    {
        public Otomobil(string plaka, string marka, string model, int otoparkSaat)
           : base(plaka, marka, model, otoparkSaat)
        {
        }
        public void GirisYap() 
        { 
            Console.WriteLine("Araç giriş yapıyor..."); 
        }
        public void CikisYap()
        {
            Console.WriteLine("Otomobil çıkış yapıyor");
        }

        public override decimal UcretHesapla()
        {
            
            decimal saatlikOtomobil = 40m;

            decimal toplamUcret = OtoparkSaat * saatlikOtomobil;

            if (OtoparkSaat > 6)
            {
                toplamUcret = toplamUcret * 0.90m;
            }

            return toplamUcret;
        }

    }
}
