using System;
using System.Collections;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri müsteri1 = new Musteri()
            {
                Id = 1,
                Adi = "Erkan",
                Soyadi = "Coşar",
            };
            Musteri müsteri2 = new Musteri()
            {
                Id = 2,
                Adi = "Burhan",
                Soyadi = "Bülbül",
            };
            Musteri müsteri3 = new Musteri()
            {
                Id = 3,
                Adi = "Ömür",
                Soyadi = "Okumuş",
            };

            MusteriManager müsteriManager = new MusteriManager();
            müsteriManager.Ekle(müsteri1);
            müsteriManager.Ekle(müsteri2);
            müsteriManager.Ekle(müsteri3);

            Console.WriteLine("");

            müsteriManager.Listele();

            Console.WriteLine("");

            müsteriManager.Sil(müsteri1);
            müsteriManager.Sil(müsteri2);
            müsteriManager.Sil(müsteri3);

            Console.WriteLine("");

            müsteriManager.Listele();


        }
    }
}
