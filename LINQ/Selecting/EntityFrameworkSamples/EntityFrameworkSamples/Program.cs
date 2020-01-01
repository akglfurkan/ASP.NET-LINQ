using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            UrunContext db = new UrunContext();

            //model için bir obje üretelim.

            var kategoriler = db.Kategoriler
                .Select(a =>
                new KategoriUrunModel()
                {
                    KategoriAdi = a.KategoriAdi,
                    Urunler = a.Urunler.Select(b => new UrunModel()
                    {
                        UrunAdi = b.UrunAdi,
                        Fiyat = b.Fiyat
                    }).ToList()
                })
                .ToList();

            foreach (var kategori in kategoriler)
            {
                Console.WriteLine("kategori : {0}", kategori.KategoriAdi);
                foreach (var urun in kategori.Urunler)
                {
                    Console.WriteLine("urun adı : {0} fiyat : {1}", urun.UrunAdi, urun.Fiyat);
                }

                Console.WriteLine("-------------------------------------");

            }





            //var urunler = db.Urunler
            //      .Select(i => new UrunModel()
            //      {
            //           UrunAdi = i.UrunAdi.Length > 12 ? i.UrunAdi.Substring(0, 9) + "..." : i.UrunAdi,
            //           Fiyat = i.Fiyat,
            //           Kategori=i.Kategori.KategoriAdi
            //      })
            //     .ToList();

            //// @model List<UrunModel>

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("urun adı : {0} fiyat : {1} kategori : {2} ", urun.UrunAdi, urun.Fiyat,urun.Kategori);
            //}


            //var urunler = db.Urunler
            //      .Select(i => new
            //      {
            //          //anonymous object
            //          ProductName = i.UrunAdi.Length > 12 ? i.UrunAdi.Substring(0, 9) + "..." : i.UrunAdi,
            //          Price = i.Fiyat
            //      })
            //     .ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("urun adı : {0} fiyat : {1} ", urun.ProductName, urun.Price);
            //}

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("urun id : {4} urun adı : {0} fiyat : {1} stok : {2} kategori id : {3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.KategoriId, urun.Id);
            //}

            Console.ReadLine();

        }
    }
}
