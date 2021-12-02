using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriId = 1;
            M1.tcKimlikNumarasi = "15879625120";
            M1.isim = "faik";
            M1.soyIsim = "turan";
            M1.olusturmaTarih = DateTime.Now;

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                il = "istanbul",
                ilce = "kadıköy",
                adres = "boğanın yanı",
                adreTip = "iş yeri"
            };
            M1.musteriAdresleri[0].MusteriAdresTestMetot();

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "Sp00001"
            };


            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                UrunId = 1,
                tanim = "telefon",
                fiyat = 9000
            };

            M1.musteriSiparisBilgileri[0].urunler[1] = new Urun()
            {
                UrunId = 2,
                tanim = "bilgisayar",
                fiyat = 13000
            };

         
            Console.ReadLine();
        }
    }
}
