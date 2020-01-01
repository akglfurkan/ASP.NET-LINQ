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

            var urunler = db.Urunler
                .OrderByDescending(i => i.Id)
                .Take(5)
                .ToList();

            foreach (var item in urunler)
            {
                Console.WriteLine("urun adı : {0} fiyat : {1}", item.UrunAdi, item.Fiyat);
            }

            Console.ReadLine();

        }
    }
}
