﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class Kategori
    {
        public Kategori()
        {
            Urunler = new List<Urun>();
        }

        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        //lazy loading ve eager loading
        //burası program anında kullanılacak
        public  List<Urun> Urunler { get; set; }
    }
}
