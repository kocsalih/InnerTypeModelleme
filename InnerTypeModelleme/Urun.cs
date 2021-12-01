using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string tanim { get; set; }
        public decimal fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Urun Yapici Metod Çalıştı");
        }
        public void UrunTestMetod()
        {
            Console.WriteLine("Urun Test metod");
        }


    }
}
