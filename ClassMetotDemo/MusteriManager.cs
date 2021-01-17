using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriListesi = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +" " + musteri.Soyadi + " " + "listeye eklendi.");
            musteriListesi.Add(musteri);
        }
        public void Listele()
        {
            Console.WriteLine("Liste:");
            foreach (var x in musteriListesi)
            {
                Console.WriteLine(+ x.Id + " " + x.Adi+ " " + x.Soyadi);
            }
            if (musteriListesi.Count == 0)               
            {
                Console.WriteLine("Liste boş.");
            }
            
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi+ " " + "listeden çıkarıldı.");
            musteriListesi.Remove(musteri);
        }
    }
}

