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

            var kategoriler = db.Kategoriler
                .Where(i=>i.KategoriAdi=="Temizlik")
                .Select(i =>
                new
                {
                    i.KategoriAdi,
                    i.Urunler
                })
                .ToList();


            foreach (var kategori in kategoriler)
            {
                Console.WriteLine(kategori.KategoriAdi);
                foreach (var urun in kategori.Urunler)
                {
                    Console.WriteLine(urun.UrunAdi);
                }
            }

            //Urun urun = new Urun();

            //urun.UrunAdi = "Omo Çamaşır Deterjanı";
            //urun.StokAdeti = 200;
            //urun.Fiyat = 30;

            //urun.Kategori = db.Kategoriler.Where(i => i.KategoriAdi == "Temizlik").FirstOrDefault();

            //db.Urunler.Add(urun);
            //db.SaveChanges();

            //foreach (var item in db.Kategoriler.Where(i => i.KategoriAdi == "Temizlik"))
            //{
            //    foreach (var entity in item.Urunler)
            //    {
            //        Console.WriteLine(entity.UrunAdi);
            //    }
            //}


            //Urun urun = new Urun();

            //urun.UrunAdi = "Ace Çamaşır Suyu";
            //urun.StokAdeti = 200;
            //urun.Fiyat = 10;

            //urun.Kategori = new Kategori() { KategoriAdi = "Temizlik" };

            //db.Urunler.Add(urun);
            //db.SaveChanges();

            //foreach (var item in db.Kategoriler.Where(i => i.KategoriAdi == "Temizlik"))
            //{
            //    foreach (var entity in item.Urunler)
            //    {
            //        Console.WriteLine(entity.UrunAdi);
            //    }
            //}


            //Kategori kategori = new Kategori();
            //kategori.KategoriAdi = "Kişisel Bakım";

            //Urun urun = new Urun();
            //urun.UrunAdi = "Signal Diş macunu";
            //urun.Fiyat = 15;
            //urun.StokAdeti = 100;

            //kategori.Urunler.Add(urun);
            //db.Kategoriler.Add(kategori);

            //db.SaveChanges();

            //foreach (var item in db.Urunler.Where(i=>i.Kategori.KategoriAdi== "Kişisel Bakım"))
            //{
            //    Console.WriteLine(item.UrunAdi);
            //}


            //Urun entity = new Urun();
            //entity.UrunAdi = "IPhone 7 Plus";
            //entity.Fiyat = 4000;
            //entity.StokAdeti = 100;
            //entity.KategoriId = 1;

            //db.Urunler.Add(entity);
            //db.SaveChanges();

            //foreach (var item in db.Urunler.Where(i => i.KategoriId == 1))
            //{
            //    Console.WriteLine("urun adı : {0}",item.UrunAdi);
            //}



            //Kategori entity = new Kategori();
            //entity.KategoriAdi = "Kitap";

            //db.Kategoriler.Add(entity);
            //db.SaveChanges();


            //foreach (var item in db.Kategoriler)
            //{
            //    Console.WriteLine(item.KategoriAdi);
            //}

            Console.ReadLine();

        }
    }
}
