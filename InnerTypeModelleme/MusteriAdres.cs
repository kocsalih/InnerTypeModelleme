using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class MusteriAdres
    {
        public string adreTip { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string adres { get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("Müsteri Adres Yapıcı Metod Çalıştı");
        }

        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("MusteriAdresTEstmetod");
        }

    }
}
