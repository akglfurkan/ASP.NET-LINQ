using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<UrunContext>
    {
        // Entity Framework initializer

        protected override void Seed(UrunContext context)
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                 new Kategori(){ KategoriAdi="Telefon"},
                 new Kategori(){ KategoriAdi="Bilgisayar"},
                 new Kategori(){ KategoriAdi="Laptop"},
                 new Kategori(){ KategoriAdi="Beyazeşya"}
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();


            List<Urun> urunler = new List<Urun>()
            {
                    new Urun(){ UrunAdi="Samsung S5", Fiyat=1000, StokAdeti=100, KategoriId=1},
                    new Urun(){ UrunAdi="Samsung S6", Fiyat=2000, StokAdeti=100, KategoriId=1},
                    new Urun(){ UrunAdi="Samsung S7", Fiyat=3000, StokAdeti=100, KategoriId=1},
                    new Urun(){ UrunAdi="Samsung S8", Fiyat=4000, StokAdeti=20, KategoriId=1},
                    new Urun(){ UrunAdi="Samsung S9", Fiyat=5000, StokAdeti=100, KategoriId=1},
                    new Urun(){ UrunAdi="Samsung S00", Fiyat=6000, StokAdeti=0, KategoriId=1},
                    new Urun(){ UrunAdi="Samsung S11", Fiyat=7000, StokAdeti=100, KategoriId=1},
                    new Urun(){ UrunAdi="Samsung S12", Fiyat=8000, StokAdeti=200, KategoriId=1},
                    new Urun(){ UrunAdi="Bilgisayar ürünü 1", Fiyat=1000, StokAdeti=100, KategoriId=2},
                    new Urun(){ UrunAdi="Bilgisayar ürünü 2 ", Fiyat=2000, StokAdeti=100, KategoriId=2},
                    new Urun(){ UrunAdi="Bilgisayar ürünü 3 ", Fiyat=3000, StokAdeti=100, KategoriId=2},
                    new Urun(){ UrunAdi="Bilgisayar ürünü 4", Fiyat=4000, StokAdeti=20, KategoriId=2},
                    new Urun(){ UrunAdi="Bilgisayar ürünü 5", Fiyat=5000, StokAdeti=100, KategoriId=2},
                    new Urun(){ UrunAdi="Bilgisayar ürünü 5", Fiyat=6000, StokAdeti=0, KategoriId=2},
                    new Urun(){ UrunAdi="Bilgisayar ürünü 7", Fiyat=7000, StokAdeti=100, KategoriId=2},
                    new Urun(){ UrunAdi="Bilgisayar ürünü 8", Fiyat=8000, StokAdeti=200, KategoriId=2}
            };

            foreach (var item in urunler)
            {
                context.Urunler.Add(item);
            }



         

            base.Seed(context);
        }
    }
}
