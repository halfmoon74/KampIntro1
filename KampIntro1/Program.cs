using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 32_000;
            //double faizOrani = 1.45;
            //bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");

            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            //if (sistemeGirisYapmisMi==true) 
            //{
            //    Console.WriteLine("Kullanıcı ayarları butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}


            //Console.WriteLine(kategoriEtiketi);
        }
    }
}
