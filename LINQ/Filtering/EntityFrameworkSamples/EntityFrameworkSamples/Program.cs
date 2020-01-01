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

            //var urun = db.Urunler.Where(i => i.Id == 1).FirstOrDefault();
            //var urunler = db.Urunler.Where(i => i.KategoriId == 1).ToList();
            //var urunler = db.Urunler.Where(i => i.Fiyat>1000 && i.Fiyat<3000).ToList();
            //var urunler = db.Urunler.Where(i => i.Kategori.KategoriAdi == "Telefon").ToList();

            //var urunler = db.Kategoriler.Where(i => i.KategoriAdi == "Telefon")
            //    .SelectMany(i => i.Urunler)
            //    .ToList();


            var urunler = db.Kategoriler
                .Where(i => i.KategoriAdi == "Bilgisayar" || i.KategoriAdi=="Telefon")
                .Select(i => new KategoriUrunModel()
                {
                    KategoriAdi = i.KategoriAdi,
                    Urunler = i.Urunler.Where(a => a.Fiyat > 1000).Select(a => new UrunModel()
                    {
                        Fiyat = a.Fiyat,
                        UrunAdi = a.UrunAdi
                    }).ToList()
                });


            foreach (var item in urunler)
            {
                Console.WriteLine("kategori adı : {0}", item.KategoriAdi);

                foreach (var urun in item.Urunler)
                {
                    Console.WriteLine("urun adı : {0} urun fiyatı : {1}", urun.UrunAdi, urun.Fiyat);
                }
                Console.WriteLine("--------------------------------------------");
            }

            Console.ReadLine();

        }
    }
}
