using SmartParking.Araclar;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.Models
{
    public class Otopark
    {
        private Arac[] araclar = new Arac[10];
        private int aracSayisi = 0;

       public void AracEkle(Arac arac)
        {
            if (aracSayisi>=araclar.Length)
            {
                Console.WriteLine("Otopark Dolu! Yeni Araç Girişi Yapılamaz...");
                return;
            }
            araclar[aracSayisi] = arac;
            aracSayisi++;
        }

        public void AracCikis(string plaka)
        {
            bool bulundu = false;
            for (int i = 0; i < araclar.Length; i++)
            {
                if (araclar[i]!=null)
                {
                    if (araclar[i].Plaka==plaka)
                    {
                        araclar[i] = null;
                        aracSayisi--;

                        bulundu=true;
                        Console.WriteLine("Araç çıkışı başarılı...");
                        break;
                    }
                }
            }
            if (bulundu==false)
            {
                Console.WriteLine("ARAÇ OTOPARKTA BULUNAMADI!..");
            }
        }
        public void ParkUcreti(string plaka)
        {
            for (int i = 0; i < araclar.Length; i++)
            {
                if (araclar[i]!=null && araclar[i].Plaka==plaka)
                {
                    Console.WriteLine($"Araç Türü: {araclar[i].GetType().Name}");
                    Console.WriteLine($"Araç Plakası: {araclar[i].Plaka}");
                    Console.WriteLine($"Otopark Saati: {araclar[i].OtoparkSaat}");

                    decimal ucret = araclar[i].UcretHesapla();
                    Console.WriteLine($"Odenecek tutar: {ucret} tl");
                    return;
                }
            }
            Console.WriteLine( "ARAC OTOPARKTA BULUNAMADI!..");
        }
        public void AracListele()
        {
            if (aracSayisi==0)
            {
                Console.WriteLine("OTOPARKTA HENÜZ ARAC BULUNMAMAKTA!");
                return;
            }
            for (int i = 0; i < araclar.Length; i++)
            {
                if (araclar[i]!=null)
                {
                    araclar[i].BilgiGetir();
                    Console.WriteLine("--------------------------------");
                }
            }
        }
        public void AracSarjEt(string plaka)
        {
            for (int i = 0; i <araclar.Length; i++)
            {
                if (araclar[i]!=null && araclar[i].Plaka==plaka)
                {
                    if (araclar[i] is ElektirikliArac)
                    {
                        ElektirikliArac elektirikliArac = (ElektirikliArac)araclar[i];
                        elektirikliArac.SarjEt();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("SEÇTİĞİNİZ ARAÇ ELEKTRİKLİ DEĞİLDİR!..");
                        return;
                    }

                }
            }
            Console.WriteLine("ARADIĞINIZ ARAÇ OTOPARKTA BULUNAMADI!..");
        }
        public void BosKapasite()
        {
            int bosKapasite = araclar.Length - aracSayisi;
            Console.WriteLine($"Otopark Kapasitesi: {araclar.Length}");
            Console.WriteLine($"Boş Alan: {bosKapasite}");
        }

    }
}
