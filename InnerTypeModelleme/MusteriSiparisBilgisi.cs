﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class MusteriSiparisBilgisi
    {
        public string siparisNumarasi { get; set; }

        public Urun[] urunler;
        public MusteriSiparisBilgisi()
        {
            urunler = new Urun[2];
        }

        public void MusteriSiparisBilgisiTestMetod()
        {
            Console.WriteLine("Müsteri siparis Bilgisi Test Metod");
        }
    }
}
