using SmartParking.Araclar;
using SmartParking.Models;

Otopark otopark = new Otopark();

Otomobil arac = new Otomobil("34CMK87","VOLVO", "XC90",5);
otopark.AracEkle(arac);
Motosiklet arac2 = new Motosiklet("34ABC123", "YAMAHA", "R25", 3);
otopark.AracEkle(arac2);
ElektirikliArac arac3 = new ElektirikliArac("34XYZ123", "TESLA", "MODEL Y", 8);
otopark.AracEkle(arac3);

bool devamEt = true;
while (devamEt)
{
    Console.WriteLine("\n===================== AKILLI OTOPARK YÖNETİM SİSTEMİ =====================\n");
    Console.WriteLine("1. ARAÇ GİRİŞİ YAP");
    Console.WriteLine("2. ARAÇ ÇIKIŞI YAP");
    Console.WriteLine("3. PARK ÜCRETİNİ HESAPLA");
    Console.WriteLine("4. OTOPARKTAKİ ARAÇLARI LİSTELE");
    Console.WriteLine("5. ELEKTRİKLİ ARAÇ ŞARJ İŞLEMİ YAP");
    Console.WriteLine("6. BOŞ KAPASİTEYİ GÖRÜNTÜLE");
    Console.WriteLine("7. ÇIKIŞ");

    Console.Write("\nİşlem Seçiminiz: ");
    int secimYap=Convert.ToInt32(Console.ReadLine());

    switch (secimYap)
    {
        case 1:
            Console.WriteLine("\n=========== ARAÇ GİRİŞİ ==========\n");

            Console.WriteLine("1- Otomobil");
            Console.WriteLine("2- Motosiklet");
            Console.WriteLine("3- Elektrikli Arac");

            Console.Write("\nAraç Türünü Girin: ");
            int tur=Convert.ToInt32(Console.ReadLine());

            Console.Write("Araç Plakası Girin: ");
            string plaka=Console.ReadLine();

            Console.Write("Araç Markasını Girin: ");
            string marka=Console.ReadLine();

            Console.Write("Araç Modelini Girin: ");
            string model=Console.ReadLine();

            Console.Write("Otoparkta Kalış Saati: ");
            int OtoparkSaati=Convert.ToInt32(Console.ReadLine());

            Arac yeniArac = null;
            switch (tur)

            {
              
                case 1:
                    yeniArac =new Otomobil(plaka,marka,model,OtoparkSaati);
                    break;
                case 2:
                    yeniArac = new Motosiklet(plaka,marka,model,OtoparkSaati);
                    break;
                case 3:
                    yeniArac = new ElektirikliArac(plaka,marka,model,OtoparkSaati);
                    break;
                default:
                    Console.WriteLine("TANIMSIZ TÜR!..");
                    break;
            }
            if (yeniArac != null)
            {
                otopark.AracEkle(yeniArac);
            }
            break;

        case 2:

            Console.WriteLine("\n=========== ARAÇ ÇIKIŞI ==========\n");
            Console.Write("Aracın Plakasını Girin: ");
            string Aplaka=Console.ReadLine();

            otopark.AracCikis(Aplaka);
            break;

        case 3:
        
            Console.WriteLine("\n========= PARK ÜCRET HESABI ==========\n");

            Console.Write("Araç Plakasını Girin: ");
            string plakasi=Console.ReadLine();

            otopark.ParkUcreti(plakasi);
            break;

        case 4:
            Console.WriteLine("\n========= OTOPARKTAKİ ARAÇLAR ==========\n");
            otopark.AracListele();
            break;

        case 5:
            Console.WriteLine("\n=========== ELEKTRİKLİ ARAÇ ŞARJ İŞLEMİ ============\n");
            Console.Write("Şarj etmek istediğiniz aracın plakasını girin: ");
            string AracPlaka=Console.ReadLine();

            otopark.AracSarjEt(AracPlaka);
            break;

        case 6:
            Console.WriteLine("\n=========== BOŞ KAPASİTE ============\n");
            otopark.BosKapasite();
            break;

        case 7:

            devamEt = false;
            Console.WriteLine("Çıkış Yapılıyor...");
            Console.ReadKey();
            break;

        default:
            Console.WriteLine("TANIMSIZ SEÇİM!");
            break;
    }
}
Console.ReadKey();