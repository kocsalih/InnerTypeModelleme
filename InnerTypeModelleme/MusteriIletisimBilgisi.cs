using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class MusteriIletisimBilgisi
    {
        public int iletisimTip { get; set; }//7177700001=mobil
        public string alanKodu { get; set; }
        public string numara { get; set; }
        public bool aktipPasif { get; set; }

        public void MusteriIletisimBilgisiTestMetod()
        {
            Console.WriteLine("MusteriIletisimBilgisiTestMetod");
        }
    }
}
