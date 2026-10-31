using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.Models
{
    public class Arac
    {
        public string Plaka {  get; set; }

        public string Marka {  get; set; }
        public string Model {  get; set; }
        private int otoparkSaat;
        public int OtoparkSaat
        {
            get { return otoparkSaat; }
            set
            {
                if (value > 0)
                {
                    otoparkSaat = value;
                }
                else
                {
                    Console.WriteLine("Otopark saati 0'dan büyük olmalıdır.");
                }
            }
        }
        public decimal SaatlikUcret {  get; set; }

     
        public Arac(string plaka, string marka)
        {
            Plaka = plaka;
            Marka = marka;
        }

        public Arac(string plaka,string marka, string model)
        {
            Plaka= plaka;
            Marka= marka;
            Model= model;
        }
           public Arac(string plaka, string marka, string model, int otoparkSaat)
        {
            Plaka = plaka;
            Marka = marka;
            Model = model;
            OtoparkSaat = otoparkSaat;
        }
        public virtual decimal UcretHesapla()
        {
            return 0;
        }
        public virtual void BilgiGetir()
        {
            Console.WriteLine($"Araç Plaka: {Plaka}");
            Console.WriteLine($"Araç Marka: {Marka}");
            Console.WriteLine($"Araç Model: {Model}");
            Console.WriteLine($"Otoparkta Kalınan Saat: {OtoparkSaat}");
        }
    }

}
