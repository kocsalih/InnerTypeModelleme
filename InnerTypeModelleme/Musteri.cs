using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class Musteri
    {
        #region Tekil olarak Kullanılan
        
        public int musteriId { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyIsim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public string kullaniID { get; set; }

        #endregion

        #region inner type gerktiren alanlar

        public MusteriAdres[] musteriAdresleri;
        public MusteriIletisimBilgisi[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[3];
            musteriIletisimBilgileri = new MusteriIletisimBilgisi[10];
        }

        #endregion
    }
}
