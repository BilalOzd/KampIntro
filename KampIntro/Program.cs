using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //type safety
            string kategoriEtiketi = "Kategori";

            //DRY - don't repeat yourself
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            //use a function instead of this

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
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

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);



        }
    }
}
