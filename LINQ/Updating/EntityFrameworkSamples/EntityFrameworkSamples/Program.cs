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


            var kategoriler = db.Kategoriler.Where(i => i.Id == 1).Select(i => new { i.KategoriAdi, i.Urunler }).ToList();

            foreach (var kategori in kategoriler)
            {
                foreach (var urun in kategori.Urunler)
                {
                    urun.UrunAdi += " deneme";
                }
            }

            var urunler = db.Urunler.Where(i => i.KategoriId == 1).ToList();

            foreach (var item in urunler)
            {
                Console.WriteLine(item.UrunAdi);
            }

            db.SaveChanges();

            //var urunler = db.Urunler.ToList();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine(item.Fiyat);
            //}

            //Console.WriteLine("-------------------");

            //foreach (var item in urunler)
            //{
            //    item.Fiyat *= 1.25;
            //}

            //db.SaveChanges();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine(item.Fiyat);
            //}


            //var kategori = db.Kategoriler.Where(i => i.Id == 1).FirstOrDefault();

            //if (kategori != null)
            //{
            //    kategori.KategoriAdi = "Telefonlar";

            //    db.SaveChanges();
            //}


            //foreach (var item in db.Kategoriler)
            //{
            //    Console.WriteLine(item.KategoriAdi);
            //}


            Console.ReadLine();

        }
    }
}
